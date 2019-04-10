using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace QuartzExampleWindowsService
{
    class Scheduler
    {
        public static IScheduler Start()
        {
            ISchedulerFactory schedFact = new StdSchedulerFactory();
            IScheduler sched = (IScheduler)schedFact.GetScheduler();
            if (!sched.IsStarted)
            {
                sched.Start();
            }
            return sched;
        }

        public void KullaniciSureKontrol() // object tipinde alacağımız modeli execute metoduna gönderip orada verileri işlemeliyiz.
        {
            IScheduler sched = Start();

            IJobDetail userTaskDetail = JobBuilder.Create<TimerControlJob>().WithIdentity("MyJob").Build();
            userTaskDetail.JobDataMap.Add("userTaskDetail", null); // gelen modeli null yerine göndermeliyiz.

            ITrigger trigger =
                TriggerBuilder.Create()
                    .WithCronSchedule("* 19 14 * * ?")  // saniye, dakika, saat, *, *, gün
                    .ForJob("MyJob")
                    .Build();
            sched.ScheduleJob(userTaskDetail, trigger);
        }
    }
}
