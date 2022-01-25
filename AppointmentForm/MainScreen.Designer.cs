
namespace AppointmentForm
{
    partial class MainScreen
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
            this.btnAppointmentMenu = new System.Windows.Forms.Button();
            this.pnlMakeAppioment = new System.Windows.Forms.Panel();
            this.cmbClock = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.cmb1111 = new System.Windows.Forms.ComboBox();
            this.dtpHistory = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAppointment = new System.Windows.Forms.Panel();
            this.dgvRandevularım = new System.Windows.Forms.DataGridView();
            this.pnlDoktorlar = new System.Windows.Forms.Panel();
            this.dgvDoktorlar = new System.Windows.Forms.DataGridView();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevuAlMenu = new System.Windows.Forms.Button();
            this.pnlRandevuSil = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSilinicekId = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvRandevuSil = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMakeAppioment.SuspendLayout();
            this.pnlAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevularım)).BeginInit();
            this.pnlDoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).BeginInit();
            this.pnlRandevuSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuSil)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAppointmentMenu
            // 
            this.btnAppointmentMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnAppointmentMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppointmentMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnAppointmentMenu.Location = new System.Drawing.Point(0, 195);
            this.btnAppointmentMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAppointmentMenu.Name = "btnAppointmentMenu";
            this.btnAppointmentMenu.Size = new System.Drawing.Size(219, 30);
            this.btnAppointmentMenu.TabIndex = 1;
            this.btnAppointmentMenu.Text = "Randevularım";
            this.btnAppointmentMenu.UseVisualStyleBackColor = false;
            this.btnAppointmentMenu.Click += new System.EventHandler(this.btnAppointmentMenu_Click);
            // 
            // pnlMakeAppioment
            // 
            this.pnlMakeAppioment.BackColor = System.Drawing.Color.Transparent;
            this.pnlMakeAppioment.BackgroundImage = global::AppointmentForm.Properties.Resources.resim41;
            this.pnlMakeAppioment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMakeAppioment.Controls.Add(this.cmbClock);
            this.pnlMakeAppioment.Controls.Add(this.cmbDoctor);
            this.pnlMakeAppioment.Controls.Add(this.btnRandevuAl);
            this.pnlMakeAppioment.Controls.Add(this.cmb1111);
            this.pnlMakeAppioment.Controls.Add(this.dtpHistory);
            this.pnlMakeAppioment.Controls.Add(this.label4);
            this.pnlMakeAppioment.Controls.Add(this.label3);
            this.pnlMakeAppioment.Controls.Add(this.label2);
            this.pnlMakeAppioment.Controls.Add(this.label1);
            this.pnlMakeAppioment.Location = new System.Drawing.Point(219, 0);
            this.pnlMakeAppioment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMakeAppioment.Name = "pnlMakeAppioment";
            this.pnlMakeAppioment.Size = new System.Drawing.Size(656, 375);
            this.pnlMakeAppioment.TabIndex = 3;
            this.pnlMakeAppioment.Visible = false;
            // 
            // cmbClock
            // 
            this.cmbClock.FormattingEnabled = true;
            this.cmbClock.Location = new System.Drawing.Point(248, 210);
            this.cmbClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClock.Name = "cmbClock";
            this.cmbClock.Size = new System.Drawing.Size(219, 23);
            this.cmbClock.TabIndex = 7;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(248, 172);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(219, 23);
            this.cmbDoctor.TabIndex = 6;
            this.cmbDoctor.Leave += new System.EventHandler(this.cmbDoctor_Leave);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandevuAl.ForeColor = System.Drawing.Color.Black;
            this.btnRandevuAl.Location = new System.Drawing.Point(349, 262);
            this.btnRandevuAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(117, 34);
            this.btnRandevuAl.TabIndex = 8;
            this.btnRandevuAl.Text = "Kaydet";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // cmb1111
            // 
            this.cmb1111.FormattingEnabled = true;
            this.cmb1111.Location = new System.Drawing.Point(248, 133);
            this.cmb1111.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb1111.Name = "cmb1111";
            this.cmb1111.Size = new System.Drawing.Size(219, 23);
            this.cmb1111.TabIndex = 5;
            this.cmb1111.Leave += new System.EventHandler(this.cmb1111_Leave);
            this.cmb1111.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb1111_MouseClick);
            // 
            // dtpHistory
            // 
            this.dtpHistory.Location = new System.Drawing.Point(248, 92);
            this.dtpHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHistory.Name = "dtpHistory";
            this.dtpHistory.Size = new System.Drawing.Size(219, 23);
            this.dtpHistory.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(177, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(162, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // pnlAppointment
            // 
            this.pnlAppointment.BackColor = System.Drawing.Color.Transparent;
            this.pnlAppointment.BackgroundImage = global::AppointmentForm.Properties.Resources.resim5Hd;
            this.pnlAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAppointment.Controls.Add(this.dgvRandevularım);
            this.pnlAppointment.Location = new System.Drawing.Point(219, 0);
            this.pnlAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Size = new System.Drawing.Size(656, 375);
            this.pnlAppointment.TabIndex = 4;
            // 
            // dgvRandevularım
            // 
            this.dgvRandevularım.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevularım.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvRandevularım.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.dgvRandevularım.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevularım.Location = new System.Drawing.Point(29, 21);
            this.dgvRandevularım.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRandevularım.Name = "dgvRandevularım";
            this.dgvRandevularım.RowHeadersVisible = false;
            this.dgvRandevularım.RowHeadersWidth = 51;
            this.dgvRandevularım.RowTemplate.Height = 29;
            this.dgvRandevularım.Size = new System.Drawing.Size(594, 338);
            this.dgvRandevularım.TabIndex = 0;
            // 
            // pnlDoktorlar
            // 
            this.pnlDoktorlar.BackColor = System.Drawing.Color.Transparent;
            this.pnlDoktorlar.BackgroundImage = global::AppointmentForm.Properties.Resources.resim5Hd;
            this.pnlDoktorlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDoktorlar.Controls.Add(this.dgvDoktorlar);
            this.pnlDoktorlar.Location = new System.Drawing.Point(219, 0);
            this.pnlDoktorlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDoktorlar.Name = "pnlDoktorlar";
            this.pnlDoktorlar.Size = new System.Drawing.Size(656, 375);
            this.pnlDoktorlar.TabIndex = 11;
            this.pnlDoktorlar.Visible = false;
            // 
            // dgvDoktorlar
            // 
            this.dgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoktorlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDoktorlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.dgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoktorlar.Location = new System.Drawing.Point(29, 21);
            this.dgvDoktorlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoktorlar.Name = "dgvDoktorlar";
            this.dgvDoktorlar.RowHeadersVisible = false;
            this.dgvDoktorlar.RowHeadersWidth = 51;
            this.dgvDoktorlar.RowTemplate.Height = 29;
            this.dgvDoktorlar.Size = new System.Drawing.Size(594, 338);
            this.dgvDoktorlar.TabIndex = 0;
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorlar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoktorlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDoktorlar.Location = new System.Drawing.Point(0, 285);
            this.btnDoktorlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(219, 30);
            this.btnDoktorlar.TabIndex = 9;
            this.btnDoktorlar.Text = "Doktorlar";
            this.btnDoktorlar.UseVisualStyleBackColor = false;
            this.btnDoktorlar.Click += new System.EventHandler(this.btnDoktorlar_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandevuSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnRandevuSil.Location = new System.Drawing.Point(0, 255);
            this.btnRandevuSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(219, 30);
            this.btnRandevuSil.TabIndex = 10;
            this.btnRandevuSil.Text = "Randevuyu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = false;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevuAlMenu
            // 
            this.btnRandevuAlMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuAlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAlMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandevuAlMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnRandevuAlMenu.Location = new System.Drawing.Point(0, 225);
            this.btnRandevuAlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevuAlMenu.Name = "btnRandevuAlMenu";
            this.btnRandevuAlMenu.Size = new System.Drawing.Size(219, 30);
            this.btnRandevuAlMenu.TabIndex = 9;
            this.btnRandevuAlMenu.Text = "Randevuyu Al";
            this.btnRandevuAlMenu.UseVisualStyleBackColor = false;
            this.btnRandevuAlMenu.Click += new System.EventHandler(this.btnRandevuAlMenu_Click);
            // 
            // pnlRandevuSil
            // 
            this.pnlRandevuSil.BackColor = System.Drawing.Color.Transparent;
            this.pnlRandevuSil.BackgroundImage = global::AppointmentForm.Properties.Resources.resim4;
            this.pnlRandevuSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRandevuSil.Controls.Add(this.label5);
            this.pnlRandevuSil.Controls.Add(this.txtSilinicekId);
            this.pnlRandevuSil.Controls.Add(this.btnSil);
            this.pnlRandevuSil.Controls.Add(this.dgvRandevuSil);
            this.pnlRandevuSil.Location = new System.Drawing.Point(219, 0);
            this.pnlRandevuSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRandevuSil.Name = "pnlRandevuSil";
            this.pnlRandevuSil.Size = new System.Drawing.Size(656, 375);
            this.pnlRandevuSil.TabIndex = 12;
            this.pnlRandevuSil.Visible = false;
            this.pnlRandevuSil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRandevuSil_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(87, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Silmek istediğiniz randevunun Id\'sini giridin :";
            // 
            // txtSilinicekId
            // 
            this.txtSilinicekId.Location = new System.Drawing.Point(452, 34);
            this.txtSilinicekId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSilinicekId.Name = "txtSilinicekId";
            this.txtSilinicekId.Size = new System.Drawing.Size(56, 23);
            this.txtSilinicekId.TabIndex = 2;
            this.txtSilinicekId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSilinicekId_KeyPress);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.Silver;
            this.btnSil.Location = new System.Drawing.Point(541, 32);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 25);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvRandevuSil
            // 
            this.dgvRandevuSil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevuSil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvRandevuSil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.dgvRandevuSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuSil.Location = new System.Drawing.Point(47, 71);
            this.dgvRandevuSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRandevuSil.Name = "dgvRandevuSil";
            this.dgvRandevuSil.ReadOnly = true;
            this.dgvRandevuSil.RowHeadersVisible = false;
            this.dgvRandevuSil.RowHeadersWidth = 51;
            this.dgvRandevuSil.RowTemplate.Height = 29;
            this.dgvRandevuSil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevuSil.Size = new System.Drawing.Size(576, 274);
            this.dgvRandevuSil.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCikis.Location = new System.Drawing.Point(0, 345);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(219, 30);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.BackColor = System.Drawing.Color.Transparent;
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHesap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnHesap.Location = new System.Drawing.Point(0, 315);
            this.btnHesap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(219, 30);
            this.btnHesap.TabIndex = 13;
            this.btnHesap.Text = "Bilgilerimi Güncelle";
            this.btnHesap.UseVisualStyleBackColor = false;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::AppointmentForm.Properties.Resources.resim2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAppointmentMenu);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnDoktorlar);
            this.panel1.Controls.Add(this.btnHesap);
            this.panel1.Controls.Add(this.btnRandevuSil);
            this.panel1.Controls.Add(this.btnRandevuAlMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 375);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppointmentForm.Properties.Resources.mete2;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRandevuSil);
            this.Controls.Add(this.pnlDoktorlar);
            this.Controls.Add(this.pnlMakeAppioment);
            this.Controls.Add(this.pnlAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.pnlMakeAppioment.ResumeLayout(false);
            this.pnlMakeAppioment.PerformLayout();
            this.pnlAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevularım)).EndInit();
            this.pnlDoktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).EndInit();
            this.pnlRandevuSil.ResumeLayout(false);
            this.pnlRandevuSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuSil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAppointmentMenu;
        private System.Windows.Forms.Panel pnlMakeAppioment;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.ComboBox cmbClock;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmb1111;
        private System.Windows.Forms.DateTimePicker dtpHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAppointment;
        private System.Windows.Forms.Button btnDoktorlar;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRandevuAlMenu;
        private System.Windows.Forms.Panel pnlDoktorlar;
        private System.Windows.Forms.DataGridView dgvDoktorlar;
        private System.Windows.Forms.Panel pnlRandevuSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvRandevuSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSilinicekId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRandevularım;
    }
}