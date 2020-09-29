using ServiceManagerDemo.BO.Services;
using System;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ServiceManagerDemo.UI
{
    public partial class ManagerServicesForm : Form
    {
        const string SERVICE_NAME_DATE = "ServiceManagerDemoDate";
        const string SERVICE_NAME_MEMORY = "ServiceManagerDemoMemory";
        IServiceHelper _serviceHelper;
        ISettingsService _settingsService;

        public ManagerServicesForm()
        {
            InitializeComponent();
            _serviceHelper = new ServiceHelper();
            _settingsService = new SettingsService();

            SetButtonsDate();
            SetButtonsMemory();
        }

        #region Serviços de Memória

        private void btnRestartServiceMemory_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.RestartService(SERVICE_NAME_MEMORY);
                SetButtonsMemory();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnStopServiceMemory_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.StopService(SERVICE_NAME_MEMORY);
                SetButtonsMemory();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnStartServiceMemory_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.StartService(SERVICE_NAME_MEMORY);
                SetButtonsMemory();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        #endregion

        #region Serviçoes de Data

        private void btnRestartServiceDate_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.RestartService(SERVICE_NAME_DATE);
                SetButtonsDate();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnStopServiceDate_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.StopService(SERVICE_NAME_DATE);
                SetButtonsDate();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnStartServiceDate_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.StartService(SERVICE_NAME_DATE);
                SetButtonsDate();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        #endregion

        #region Administração de Serviços

        private void btnRestartServies_Click(object sender, EventArgs e)
        {
            try
            {
                RestartServices();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnStopServices_Click(object sender, EventArgs e)
        {
            try
            {
                StopServices();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnStartServices_Click(object sender, EventArgs e)
        {
            try
            {
                StartServices();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnInstaller_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.InstallService(SERVICE_NAME_DATE, SERVICE_NAME_MEMORY);
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnUinstaller_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceHelper.UinstallService(SERVICE_NAME_DATE, SERVICE_NAME_MEMORY);
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnSaveConf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTimeout();
                ShowSuccess();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void RestartServices()
        {
            _serviceHelper.RestartService(SERVICE_NAME_DATE, SERVICE_NAME_MEMORY);
            SetButtonsDate();
            SetButtonsMemory();
        }

        private void StopServices()
        {
            _serviceHelper.StopService(SERVICE_NAME_DATE, SERVICE_NAME_MEMORY);
            SetButtonsDate();
            SetButtonsMemory();
        }

        private void StartServices()
        {
            _serviceHelper.StartService(SERVICE_NAME_DATE, SERVICE_NAME_MEMORY);
            SetButtonsDate();
            SetButtonsMemory();
        }

        private void SaveTimeout()
        {
            var timeOut = txtTimeOut.Text;
            _settingsService.SetTimeOut(typeof(ServiceManagerDemoDate.ServiceDate), timeOut);
            _settingsService.SetTimeOut(typeof(ServiceManagerDemoMemory.ServiceMemory), timeOut);
        }

        #endregion

        private void FillControls()
        {
            txtTimeOut.Text = _settingsService.GetTimeOut(typeof(ServiceManagerDemoDate.ServiceDate));
        }

        #region SetButtons

        private void SetButtonsDate()
        {
            var srcController = new ServiceController(SERVICE_NAME_DATE);

            try
            {
                switch (srcController.Status)
                {
                    case ServiceControllerStatus.Running:
                        btnStartServiceDate.Enabled = false;
                        btnStopServiceDate.Enabled =
                            btnRestartServiceDate.Enabled = true;
                        break;
                    case ServiceControllerStatus.Paused:
                    case ServiceControllerStatus.Stopped:
                        btnStartServiceDate.Enabled = true;
                        btnStopServiceDate.Enabled =
                            btnRestartServiceDate.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void SetButtonsMemory()
        {
            var srcController = new ServiceController(SERVICE_NAME_MEMORY);

            try
            {
                switch (srcController.Status)
                {
                    case ServiceControllerStatus.Running:
                        btnStartServiceMemory.Enabled = false;
                        btnStopServiceMemory.Enabled =
                            btnRestartServiceMemory.Enabled = true;
                        break;
                    case ServiceControllerStatus.Paused:
                    case ServiceControllerStatus.Stopped:
                        btnStartServiceMemory.Enabled = true;
                        btnStopServiceMemory.Enabled =
                            btnRestartServiceMemory.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                
            }
        }

        #endregion

        #region MessageBox

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccess()
        {
            MessageBox.Show("Operação realizada com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
    }
}
