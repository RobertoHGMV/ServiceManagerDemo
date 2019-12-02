using ServiceManagerDemo.BO.Services;
using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace ServiceManagerDemoDate
{
    public partial class ServiceDate : ServiceBase
    {
        const int ONE_MINUTE = 60000;
        ISettingsService _settingsService;
        Timer _timer;
        int eventId = 1;

        public ServiceDate()
        {
            InitializeComponent();
            _timer = new Timer();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Iniciando serviço de data e hora.");
            var timeout = _settingsService.GetTimeOut(typeof(ServiceDate));

            _timer.Interval = ONE_MINUTE * Convert.ToInt32(timeout);
            _timer.Elapsed += new ElapsedEventHandler(OnTimer);
            _timer.Start();
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Parando serviço de data e hora.");
        }

        protected override void OnPause()
        {
            EventLog.WriteEntry("Pausando serviço de data e hora.");
        }

        protected override void OnContinue()
        {
            EventLog.WriteEntry("Continuando serviço de data e hora.");
        }

        protected override void OnShutdown()
        {
            EventLog.WriteEntry("Fechando serviço de data e hora.");
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            try
            {
                EventLog.WriteEntry($"Data/Hora: {DateTime.Now}", EventLogEntryType.Information, eventId++);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message);
                _timer.Stop();
            }
        }
    }
}
