namespace SimuladorSegurosResidenciais
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPropertyValue = new System.Windows.Forms.Label();
            this.mktPropertyValue = new System.Windows.Forms.MaskedTextBox();
            this.mktGoodsValue = new System.Windows.Forms.MaskedTextBox();
            this.lblGoodsValue = new System.Windows.Forms.Label();
            this.ckbHasAlarme = new System.Windows.Forms.CheckBox();
            this.lblHasAlarm = new System.Windows.Forms.Label();
            this.cbbStates = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbbCities = new System.Windows.Forms.ComboBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblContratoDeSeguroTitle = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.maskedTextBox13 = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.maskedTextBox15 = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.epvPropertyValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.epvGoodsValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epvPropertyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvGoodsValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(282, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Simulador de Seguros";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(384, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imóvel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblPropertyValue
            // 
            this.lblPropertyValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPropertyValue.AutoSize = true;
            this.lblPropertyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPropertyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lblPropertyValue.Location = new System.Drawing.Point(92, 69);
            this.lblPropertyValue.Name = "lblPropertyValue";
            this.lblPropertyValue.Size = new System.Drawing.Size(45, 16);
            this.lblPropertyValue.TabIndex = 2;
            this.lblPropertyValue.Text = "Valor";
            this.lblPropertyValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mktPropertyValue
            // 
            this.mktPropertyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktPropertyValue.Location = new System.Drawing.Point(141, 64);
            this.mktPropertyValue.Name = "mktPropertyValue";
            this.mktPropertyValue.Size = new System.Drawing.Size(156, 21);
            this.mktPropertyValue.TabIndex = 0;
            this.mktPropertyValue.TextChanged += new System.EventHandler(this.txtPropertyValue_TextChanged);
            this.mktPropertyValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPropertyValue_KeyPress);
            this.mktPropertyValue.Leave += new System.EventHandler(this.txtPropertyValue_Leave);
            this.mktPropertyValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtPropertyValue_Validating);
            // 
            // mktGoodsValue
            // 
            this.mktGoodsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktGoodsValue.Location = new System.Drawing.Point(141, 107);
            this.mktGoodsValue.Name = "mktGoodsValue";
            this.mktGoodsValue.Size = new System.Drawing.Size(156, 21);
            this.mktGoodsValue.TabIndex = 1;
            this.mktGoodsValue.Leave += new System.EventHandler(this.mktGoodsValue_Leave);
            // 
            // lblGoodsValue
            // 
            this.lblGoodsValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGoodsValue.AutoSize = true;
            this.lblGoodsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lblGoodsValue.Location = new System.Drawing.Point(23, 110);
            this.lblGoodsValue.Name = "lblGoodsValue";
            this.lblGoodsValue.Size = new System.Drawing.Size(114, 16);
            this.lblGoodsValue.TabIndex = 4;
            this.lblGoodsValue.Text = "Valor dos Bens";
            this.lblGoodsValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckbHasAlarme
            // 
            this.ckbHasAlarme.AutoSize = true;
            this.ckbHasAlarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHasAlarme.Location = new System.Drawing.Point(141, 152);
            this.ckbHasAlarme.Name = "ckbHasAlarme";
            this.ckbHasAlarme.Size = new System.Drawing.Size(15, 14);
            this.ckbHasAlarme.TabIndex = 2;
            this.ckbHasAlarme.UseVisualStyleBackColor = true;
            this.ckbHasAlarme.CheckedChanged += new System.EventHandler(this.ckbHasAlarme_CheckedChanged);
            // 
            // lblHasAlarm
            // 
            this.lblHasAlarm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHasAlarm.AutoSize = true;
            this.lblHasAlarm.BackColor = System.Drawing.Color.Transparent;
            this.lblHasAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lblHasAlarm.Location = new System.Drawing.Point(29, 150);
            this.lblHasAlarm.Name = "lblHasAlarm";
            this.lblHasAlarm.Size = new System.Drawing.Size(108, 16);
            this.lblHasAlarm.TabIndex = 7;
            this.lblHasAlarm.Text = "Possui Alarme";
            this.lblHasAlarm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHasAlarm.Click += new System.EventHandler(this.Label3_Click);
            // 
            // cbbStates
            // 
            this.cbbStates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbStates.FormattingEnabled = true;
            this.cbbStates.Location = new System.Drawing.Point(530, 64);
            this.cbbStates.Name = "cbbStates";
            this.cbbStates.Size = new System.Drawing.Size(155, 21);
            this.cbbStates.Sorted = true;
            this.cbbStates.TabIndex = 3;
            this.cbbStates.TextChanged += new System.EventHandler(this.cbbState_TextChanged);
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lblState.Location = new System.Drawing.Point(496, 67);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(28, 16);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "UF";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lblCity.Location = new System.Drawing.Point(466, 110);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 16);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "Cidade";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbbCities
            // 
            this.cbbCities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbCities.FormattingEnabled = true;
            this.cbbCities.Location = new System.Drawing.Point(530, 105);
            this.cbbCities.Name = "cbbCities";
            this.cbbCities.Size = new System.Drawing.Size(155, 21);
            this.cbbCities.Sorted = true;
            this.cbbCities.TabIndex = 4;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(140, 99);
            this.maskedTextBox3.Mask = "(00) 9000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label9.Location = new System.Drawing.Point(64, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Telefone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(140, 56);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox4.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label10.Location = new System.Drawing.Point(85, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nome";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(379, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Usuário";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.Location = new System.Drawing.Point(140, 137);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox5.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label8.Location = new System.Drawing.Point(82, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "E-mail";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox6.Location = new System.Drawing.Point(140, 179);
            this.maskedTextBox6.Mask = "00000-9999";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox6.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label12.Location = new System.Drawing.Point(96, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "CEP";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox7.Location = new System.Drawing.Point(529, 56);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox7.TabIndex = 9;
            this.maskedTextBox7.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox7_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label6.Location = new System.Drawing.Point(435, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Logradouro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox8.Location = new System.Drawing.Point(529, 94);
            this.maskedTextBox8.Mask = "999999990";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox8.TabIndex = 10;
            this.maskedTextBox8.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label7.Location = new System.Drawing.Point(461, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox9.Location = new System.Drawing.Point(529, 135);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox9.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label13.Location = new System.Drawing.Point(465, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cidade";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox10.Location = new System.Drawing.Point(529, 172);
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox10.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label14.Location = new System.Drawing.Point(495, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "UF";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUsuario.BackColor = System.Drawing.Color.White;
            this.pnlUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUsuario.Controls.Add(this.maskedTextBox10);
            this.pnlUsuario.Controls.Add(this.label11);
            this.pnlUsuario.Controls.Add(this.label14);
            this.pnlUsuario.Controls.Add(this.label10);
            this.pnlUsuario.Controls.Add(this.maskedTextBox9);
            this.pnlUsuario.Controls.Add(this.maskedTextBox4);
            this.pnlUsuario.Controls.Add(this.label13);
            this.pnlUsuario.Controls.Add(this.label9);
            this.pnlUsuario.Controls.Add(this.maskedTextBox8);
            this.pnlUsuario.Controls.Add(this.maskedTextBox3);
            this.pnlUsuario.Controls.Add(this.label7);
            this.pnlUsuario.Controls.Add(this.label8);
            this.pnlUsuario.Controls.Add(this.maskedTextBox7);
            this.pnlUsuario.Controls.Add(this.maskedTextBox5);
            this.pnlUsuario.Controls.Add(this.label6);
            this.pnlUsuario.Controls.Add(this.label12);
            this.pnlUsuario.Controls.Add(this.maskedTextBox6);
            this.pnlUsuario.Location = new System.Drawing.Point(-5, 240);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(819, 226);
            this.pnlUsuario.TabIndex = 5;
            this.pnlUsuario.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbCities);
            this.panel1.Controls.Add(this.lblPropertyValue);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.mktPropertyValue);
            this.panel1.Controls.Add(this.cbbStates);
            this.panel1.Controls.Add(this.lblGoodsValue);
            this.panel1.Controls.Add(this.lblHasAlarm);
            this.panel1.Controls.Add(this.mktGoodsValue);
            this.panel1.Controls.Add(this.ckbHasAlarme);
            this.panel1.Location = new System.Drawing.Point(-5, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 192);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblContratoDeSeguroTitle);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.maskedTextBox13);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.maskedTextBox15);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(-5, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 138);
            this.panel2.TabIndex = 13;
            this.panel2.TabStop = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Location = new System.Drawing.Point(663, 104);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(186)))));
            this.label18.Location = new System.Drawing.Point(578, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "Desastres";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Location = new System.Drawing.Point(536, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(186)))));
            this.label15.Location = new System.Drawing.Point(475, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Roubo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblContratoDeSeguroTitle
            // 
            this.lblContratoDeSeguroTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContratoDeSeguroTitle.AutoSize = true;
            this.lblContratoDeSeguroTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblContratoDeSeguroTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratoDeSeguroTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblContratoDeSeguroTitle.Location = new System.Drawing.Point(323, 5);
            this.lblContratoDeSeguroTitle.Name = "lblContratoDeSeguroTitle";
            this.lblContratoDeSeguroTitle.Size = new System.Drawing.Size(192, 24);
            this.lblContratoDeSeguroTitle.TabIndex = 1;
            this.lblContratoDeSeguroTitle.Text = "Contrato de Seguro";
            this.lblContratoDeSeguroTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblContratoDeSeguroTitle.Click += new System.EventHandler(this.Label15_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(488, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "UF";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label17.Location = new System.Drawing.Point(38, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Mensalidade";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox13
            // 
            this.maskedTextBox13.Enabled = false;
            this.maskedTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox13.Location = new System.Drawing.Point(140, 56);
            this.maskedTextBox13.Name = "maskedTextBox13";
            this.maskedTextBox13.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox13.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label19.Location = new System.Drawing.Point(64, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Franquia";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBox15
            // 
            this.maskedTextBox15.Enabled = false;
            this.maskedTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox15.Location = new System.Drawing.Point(140, 99);
            this.maskedTextBox15.Name = "maskedTextBox15";
            this.maskedTextBox15.Size = new System.Drawing.Size(156, 21);
            this.maskedTextBox15.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label23.Location = new System.Drawing.Point(475, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 16);
            this.label23.TabIndex = 14;
            this.label23.Text = "Coberturas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(488, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 16);
            this.label24.TabIndex = 22;
            this.label24.Text = "UF";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(-5, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 65);
            this.panel3.TabIndex = 15;
            this.panel3.TabStop = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(26, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(461, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(595, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // epvPropertyValue
            // 
            this.epvPropertyValue.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvPropertyValue.ContainerControl = this;
            // 
            // epvGoodsValue
            // 
            this.epvGoodsValue.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvGoodsValue.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(808, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iSegres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epvPropertyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvGoodsValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPropertyValue;
        private System.Windows.Forms.Label lblHasAlarm;
        private System.Windows.Forms.CheckBox ckbHasAlarme;
        private System.Windows.Forms.MaskedTextBox mktGoodsValue;
        private System.Windows.Forms.Label lblGoodsValue;
        private System.Windows.Forms.MaskedTextBox mktPropertyValue;
        private System.Windows.Forms.ComboBox cbbStates;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbbCities;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContratoDeSeguroTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox maskedTextBox13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox maskedTextBox15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider epvPropertyValue;
        private System.Windows.Forms.ErrorProvider epvGoodsValue;
    }
}

