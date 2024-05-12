using System;
using System.ComponentModel;
using System.ServiceProcess;

namespace Fountain.ServiceHost.AutoWorker
{
    [RunInstaller(true)]
    public partial class WinServiceInstaller : System.Configuration.Install.Installer
    {
        private readonly ServiceProcessInstaller serviceProcessInstaller;
        private readonly ServiceInstaller serviceInstaller;
        public WinServiceInstaller()
        {
            try
            {
                string windowsServiceName = "ClearLogFile";
                string windowsServiceDescription = "清理日志历史文件";
                serviceProcessInstaller = new ServiceProcessInstaller
                {
                    //账户类型
                    Account = ServiceAccount.LocalSystem
                };
                serviceInstaller = new ServiceInstaller
                {
                    StartType = ServiceStartMode.Automatic,
                    //服务名称
                    ServiceName = windowsServiceName,
                    //服务描述
                    Description = windowsServiceDescription
                };
                base.Installers.Add(serviceProcessInstaller);
                base.Installers.Add(serviceInstaller);
            }
            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
        }
    }
}
