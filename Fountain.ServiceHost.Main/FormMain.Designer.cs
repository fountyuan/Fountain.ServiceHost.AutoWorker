namespace Fountain.ServiceHost.Main
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonUnInstall = new System.Windows.Forms.Button();
            this.labelServiceName = new System.Windows.Forms.Label();
            this.labelServiceDescription = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServiceDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(106, 89);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(75, 23);
            this.buttonInstall.TabIndex = 0;
            this.buttonInstall.Text = "安装服务";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonUnInstall
            // 
            this.buttonUnInstall.Location = new System.Drawing.Point(205, 89);
            this.buttonUnInstall.Name = "buttonUnInstall";
            this.buttonUnInstall.Size = new System.Drawing.Size(75, 23);
            this.buttonUnInstall.TabIndex = 1;
            this.buttonUnInstall.Text = "卸载服务";
            this.buttonUnInstall.UseVisualStyleBackColor = true;
            this.buttonUnInstall.Click += new System.EventHandler(this.buttonUnInstall_Click);
            // 
            // labelServiceName
            // 
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Location = new System.Drawing.Point(32, 20);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(56, 17);
            this.labelServiceName.TabIndex = 2;
            this.labelServiceName.Text = "服务名称";
            // 
            // labelServiceDescription
            // 
            this.labelServiceDescription.AutoSize = true;
            this.labelServiceDescription.Location = new System.Drawing.Point(32, 52);
            this.labelServiceDescription.Name = "labelServiceDescription";
            this.labelServiceDescription.Size = new System.Drawing.Size(56, 17);
            this.labelServiceDescription.TabIndex = 3;
            this.labelServiceDescription.Text = "服务描述";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxServiceName.Enabled = false;
            this.textBoxServiceName.Location = new System.Drawing.Point(106, 20);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(250, 23);
            this.textBoxServiceName.TabIndex = 4;
            this.textBoxServiceName.Text = "ClearLogFile";
            // 
            // textBoxServiceDescription
            // 
            this.textBoxServiceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxServiceDescription.Enabled = false;
            this.textBoxServiceDescription.Location = new System.Drawing.Point(106, 49);
            this.textBoxServiceDescription.Name = "textBoxServiceDescription";
            this.textBoxServiceDescription.Size = new System.Drawing.Size(250, 23);
            this.textBoxServiceDescription.TabIndex = 5;
            this.textBoxServiceDescription.Text = "清理日志历史文件";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 152);
            this.Controls.Add(this.textBoxServiceDescription);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.labelServiceDescription);
            this.Controls.Add(this.labelServiceName);
            this.Controls.Add(this.buttonUnInstall);
            this.Controls.Add(this.buttonInstall);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Button buttonUnInstall;
        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.Label labelServiceDescription;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxServiceDescription;
    }
}

