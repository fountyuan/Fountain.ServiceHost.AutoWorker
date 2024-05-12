using System;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Fountain.ServiceHost.Main
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 安装服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GetService(this.textBoxServiceName.Text) == null)
                {
                    string servicepath = AppDomain.CurrentDomain.BaseDirectory + @"AutoWorker.exe";
                    ManagedInstallerClass.InstallHelper(new string[] { servicepath });
                    MessageBox.Show(this.textBoxServiceName.Text + "服务已安载成功");
                }
            }
            catch (Exception exception)
            {
                if (exception.InnerException != null)
                {
                    MessageBox.Show(exception.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        /// <summary>
        /// 卸载服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GetService(this.textBoxServiceName.Text) != null)
                {
                    string servicepath = AppDomain.CurrentDomain.BaseDirectory + @"AutoWorker.exe";
                    ManagedInstallerClass.InstallHelper(new string[] { "/u", servicepath });
                    MessageBox.Show(this.textBoxServiceName.Text +  "服务已卸载成功");
                }
            }
            catch (Exception exception)
            {
                if (exception.InnerException != null)
                {
                    MessageBox.Show(exception.InnerException.Message);
                }
                else
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        /// <summary>
        /// 获得服务的对象
        /// </summary>
        /// <param name="servicename">服务名称</param>
        /// <returns>ServiceController对象,若没有该服务,则返回null</returns>
        public  ServiceController GetService(string servicename)
        {
            try
            {
                ServiceController[] serviceController = ServiceController.GetServices();
                foreach (ServiceController serviceItem in serviceController)
                {
                    if (serviceItem.ServiceName.Equals(servicename, StringComparison.OrdinalIgnoreCase))
                    {
                        return serviceItem;
                    }
                }
                return null;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
