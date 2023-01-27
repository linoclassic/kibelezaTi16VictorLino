namespace kibelezaTi16VictorLino
{
    partial class frmAjuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjuda));
            this.pnlAjuda = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.tabFuncionario = new System.Windows.Forms.TabPage();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.tabServico = new System.Windows.Forms.TabPage();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.pnlAjuda.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabServico.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAjuda
            // 
            this.pnlAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pnlAjuda.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.ajuda;
            resources.ApplyResources(this.pnlAjuda, "pnlAjuda");
            this.pnlAjuda.Controls.Add(this.tabControl1);
            this.pnlAjuda.Controls.Add(this.btnFechar);
            this.pnlAjuda.Name = "pnlAjuda";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fechar;
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabEmpresa);
            this.tabControl1.Controls.Add(this.tabFuncionario);
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabServico);
            this.tabControl1.Controls.Add(this.tabRelatorio);
            this.tabControl1.Controls.Add(this.tabReserva);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabLogin
            // 
            resources.ApplyResources(this.tabLogin, "tabLogin");
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabLogin.Controls.Add(this.lblTexto);
            this.tabLogin.Name = "tabLogin";
            // 
            // tabMenu
            // 
            resources.ApplyResources(this.tabMenu, "tabMenu");
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabMenu.Controls.Add(this.lblMenu);
            this.tabMenu.Name = "tabMenu";
            // 
            // tabEmpresa
            // 
            resources.ApplyResources(this.tabEmpresa, "tabEmpresa");
            this.tabEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabEmpresa.Controls.Add(this.lblEmpresa);
            this.tabEmpresa.Name = "tabEmpresa";
            // 
            // tabFuncionario
            // 
            resources.ApplyResources(this.tabFuncionario, "tabFuncionario");
            this.tabFuncionario.Controls.Add(this.lblFuncionario);
            this.tabFuncionario.Controls.Add(this.label3);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.UseVisualStyleBackColor = true;
            // 
            // tabCliente
            // 
            resources.ApplyResources(this.tabCliente, "tabCliente");
            this.tabCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabCliente.Controls.Add(this.lblCliente);
            this.tabCliente.Name = "tabCliente";
            // 
            // tabServico
            // 
            resources.ApplyResources(this.tabServico, "tabServico");
            this.tabServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabServico.Controls.Add(this.lblServico);
            this.tabServico.Name = "tabServico";
            // 
            // tabRelatorio
            // 
            resources.ApplyResources(this.tabRelatorio, "tabRelatorio");
            this.tabRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabRelatorio.Controls.Add(this.lblRelatorio);
            this.tabRelatorio.Name = "tabRelatorio";
            // 
            // tabReserva
            // 
            resources.ApplyResources(this.tabReserva, "tabReserva");
            this.tabReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabReserva.Name = "tabReserva";
            // 
            // lblTexto
            // 
            resources.ApplyResources(this.lblTexto, "lblTexto");
            this.lblTexto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTexto.Name = "lblTexto";
            // 
            // lblMenu
            // 
            resources.ApplyResources(this.lblMenu, "lblMenu");
            this.lblMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMenu.Name = "lblMenu";
            // 
            // lblEmpresa
            // 
            resources.ApplyResources(this.lblEmpresa, "lblEmpresa");
            this.lblEmpresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmpresa.Name = "lblEmpresa";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.lblFuncionario, "lblFuncionario");
            this.lblFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFuncionario.Name = "lblFuncionario";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.lblCliente, "lblCliente");
            this.lblCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.Name = "lblCliente";
            // 
            // lblServico
            // 
            this.lblServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.lblServico, "lblServico");
            this.lblServico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblServico.Name = "lblServico";
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.lblRelatorio, "lblRelatorio");
            this.lblRelatorio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRelatorio.Name = "lblRelatorio";
            // 
            // frmAjuda
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fundo;
            this.Controls.Add(this.pnlAjuda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjuda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAjuda_Load);
            this.pnlAjuda.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabFuncionario.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabServico.ResumeLayout(false);
            this.tabRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjuda;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TabPage tabFuncionario;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabServico;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblRelatorio;
    }
}