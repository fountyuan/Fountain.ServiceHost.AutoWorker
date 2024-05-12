using System.ServiceProcess;

namespace Fountain.ServiceHost.AutoWorker
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceLog()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
