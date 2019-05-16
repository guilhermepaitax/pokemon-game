namespace ProjetoPokemon
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.picBoxFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarForca = new System.Windows.Forms.ProgressBar();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridViewPoke = new System.Windows.Forms.DataGridView();
            this.Pokemon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Força = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblForca = new System.Windows.Forms.Label();
            this.btnTreinar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTreinador = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarDefesa = new System.Windows.Forms.ProgressBar();
            this.progressBarVida = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDefesa = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.btnAbandorar = new System.Windows.Forms.Button();
            this.btnAddPokemon = new System.Windows.Forms.Button();
            this.btnFloresta = new System.Windows.Forms.Button();
            this.picBoxTipo1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picBoxTipo3 = new System.Windows.Forms.PictureBox();
            this.picBoxTipo2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxSelecaoPoke = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTipo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTipo2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFoto
            // 
            this.picBoxFoto.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFoto.ErrorImage = null;
            this.picBoxFoto.InitialImage = null;
            this.picBoxFoto.Location = new System.Drawing.Point(744, 125);
            this.picBoxFoto.MaximumSize = new System.Drawing.Size(320, 290);
            this.picBoxFoto.Name = "picBoxFoto";
            this.picBoxFoto.Size = new System.Drawing.Size(140, 171);
            this.picBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxFoto.TabIndex = 0;
            this.picBoxFoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(671, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Força:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBarForca
            // 
            this.progressBarForca.BackColor = System.Drawing.Color.White;
            this.progressBarForca.Location = new System.Drawing.Point(769, 373);
            this.progressBarForca.Name = "progressBarForca";
            this.progressBarForca.Size = new System.Drawing.Size(131, 10);
            this.progressBarForca.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.lblNome.Location = new System.Drawing.Point(750, 344);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewPoke
            // 
            this.dataGridViewPoke.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPoke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPoke.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPoke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPoke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pokemon,
            this.Força,
            this.Altura,
            this.Peso});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPoke.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPoke.Location = new System.Drawing.Point(0, 161);
            this.dataGridViewPoke.Name = "dataGridViewPoke";
            this.dataGridViewPoke.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPoke.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPoke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPoke.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPoke.Size = new System.Drawing.Size(470, 457);
            this.dataGridViewPoke.TabIndex = 2;
            this.dataGridViewPoke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPoke_CellClick);
            // 
            // Pokemon
            // 
            this.Pokemon.HeaderText = "Pokemon";
            this.Pokemon.Name = "Pokemon";
            this.Pokemon.ReadOnly = true;
            // 
            // Força
            // 
            this.Força.HeaderText = "Força";
            this.Força.Name = "Força";
            this.Força.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(634, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblForca
            // 
            this.lblForca.AutoSize = true;
            this.lblForca.BackColor = System.Drawing.Color.White;
            this.lblForca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.lblForca.Location = new System.Drawing.Point(906, 369);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(0, 19);
            this.lblForca.TabIndex = 5;
            this.lblForca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTreinar
            // 
            this.btnTreinar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTreinar.BackColor = System.Drawing.Color.White;
            this.btnTreinar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTreinar.BackgroundImage")));
            this.btnTreinar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTreinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreinar.FlatAppearance.BorderSize = 0;
            this.btnTreinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreinar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreinar.ForeColor = System.Drawing.Color.White;
            this.btnTreinar.Location = new System.Drawing.Point(744, 565);
            this.btnTreinar.Name = "btnTreinar";
            this.btnTreinar.Size = new System.Drawing.Size(169, 48);
            this.btnTreinar.TabIndex = 6;
            this.btnTreinar.Text = "Treinar";
            this.btnTreinar.UseVisualStyleBackColor = false;
            this.btnTreinar.Visible = false;
            this.btnTreinar.Click += new System.EventHandler(this.btnTreinar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblTreinador);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 47);
            this.panel1.TabIndex = 7;
            // 
            // lblTreinador
            // 
            this.lblTreinador.AutoSize = true;
            this.lblTreinador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreinador.ForeColor = System.Drawing.Color.White;
            this.lblTreinador.Location = new System.Drawing.Point(41, 13);
            this.lblTreinador.Name = "lblTreinador";
            this.lblTreinador.Size = new System.Drawing.Size(0, 19);
            this.lblTreinador.TabIndex = 0;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.White;
            this.lblAltura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.lblAltura.Location = new System.Drawing.Point(669, 466);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(59, 19);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.White;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.lblPeso.Location = new System.Drawing.Point(671, 498);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(48, 19);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(671, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Defesa:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBarDefesa
            // 
            this.progressBarDefesa.BackColor = System.Drawing.Color.White;
            this.progressBarDefesa.Location = new System.Drawing.Point(769, 405);
            this.progressBarDefesa.Name = "progressBarDefesa";
            this.progressBarDefesa.Size = new System.Drawing.Size(131, 10);
            this.progressBarDefesa.TabIndex = 11;
            // 
            // progressBarVida
            // 
            this.progressBarVida.BackColor = System.Drawing.Color.White;
            this.progressBarVida.Location = new System.Drawing.Point(769, 437);
            this.progressBarVida.Name = "progressBarVida";
            this.progressBarVida.Size = new System.Drawing.Size(131, 10);
            this.progressBarVida.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(671, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vida:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDefesa
            // 
            this.lblDefesa.AutoSize = true;
            this.lblDefesa.BackColor = System.Drawing.Color.White;
            this.lblDefesa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.lblDefesa.Location = new System.Drawing.Point(906, 401);
            this.lblDefesa.Name = "lblDefesa";
            this.lblDefesa.Size = new System.Drawing.Size(0, 19);
            this.lblDefesa.TabIndex = 14;
            this.lblDefesa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.White;
            this.lblVida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.lblVida.Location = new System.Drawing.Point(906, 433);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(0, 19);
            this.lblVida.TabIndex = 15;
            this.lblVida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAbandorar
            // 
            this.btnAbandorar.BackColor = System.Drawing.Color.Transparent;
            this.btnAbandorar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbandorar.BackgroundImage")));
            this.btnAbandorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbandorar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbandorar.FlatAppearance.BorderSize = 0;
            this.btnAbandorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbandorar.Location = new System.Drawing.Point(476, 575);
            this.btnAbandorar.Name = "btnAbandorar";
            this.btnAbandorar.Size = new System.Drawing.Size(45, 38);
            this.btnAbandorar.TabIndex = 16;
            this.btnAbandorar.UseVisualStyleBackColor = false;
            this.btnAbandorar.Click += new System.EventHandler(this.btnAbandorar_Click);
            // 
            // btnAddPokemon
            // 
            this.btnAddPokemon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAddPokemon.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPokemon.BackgroundImage")));
            this.btnAddPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPokemon.FlatAppearance.BorderSize = 0;
            this.btnAddPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPokemon.Location = new System.Drawing.Point(214, 3);
            this.btnAddPokemon.Name = "btnAddPokemon";
            this.btnAddPokemon.Size = new System.Drawing.Size(62, 53);
            this.btnAddPokemon.TabIndex = 17;
            this.btnAddPokemon.UseMnemonic = false;
            this.btnAddPokemon.UseVisualStyleBackColor = false;
            this.btnAddPokemon.Click += new System.EventHandler(this.btnAddPokemon_Click);
            // 
            // btnFloresta
            // 
            this.btnFloresta.BackColor = System.Drawing.Color.Transparent;
            this.btnFloresta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFloresta.BackgroundImage")));
            this.btnFloresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFloresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFloresta.FlatAppearance.BorderSize = 0;
            this.btnFloresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloresta.Location = new System.Drawing.Point(282, 3);
            this.btnFloresta.Name = "btnFloresta";
            this.btnFloresta.Size = new System.Drawing.Size(62, 53);
            this.btnFloresta.TabIndex = 18;
            this.btnFloresta.UseVisualStyleBackColor = false;
            this.btnFloresta.Click += new System.EventHandler(this.button3_Click);
            // 
            // picBoxTipo1
            // 
            this.picBoxTipo1.BackColor = System.Drawing.Color.White;
            this.picBoxTipo1.Location = new System.Drawing.Point(769, 521);
            this.picBoxTipo1.Name = "picBoxTipo1";
            this.picBoxTipo1.Size = new System.Drawing.Size(34, 33);
            this.picBoxTipo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTipo1.TabIndex = 19;
            this.picBoxTipo1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(671, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBoxTipo3
            // 
            this.picBoxTipo3.BackColor = System.Drawing.Color.White;
            this.picBoxTipo3.Location = new System.Drawing.Point(866, 521);
            this.picBoxTipo3.Name = "picBoxTipo3";
            this.picBoxTipo3.Size = new System.Drawing.Size(34, 33);
            this.picBoxTipo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTipo3.TabIndex = 21;
            this.picBoxTipo3.TabStop = false;
            // 
            // picBoxTipo2
            // 
            this.picBoxTipo2.BackColor = System.Drawing.Color.White;
            this.picBoxTipo2.Location = new System.Drawing.Point(818, 521);
            this.picBoxTipo2.Name = "picBoxTipo2";
            this.picBoxTipo2.Size = new System.Drawing.Size(34, 33);
            this.picBoxTipo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTipo2.TabIndex = 22;
            this.picBoxTipo2.TabStop = false;
            // 
            // cbxSelecaoPoke
            // 
            this.cbxSelecaoPoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelecaoPoke.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelecaoPoke.FormattingEnabled = true;
            this.cbxSelecaoPoke.Items.AddRange(new object[] {
            "Meus Pokemons",
            "Todos Pokemons"});
            this.cbxSelecaoPoke.Location = new System.Drawing.Point(12, 114);
            this.cbxSelecaoPoke.Name = "cbxSelecaoPoke";
            this.cbxSelecaoPoke.Size = new System.Drawing.Size(210, 24);
            this.cbxSelecaoPoke.TabIndex = 23;
            this.cbxSelecaoPoke.SelectedIndexChanged += new System.EventHandler(this.cbxSelecaoPoke_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(240, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar pelo Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(476, 161);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 53);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(476, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 38);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(350, 3);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(62, 53);
            this.btnPerfil.TabIndex = 28;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 618);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxSelecaoPoke);
            this.Controls.Add(this.picBoxTipo2);
            this.Controls.Add(this.picBoxTipo3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picBoxTipo1);
            this.Controls.Add(this.btnFloresta);
            this.Controls.Add(this.btnAddPokemon);
            this.Controls.Add(this.btnAbandorar);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblDefesa);
            this.Controls.Add(this.progressBarVida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarDefesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTreinar);
            this.Controls.Add(this.lblForca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxFoto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.progressBarForca);
            this.Controls.Add(this.dataGridViewPoke);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTipo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTipo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFoto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ProgressBar progressBarForca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pokemon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Força;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblForca;
        private System.Windows.Forms.Button btnTreinar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTreinador;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarDefesa;
        private System.Windows.Forms.ProgressBar progressBarVida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDefesa;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Button btnAbandorar;
        private System.Windows.Forms.Button btnAddPokemon;
        private System.Windows.Forms.Button btnFloresta;
        private System.Windows.Forms.PictureBox picBoxTipo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBoxTipo3;
        private System.Windows.Forms.PictureBox picBoxTipo2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbxSelecaoPoke;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPerfil;
    }
}