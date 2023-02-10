namespace kibelezaTi16VictorLino
{
    partial class frmCadEmpresa
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
            this.pnlCadEmpresa = new System.Windows.Forms.Panel();
            this.mskdDataDeCadastro = new System.Windows.Forms.MaskedTextBox();
            this.mskdCnpjCpf = new System.Windows.Forms.MaskedTextBox();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.cmbCargaHoraria = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlTelefone01 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantEmpresa = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNomeFanstasiaEmpresa = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTelefone = new System.Windows.Forms.Panel();
            this.btmFecharTel = new System.Windows.Forms.Button();
            this.btnSalvarTel = new System.Windows.Forms.Button();
            this.btnLimparTel = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefone = new System.Windows.Forms.Label();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdNumeroTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCadFuncionario = new System.Windows.Forms.Label();
            this.dgvFoneEmpresa = new System.Windows.Forms.DataGridView();
            this.pnlCadEmpresa.SuspendLayout();
            this.pnlTelefone01.SuspendLayout();
            this.pnlTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadEmpresa
            // 
            this.pnlCadEmpresa.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.empresa;
            this.pnlCadEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadEmpresa.Controls.Add(this.mskdDataDeCadastro);
            this.pnlCadEmpresa.Controls.Add(this.mskdCnpjCpf);
            this.pnlCadEmpresa.Controls.Add(this.cmbDocumento);
            this.pnlCadEmpresa.Controls.Add(this.cmbCargaHoraria);
            this.pnlCadEmpresa.Controls.Add(this.btnSalvar);
            this.pnlCadEmpresa.Controls.Add(this.btnLimpar);
            this.pnlCadEmpresa.Controls.Add(this.pnlTelefone01);
            this.pnlCadEmpresa.Controls.Add(this.cmbStatus);
            this.pnlCadEmpresa.Controls.Add(this.txtEmail);
            this.pnlCadEmpresa.Controls.Add(this.txtRazaoSocial);
            this.pnlCadEmpresa.Controls.Add(this.txtNomeFantEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.txtCodigo);
            this.pnlCadEmpresa.Controls.Add(this.lblCargaHoraria);
            this.pnlCadEmpresa.Controls.Add(this.lblDataCad);
            this.pnlCadEmpresa.Controls.Add(this.lblStatus);
            this.pnlCadEmpresa.Controls.Add(this.lblEmail);
            this.pnlCadEmpresa.Controls.Add(this.lblRazaoSocial);
            this.pnlCadEmpresa.Controls.Add(this.lblCpfCnpj);
            this.pnlCadEmpresa.Controls.Add(this.lblDocumento);
            this.pnlCadEmpresa.Controls.Add(this.lblNomeFanstasiaEmpresa);
            this.pnlCadEmpresa.Controls.Add(this.lblCodigo);
            this.pnlCadEmpresa.Controls.Add(this.btnFechar);
            this.pnlCadEmpresa.Controls.Add(this.lblTitulo);
            this.pnlCadEmpresa.Location = new System.Drawing.Point(83, 125);
            this.pnlCadEmpresa.Name = "pnlCadEmpresa";
            this.pnlCadEmpresa.Size = new System.Drawing.Size(1206, 627);
            this.pnlCadEmpresa.TabIndex = 0;
            // 
            // mskdDataDeCadastro
            // 
            this.mskdDataDeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdDataDeCadastro.Location = new System.Drawing.Point(963, 327);
            this.mskdDataDeCadastro.Mask = "00/00/0000";
            this.mskdDataDeCadastro.Name = "mskdDataDeCadastro";
            this.mskdDataDeCadastro.Size = new System.Drawing.Size(216, 22);
            this.mskdDataDeCadastro.TabIndex = 37;
            this.mskdDataDeCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdDataDeCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // mskdCnpjCpf
            // 
            this.mskdCnpjCpf.Enabled = false;
            this.mskdCnpjCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdCnpjCpf.Location = new System.Drawing.Point(365, 186);
            this.mskdCnpjCpf.Mask = "00,000,000/0000-00";
            this.mskdCnpjCpf.Name = "mskdCnpjCpf";
            this.mskdCnpjCpf.Size = new System.Drawing.Size(244, 22);
            this.mskdCnpjCpf.TabIndex = 36;
            this.mskdCnpjCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Items.AddRange(new object[] {
            "CPNJ",
            "CPF"});
            this.cmbDocumento.Location = new System.Drawing.Point(200, 184);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(141, 24);
            this.cmbDocumento.TabIndex = 35;
            this.cmbDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbDocumento_SelectedIndexChanged);
            // 
            // cmbCargaHoraria
            // 
            this.cmbCargaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargaHoraria.Enabled = false;
            this.cmbCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargaHoraria.FormattingEnabled = true;
            this.cmbCargaHoraria.Items.AddRange(new object[] {
            "04:00",
            "06:00",
            "08:00",
            "10:00",
            "12:00"});
            this.cmbCargaHoraria.Location = new System.Drawing.Point(963, 392);
            this.cmbCargaHoraria.Name = "cmbCargaHoraria";
            this.cmbCargaHoraria.Size = new System.Drawing.Size(216, 24);
            this.cmbCargaHoraria.TabIndex = 34;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(985, 499);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(160, 50);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(985, 438);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 50);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnlTelefone01
            // 
            this.pnlTelefone01.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.telefone;
            this.pnlTelefone01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone01.Controls.Add(this.dgvFoneEmpresa);
            this.pnlTelefone01.Controls.Add(this.btnExcluir);
            this.pnlTelefone01.Controls.Add(this.btnAlterar);
            this.pnlTelefone01.Controls.Add(this.btnCadastrar);
            this.pnlTelefone01.Location = new System.Drawing.Point(200, 278);
            this.pnlTelefone01.Name = "pnlTelefone01";
            this.pnlTelefone01.Size = new System.Drawing.Size(752, 319);
            this.pnlTelefone01.TabIndex = 31;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(589, 266);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 50);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(356, 266);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(160, 50);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(123, 266);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbStatus.Location = new System.Drawing.Point(1035, 249);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(157, 24);
            this.cmbStatus.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(200, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(815, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(615, 186);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(577, 22);
            this.txtRazaoSocial.TabIndex = 24;
            // 
            // txtNomeFantEmpresa
            // 
            this.txtNomeFantEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantEmpresa.Location = new System.Drawing.Point(365, 119);
            this.txtNomeFantEmpresa.Name = "txtNomeFantEmpresa";
            this.txtNomeFantEmpresa.Size = new System.Drawing.Size(832, 22);
            this.txtNomeFantEmpresa.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(200, 119);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 22);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.BackColor = System.Drawing.Color.Transparent;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.lblCargaHoraria.Location = new System.Drawing.Point(980, 362);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(184, 27);
            this.lblCargaHoraria.TabIndex = 19;
            this.lblCargaHoraria.Text = "CARGA HORÁRIA";
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCad.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCad.ForeColor = System.Drawing.Color.Black;
            this.lblDataCad.Location = new System.Drawing.Point(958, 297);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(221, 27);
            this.lblDataCad.TabIndex = 18;
            this.lblDataCad.Text = "DATA DE CADASTRO";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(1030, 219);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "STATUS";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(195, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 27);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-MAIL";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.lblRazaoSocial.Location = new System.Drawing.Point(610, 156);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(171, 27);
            this.lblRazaoSocial.TabIndex = 15;
            this.lblRazaoSocial.Text = "RAZÃO SOCIAL ";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.ForeColor = System.Drawing.Color.Black;
            this.lblCpfCnpj.Location = new System.Drawing.Point(355, 156);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(128, 27);
            this.lblCpfCnpj.TabIndex = 14;
            this.lblCpfCnpj.Text = "CNPJ / CPF";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.Black;
            this.lblDocumento.Location = new System.Drawing.Point(195, 156);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(146, 27);
            this.lblDocumento.TabIndex = 13;
            this.lblDocumento.Text = "DOCUMENTO";
            // 
            // lblNomeFanstasiaEmpresa
            // 
            this.lblNomeFanstasiaEmpresa.AutoSize = true;
            this.lblNomeFanstasiaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFanstasiaEmpresa.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFanstasiaEmpresa.ForeColor = System.Drawing.Color.Black;
            this.lblNomeFanstasiaEmpresa.Location = new System.Drawing.Point(355, 86);
            this.lblNomeFanstasiaEmpresa.Name = "lblNomeFanstasiaEmpresa";
            this.lblNomeFanstasiaEmpresa.Size = new System.Drawing.Size(319, 27);
            this.lblNomeFanstasiaEmpresa.TabIndex = 12;
            this.lblNomeFanstasiaEmpresa.Text = "NOME FANTASIA DA EMPRESA";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(230, 86);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(96, 27);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFechar.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1142, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(182, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1018, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CADASTRAR EMPRESA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTelefone
            // 
            this.pnlTelefone.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.telefone;
            this.pnlTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone.Controls.Add(this.btmFecharTel);
            this.pnlTelefone.Controls.Add(this.btnSalvarTel);
            this.pnlTelefone.Controls.Add(this.btnLimparTel);
            this.pnlTelefone.Controls.Add(this.txtDescricao);
            this.pnlTelefone.Controls.Add(this.lblNumeroTelefone);
            this.pnlTelefone.Controls.Add(this.lblOperadora);
            this.pnlTelefone.Controls.Add(this.cmbOperadora);
            this.pnlTelefone.Controls.Add(this.label1);
            this.pnlTelefone.Controls.Add(this.mskdNumeroTelefone);
            this.pnlTelefone.Controls.Add(this.cmbCodigo);
            this.pnlTelefone.Controls.Add(this.lblCadFuncionario);
            this.pnlTelefone.Location = new System.Drawing.Point(1308, 189);
            this.pnlTelefone.Name = "pnlTelefone";
            this.pnlTelefone.Size = new System.Drawing.Size(620, 325);
            this.pnlTelefone.TabIndex = 12;
            this.pnlTelefone.Visible = false;
            // 
            // btmFecharTel
            // 
            this.btmFecharTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btmFecharTel.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fechar;
            this.btmFecharTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmFecharTel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmFecharTel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmFecharTel.FlatAppearance.BorderSize = 0;
            this.btmFecharTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmFecharTel.Location = new System.Drawing.Point(557, 10);
            this.btmFecharTel.Name = "btmFecharTel";
            this.btmFecharTel.Size = new System.Drawing.Size(50, 50);
            this.btmFecharTel.TabIndex = 38;
            this.btmFecharTel.UseVisualStyleBackColor = false;
            this.btmFecharTel.Click += new System.EventHandler(this.btmFecharTel_Click);
            // 
            // btnSalvarTel
            // 
            this.btnSalvarTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvarTel.FlatAppearance.BorderSize = 0;
            this.btnSalvarTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarTel.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTel.ForeColor = System.Drawing.Color.White;
            this.btnSalvarTel.Location = new System.Drawing.Point(404, 277);
            this.btnSalvarTel.Name = "btnSalvarTel";
            this.btnSalvarTel.Size = new System.Drawing.Size(160, 36);
            this.btnSalvarTel.TabIndex = 42;
            this.btnSalvarTel.Text = "SALVAR";
            this.btnSalvarTel.UseVisualStyleBackColor = false;
            this.btnSalvarTel.Click += new System.EventHandler(this.btnSalvarTel_Click);
            this.btnSalvarTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSalvarTel_KeyPress);
            // 
            // btnLimparTel
            // 
            this.btnLimparTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnLimparTel.FlatAppearance.BorderSize = 0;
            this.btnLimparTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTel.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTel.ForeColor = System.Drawing.Color.White;
            this.btnLimparTel.Location = new System.Drawing.Point(147, 277);
            this.btnLimparTel.Name = "btnLimparTel";
            this.btnLimparTel.Size = new System.Drawing.Size(160, 36);
            this.btnLimparTel.TabIndex = 38;
            this.btnLimparTel.Text = "LIMPAR";
            this.btnLimparTel.UseVisualStyleBackColor = false;
            this.btnLimparTel.Click += new System.EventHandler(this.btnLimparTel_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(251, 235);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(210, 22);
            this.txtDescricao.TabIndex = 38;
            // 
            // lblNumeroTelefone
            // 
            this.lblNumeroTelefone.AutoSize = true;
            this.lblNumeroTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroTelefone.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroTelefone.Location = new System.Drawing.Point(297, 201);
            this.lblNumeroTelefone.Name = "lblNumeroTelefone";
            this.lblNumeroTelefone.Size = new System.Drawing.Size(133, 27);
            this.lblNumeroTelefone.TabIndex = 41;
            this.lblNumeroTelefone.Text = "DESCRIÇÃO";
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.BackColor = System.Drawing.Color.Transparent;
            this.lblOperadora.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperadora.ForeColor = System.Drawing.Color.Black;
            this.lblOperadora.Location = new System.Drawing.Point(287, 144);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(143, 27);
            this.lblOperadora.TabIndex = 40;
            this.lblOperadora.Text = "OPERADORA";
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadora.Enabled = false;
            this.cmbOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperadora.FormattingEnabled = true;
            this.cmbOperadora.Items.AddRange(new object[] {
            "OI",
            "TIM",
            "CLARO",
            "VIVO"});
            this.cmbOperadora.Location = new System.Drawing.Point(251, 174);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(210, 24);
            this.cmbOperadora.TabIndex = 38;
            this.cmbOperadora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOperadora_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "NÚMERO TELEFONE";
            // 
            // mskdNumeroTelefone
            // 
            this.mskdNumeroTelefone.Enabled = false;
            this.mskdNumeroTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdNumeroTelefone.Location = new System.Drawing.Point(251, 108);
            this.mskdNumeroTelefone.Mask = "(__)_____-____";
            this.mskdNumeroTelefone.Name = "mskdNumeroTelefone";
            this.mskdNumeroTelefone.Size = new System.Drawing.Size(210, 22);
            this.mskdNumeroTelefone.TabIndex = 38;
            this.mskdNumeroTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdNumeroTelefone.ValidatingType = typeof(System.DateTime);
            this.mskdNumeroTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdNumeroTelefone_KeyPress);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbCodigo.Location = new System.Drawing.Point(358, 20);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(155, 29);
            this.cmbCodigo.TabIndex = 6;
            // 
            // lblCadFuncionario
            // 
            this.lblCadFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadFuncionario.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblCadFuncionario.Location = new System.Drawing.Point(3, 0);
            this.lblCadFuncionario.Name = "lblCadFuncionario";
            this.lblCadFuncionario.Size = new System.Drawing.Size(614, 70);
            this.lblCadFuncionario.TabIndex = 1;
            this.lblCadFuncionario.Text = "CÓDIGO";
            this.lblCadFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFoneEmpresa
            // 
            this.dgvFoneEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoneEmpresa.Location = new System.Drawing.Point(123, 3);
            this.dgvFoneEmpresa.Name = "dgvFoneEmpresa";
            this.dgvFoneEmpresa.Size = new System.Drawing.Size(626, 257);
            this.dgvFoneEmpresa.TabIndex = 4;
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16VictorLino.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 823);
            this.Controls.Add(this.pnlTelefone);
            this.Controls.Add(this.pnlCadEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadEmpresa_Load);
            this.pnlCadEmpresa.ResumeLayout(false);
            this.pnlCadEmpresa.PerformLayout();
            this.pnlTelefone01.ResumeLayout(false);
            this.pnlTelefone.ResumeLayout(false);
            this.pnlTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadEmpresa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNomeFanstasiaEmpresa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantEmpresa;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnlTelefone01;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCargaHoraria;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.MaskedTextBox mskdCnpjCpf;
        private System.Windows.Forms.MaskedTextBox mskdDataDeCadastro;
        private System.Windows.Forms.Panel pnlTelefone;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdNumeroTelefone;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCadFuncionario;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblNumeroTelefone;
        private System.Windows.Forms.Button btnLimparTel;
        private System.Windows.Forms.Button btnSalvarTel;
        private System.Windows.Forms.Button btmFecharTel;
        private System.Windows.Forms.DataGridView dgvFoneEmpresa;
    }
}