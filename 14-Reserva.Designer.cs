namespace kibelezaTi16VictorLino
{
    partial class frmReserva
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
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.meuCalendario1 = new kibelezaTi16VictorLino.MeuCalendario();
            this.lblHoraio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblReserva = new System.Windows.Forms.Label();
            this.pnlEmpresa.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.reserva;
            this.pnlEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmpresa.Controls.Add(this.cmbHorario);
            this.pnlEmpresa.Controls.Add(this.cmbStatus);
            this.pnlEmpresa.Controls.Add(this.lblStatus);
            this.pnlEmpresa.Controls.Add(this.cmbServico);
            this.pnlEmpresa.Controls.Add(this.cmbCliente);
            this.pnlEmpresa.Controls.Add(this.cmbFuncionario);
            this.pnlEmpresa.Controls.Add(this.label1);
            this.pnlEmpresa.Controls.Add(this.lblCliente);
            this.pnlEmpresa.Controls.Add(this.lblFuncionario);
            this.pnlEmpresa.Controls.Add(this.lblDataReserva);
            this.pnlEmpresa.Controls.Add(this.meuCalendario1);
            this.pnlEmpresa.Controls.Add(this.lblHoraio);
            this.pnlEmpresa.Controls.Add(this.textBox1);
            this.pnlEmpresa.Controls.Add(this.lblObservacao);
            this.pnlEmpresa.Controls.Add(this.txtCodigo);
            this.pnlEmpresa.Controls.Add(this.btnSalvar);
            this.pnlEmpresa.Controls.Add(this.lblCodigo);
            this.pnlEmpresa.Controls.Add(this.btnLimpar);
            this.pnlEmpresa.Controls.Add(this.btnCadastrar);
            this.pnlEmpresa.Controls.Add(this.pnlReserva);
            this.pnlEmpresa.Location = new System.Drawing.Point(59, 109);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(1200, 584);
            this.pnlEmpresa.TabIndex = 1;
            // 
            // cmbHorario
            // 
            this.cmbHorario.Enabled = false;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(1078, 188);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(113, 21);
            this.cmbHorario.TabIndex = 40;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "AGUARDANDO",
            "APROVADO",
            "CANCECALDO",
            "FINALIZADO"});
            this.cmbStatus.Location = new System.Drawing.Point(208, 403);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(637, 21);
            this.cmbStatus.TabIndex = 39;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(203, 373);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 23);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "STATUS";
            // 
            // cmbServico
            // 
            this.cmbServico.Enabled = false;
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(208, 333);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(637, 21);
            this.cmbServico.TabIndex = 37;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(208, 259);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(637, 21);
            this.cmbCliente.TabIndex = 36;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Enabled = false;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(208, 188);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(637, 21);
            this.cmbFuncionario.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(203, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "SERVIÇO";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(203, 229);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(87, 23);
            this.lblCliente.TabIndex = 32;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.Black;
            this.lblFuncionario.Location = new System.Drawing.Point(203, 158);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(138, 23);
            this.lblFuncionario.TabIndex = 30;
            this.lblFuncionario.Text = "FUNCIONÁRIO";
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblDataReserva.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReserva.ForeColor = System.Drawing.Color.Black;
            this.lblDataReserva.Location = new System.Drawing.Point(880, 162);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(176, 23);
            this.lblDataReserva.TabIndex = 29;
            this.lblDataReserva.Text = "DATA DA RESERVA";
            // 
            // meuCalendario1
            // 
            this.meuCalendario1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.meuCalendario1.Location = new System.Drawing.Point(878, 194);
            this.meuCalendario1.Name = "meuCalendario1";
            this.meuCalendario1.TabIndex = 28;
            this.meuCalendario1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.meuCalendario1.TitleForeColor = System.Drawing.Color.Pink;
            // 
            // lblHoraio
            // 
            this.lblHoraio.AutoSize = true;
            this.lblHoraio.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraio.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraio.ForeColor = System.Drawing.Color.Black;
            this.lblHoraio.Location = new System.Drawing.Point(1081, 158);
            this.lblHoraio.Name = "lblHoraio";
            this.lblHoraio.Size = new System.Drawing.Size(96, 23);
            this.lblHoraio.TabIndex = 26;
            this.lblHoraio.Text = "HORÁRIO";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(354, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(837, 22);
            this.textBox1.TabIndex = 25;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.Black;
            this.lblObservacao.Location = new System.Drawing.Point(349, 75);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(133, 23);
            this.lblObservacao.TabIndex = 24;
            this.lblObservacao.Text = "OBSERVAÇÃO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(208, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 22);
            this.txtCodigo.TabIndex = 23;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(616, 523);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 50);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(203, 75);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(85, 23);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(1028, 523);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 50);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(204, 523);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlReserva.Controls.Add(this.btnFechar);
            this.pnlReserva.Controls.Add(this.lblReserva);
            this.pnlReserva.Location = new System.Drawing.Point(176, 0);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(1024, 56);
            this.pnlReserva.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(965, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblReserva
            // 
            this.lblReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReserva.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(0, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(1024, 56);
            this.lblReserva.TabIndex = 2;
            this.lblReserva.Text = "RESERVA";
            this.lblReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 818);
            this.Controls.Add(this.pnlEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.pnlReserva.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblHoraio;
        private System.Windows.Forms.Label lblDataReserva;
        private MeuCalendario meuCalendario1;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbHorario;
    }
}