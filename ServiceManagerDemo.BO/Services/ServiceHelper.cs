using System;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace ServiceManagerDemo.BO.Services
{
    public class ServiceHelper : IServiceHelper
    {
        public void InstallService(params string[] serviceName)
        {
            foreach (var item in serviceName)
                CreateProcess(item, true);
        }

        public void UinstallService(params string[] serviceName)
        {
            foreach (var item in serviceName)
            {
                var srcController = new ServiceController(item);
                var status = srcController.Status;
                CreateProcess(item, false);
            }
        }

        public void StartService(params string[] serviceName)
        {
            foreach (var item in serviceName)
                StartService(item);
        }

        public void StopService(params string[] serviceName)
        {
            foreach (var item in serviceName)
                StopService(item);
        }

        public void RestartService(params string[] serviceName)
        {
            foreach (var item in serviceName)
            {
                StopService(item);
                StartService(item);
            }
        }

        private void CreateProcess(string serviceName, bool install)
        {
            var type = install ? "i" : "u";
            var process = Environment.Is64BitProcess ? "64" : "";
            var currDirectory = Directory.GetCurrentDirectory();
            var fileName = Path.Combine(currDirectory, $"{serviceName}.exe");
            ValidIfFileExist(fileName, serviceName);
            var command = $@"C:\WINDOWS\Microsoft.NET\Framework{process}\v4.0.30319\InstallUtil /{type} ""{fileName}""";
            var procStartInfo = new ProcessStartInfo("cmd", "/c " + command);
            var proc = new Process();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            proc.StartInfo = procStartInfo;
            proc.Start();

            var result = proc.StandardOutput.ReadToEnd();
        }

        private void ValidIfFileExist(string fileName, string serviceName)
        {
            if (!File.Exists(fileName))
                throw new Exception($"Não encontrado arquivo de serviço [{serviceName}] na pasta do projeto");
        }

        private void StartService(string serviceName)
        {
            var timeout = TimeSpan.FromMilliseconds(10000);
            var srcController = new ServiceController(serviceName);
            srcController.Start();
            srcController.WaitForStatus(ServiceControllerStatus.Running, timeout);
        }

        private void StopService(string serviceName)
        {
            var timeout = TimeSpan.FromMilliseconds(10000);
            var srcController = new ServiceController(serviceName);
            srcController.Stop();
            srcController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
        }
    }
}
