using ServiceManagerDemo.BO.Services;
using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace ServiceManagerDemoMemory
{
    public partial class ServiceMemory : ServiceBase
    {
        const int ONE_MINUTE = 60000;
        ISettingsService _settingsService;
        Timer _timer;

        public ServiceMemory()
        {
            InitializeComponent();
            _settingsService = new SettingsService();
            _timer = new Timer();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Iniciando serviço de monitoramento de memória.");
            var timeout = _settingsService.GetTimeOut(typeof(ServiceMemory));

            var timer = new Timer();
            timer.Interval = ONE_MINUTE * Convert.ToInt32(timeout);
            timer.Elapsed += new ElapsedEventHandler(OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Parando serviço de monitoramento de memória.");
        }

        protected override void OnPause()
        {
            EventLog.WriteEntry("Pausando serviço de monitoramento de memória.");
        }

        protected override void OnContinue()
        {
            EventLog.WriteEntry("Continuando serviço de monitoramento de memória.");
        }

        protected override void OnShutdown()
        {
            EventLog.WriteEntry("Fechando serviço de monitoramento de memória.");
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            try
            {
                using (var proc = Process.GetCurrentProcess())
                {
                    EventLog.WriteEntry($"Memória privada: {proc.PrivateMemorySize64}");
                    EventLog.WriteEntry($"Memória física: {proc.WorkingSet64}");
                }
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message);
                _timer.Stop();
            }
        }
    }
}
