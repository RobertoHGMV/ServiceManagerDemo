namespace ServiceManagerDemo.UI
{
    partial class ManagerServicesForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveConf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.btnInstaller = new System.Windows.Forms.Button();
            this.btnUinstaller = new System.Windows.Forms.Button();
            this.btnRestartServies = new System.Windows.Forms.Button();
            this.btnStopServices = new System.Windows.Forms.Button();
            this.btnStartServices = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRestartServiceDate = new System.Windows.Forms.Button();
            this.btnStopServiceDate = new System.Windows.Forms.Button();
            this.btnStartServiceDate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRestartServiceMemory = new System.Windows.Forms.Button();
            this.btnStopServiceMemory = new System.Windows.Forms.Button();
            this.btnStartServiceMemory = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 165);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveConf);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTimeOut);
            this.tabPage1.Controls.Add(this.btnInstaller);
            this.tabPage1.Controls.Add(this.btnUinstaller);
            this.tabPage1.Controls.Add(this.btnRestartServies);
            this.tabPage1.Controls.Add(this.btnStopServices);
            this.tabPage1.Controls.Add(this.btnStartServices);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor de Serviço";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveConf
            // 
            this.btnSaveConf.Location = new System.Drawing.Point(226, 93);
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.Size = new System.Drawing.Size(82, 23);
            this.btnSaveConf.TabIndex = 10;
            this.btnSaveConf.Text = "Salvar";
            this.btnSaveConf.UseVisualStyleBackColor = true;
            this.btnSaveConf.Click += new System.EventHandler(this.btnSaveConf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Timeoute (minutos)";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(120, 95);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(100, 20);
            this.txtTimeOut.TabIndex = 8;
            // 
            // btnInstaller
            // 
            this.btnInstaller.Location = new System.Drawing.Point(19, 60);
            this.btnInstaller.Name = "btnInstaller";
            this.btnInstaller.Size = new System.Drawing.Size(113, 23);
            this.btnInstaller.TabIndex = 3;
            this.btnInstaller.Text = "Instalar Serviços";
            this.btnInstaller.UseVisualStyleBackColor = true;
            this.btnInstaller.Click += new System.EventHandler(this.btnInstaller_Click);
            // 
            // btnUinstaller
            // 
            this.btnUinstaller.Location = new System.Drawing.Point(138, 60);
            this.btnUinstaller.Name = "btnUinstaller";
            this.btnUinstaller.Size = new System.Drawing.Size(113, 23);
            this.btnUinstaller.TabIndex = 4;
            this.btnUinstaller.Text = "Remover Serviços";
            this.btnUinstaller.UseVisualStyleBackColor = true;
            this.btnUinstaller.Click += new System.EventHandler(this.btnUinstaller_Click);
            // 
            // btnRestartServies
            // 
            this.btnRestartServies.Location = new System.Drawing.Point(257, 31);
            this.btnRestartServies.Name = "btnRestartServies";
            this.btnRestartServies.Size = new System.Drawing.Size(113, 23);
            this.btnRestartServies.TabIndex = 2;
            this.btnRestartServies.Text = "Reiniciar Serviços";
            this.btnRestartServies.UseVisualStyleBackColor = true;
            this.btnRestartServies.Click += new System.EventHandler(this.btnRestartServies_Click);
            // 
            // btnStopServices
            // 
            this.btnStopServices.Location = new System.Drawing.Point(138, 31);
            this.btnStopServices.Name = "btnStopServices";
            this.btnStopServices.Size = new System.Drawing.Size(113, 23);
            this.btnStopServices.TabIndex = 1;
            this.btnStopServices.Text = "Parar Serviços";
            this.btnStopServices.UseVisualStyleBackColor = true;
            this.btnStopServices.Click += new System.EventHandler(this.btnStopServices_Click);
            // 
            // btnStartServices
            // 
            this.btnStartServices.Location = new System.Drawing.Point(19, 31);
            this.btnStartServices.Name = "btnStartServices";
            this.btnStartServices.Size = new System.Drawing.Size(113, 23);
            this.btnStartServices.TabIndex = 0;
            this.btnStartServices.Text = "Iniciar Serviços";
            this.btnStartServices.UseVisualStyleBackColor = true;
            this.btnStartServices.Click += new System.EventHandler(this.btnStartServices_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRestartServiceDate);
            this.tabPage2.Controls.Add(this.btnStopServiceDate);
            this.tabPage2.Controls.Add(this.btnStartServiceDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serviço de Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRestartServiceDate
            // 
            this.btnRestartServiceDate.Location = new System.Drawing.Point(260, 36);
            this.btnRestartServiceDate.Name = "btnRestartServiceDate";
            this.btnRestartServiceDate.Size = new System.Drawing.Size(113, 23);
            this.btnRestartServiceDate.TabIndex = 5;
            this.btnRestartServiceDate.Text = "Reiniciar Serviço";
            this.btnRestartServiceDate.UseVisualStyleBackColor = true;
            this.btnRestartServiceDate.Click += new System.EventHandler(this.btnRestartServiceDate_Click);
            // 
            // btnStopServiceDate
            // 
            this.btnStopServiceDate.Location = new System.Drawing.Point(141, 36);
            this.btnStopServiceDate.Name = "btnStopServiceDate";
            this.btnStopServiceDate.Size = new System.Drawing.Size(113, 23);
            this.btnStopServiceDate.TabIndex = 4;
            this.btnStopServiceDate.Text = "Parar Serviço";
            this.btnStopServiceDate.UseVisualStyleBackColor = true;
            this.btnStopServiceDate.Click += new System.EventHandler(this.btnStopServiceDate_Click);
            // 
            // btnStartServiceDate
            // 
            this.btnStartServiceDate.Location = new System.Drawing.Point(22, 36);
            this.btnStartServiceDate.Name = "btnStartServiceDate";
            this.btnStartServiceDate.Size = new System.Drawing.Size(113, 23);
            this.btnStartServiceDate.TabIndex = 3;
            this.btnStartServiceDate.Text = "Iniciar Serviço";
            this.btnStartServiceDate.UseVisualStyleBackColor = true;
            this.btnStartServiceDate.Click += new System.EventHandler(this.btnStartServiceDate_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRestartServiceMemory);
            this.tabPage3.Controls.Add(this.btnStopServiceMemory);
            this.tabPage3.Controls.Add(this.btnStartServiceMemory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 139);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Serviço de Memória";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRestartServiceMemory
            // 
            this.btnRestartServiceMemory.Location = new System.Drawing.Point(260, 36);
            this.btnRestartServiceMemory.Name = "btnRestartServiceMemory";
            this.btnRestartServiceMemory.Size = new System.Drawing.Size(113, 23);
            this.btnRestartServiceMemory.TabIndex = 8;
            this.btnRestartServiceMemory.Text = "Reiniciar Serviço";
            this.btnRestartServiceMemory.UseVisualStyleBackColor = true;
            this.btnRestartServiceMemory.Click += new System.EventHandler(this.btnRestartServiceMemory_Click);
            // 
            // btnStopServiceMemory
            // 
            this.btnStopServiceMemory.Location = new System.Drawing.Point(141, 36);
            this.btnStopServiceMemory.Name = "btnStopServiceMemory";
            this.btnStopServiceMemory.Size = new System.Drawing.Size(113, 23);
            this.btnStopServiceMemory.TabIndex = 7;
            this.btnStopServiceMemory.Text = "Parar Serviço";
            this.btnStopServiceMemory.UseVisualStyleBackColor = true;
            this.btnStopServiceMemory.Click += new System.EventHandler(this.btnStopServiceMemory_Click);
            // 
            // btnStartServiceMemory
            // 
            this.btnStartServiceMemory.Location = new System.Drawing.Point(22, 36);
            this.btnStartServiceMemory.Name = "btnStartServiceMemory";
            this.btnStartServiceMemory.Size = new System.Drawing.Size(113, 23);
            this.btnStartServiceMemory.TabIndex = 6;
            this.btnStartServiceMemory.Text = "Iniciar Serviço";
            this.btnStartServiceMemory.UseVisualStyleBackColor = true;
            this.btnStartServiceMemory.Click += new System.EventHandler(this.btnStartServiceMemory_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.Location = new System.Drawing.Point(12, 185);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // ManagerServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 220);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStopServices;
        private System.Windows.Forms.Button btnStartServices;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button btnRestartServies;
        private System.Windows.Forms.Button btnRestartServiceDate;
        private System.Windows.Forms.Button btnStopServiceDate;
        private System.Windows.Forms.Button btnStartServiceDate;
        private System.Windows.Forms.Button btnRestartServiceMemory;
        private System.Windows.Forms.Button btnStopServiceMemory;
        private System.Windows.Forms.Button btnStartServiceMemory;
        private System.Windows.Forms.Button btnInstaller;
        private System.Windows.Forms.Button btnUinstaller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Button btnSaveConf;
    }
}

