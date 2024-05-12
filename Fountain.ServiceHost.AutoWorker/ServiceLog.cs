using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Threading;

namespace Fountain.ServiceHost.AutoWorker
{
    public partial class ServiceLog : ServiceBase
    {
        // 删除日志计时器
        private System.Threading.Timer deleteTimer;
        /// <summary>
        /// 构造方法
        /// </summary>
        public ServiceLog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 服务启动：服务运行时需采取的操作。
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            TimerCallback deleteTimerCallback = new TimerCallback(Delete);
            // 
            this.deleteTimer = new System.Threading.Timer(deleteTimerCallback, 30, 5000, 60000);
        }
        /// <summary>
        /// 服务停止：服务停止运行时需采取的操作。
        /// </summary>
        protected override void OnStop()
        {
            this.deleteTimer?.Dispose();
        }
        /// <summary>
        /// 删除日志文件
        /// </summary>
        /// <param name="retentionDays">保留几天的日志文件</param>
        public void Delete(object retentionDays)
        {
            try
            {
                List<string> retentionFiles = new List<string>(); 
                //文件数组
                string[] keepfile = new string[Convert.ToInt32(retentionDays)];
                for (int i = 0; i < Convert.ToInt32(retentionDays); i++)
                {
                    retentionFiles.Add(string.Format("{0:yyyyMMdd}", DateTime.Now.AddDays(-(i))));
                }
                DirectoryInfo directoryInfo= new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}{Path.DirectorySeparatorChar}log");
                //目录是否存在
                if (directoryInfo.Exists)
                {
                    foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                    {
                        if (retentionFiles.Contains(fileInfo.Name))
                        {
                            continue;
                        }
                        fileInfo.Delete();
                    }
                }
            }
            catch
            {
            }
        }
    }
}
