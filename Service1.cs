using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace QuartzExampleWindowsService
{
    public partial class Service1 : ServiceBase
    {
        void SureTetikle()
        {
            Scheduler sched = new Scheduler();
            sched.KullaniciSureKontrol();
        }
        public Service1()
        {
            InitializeComponent();
            SureTetikle();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
