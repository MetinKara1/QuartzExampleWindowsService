using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzExampleWindowsService
{
    class TimerControlJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var data = context.MergedJobDataMap.Get("userTaskDetail") as string;
            Logs("Görev çalıştı");

            // Verileri işleme ve yönlendirme kısmını burada yapabiliriz. Biz şuanda masaüstüne bir txt dosyası oluşturup içine bir metin basacağımız için burada
            // işlem yapmamız gerekmiyor. Çünkü gerekli metni Logs metodu içinde basıyoruz.
        }

        private void Logs(string log)
        {
            var folder = "Timer-Logs";
            var filePath = Path.Combine(@"C:\Users\nmeti\Desktop", folder);

            var file = new FileInfo(filePath);
            if (file.Directory != null && !file.Directory.Exists)
            {
                file.Directory.Create();
            }
            try
            {
                File.AppendAllText(file.FullName, string.Format(@"{0} : {1} ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), log));
            }
            catch (Exception ex)
            {
                File.AppendAllText(file.FullName, string.Format(@"{0} : {1} ", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), "hata"));
            }

        }
    }
}
