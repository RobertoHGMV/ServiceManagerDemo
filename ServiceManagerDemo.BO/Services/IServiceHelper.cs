namespace ServiceManagerDemo.BO.Services
{
    public interface IServiceHelper
    {
        void InstallService(params string[] serviceName);
        void UinstallService(params string[] serviceName);
        void StartService(params string[] serviceName);
        void StopService(params string[] serviceName);
        void RestartService(params string[] serviceName);
    }
}
