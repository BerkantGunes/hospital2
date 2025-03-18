namespace hospitalmanagement
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMedicine = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDiagnosis = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPatients = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDoctors = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorExperience = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDoctorId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnReload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoctorsDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.btnMedicine);
            this.panel1.Controls.Add(this.btnDiagnosis);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 769);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.AnimationHoverSpeed = 0.07F;
            this.logoutbtn.AnimationSpeed = 0.03F;
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.logoutbtn.BaseColor = System.Drawing.Color.Purple;
            this.logoutbtn.BorderColor = System.Drawing.Color.Black;
            this.logoutbtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.logoutbtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.logoutbtn.CheckedForeColor = System.Drawing.Color.White;
            this.logoutbtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("logoutbtn.CheckedImage")));
            this.logoutbtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.logoutbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutbtn.FocusedColor = System.Drawing.Color.Empty;
            this.logoutbtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.logoutbtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.logoutbtn.Location = new System.Drawing.Point(12, 711);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.logoutbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.logoutbtn.OnHoverImage = null;
            this.logoutbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.logoutbtn.OnPressedColor = System.Drawing.Color.Black;
            this.logoutbtn.Size = new System.Drawing.Size(211, 46);
            this.logoutbtn.TabIndex = 4;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.AnimationHoverSpeed = 0.07F;
            this.btnMedicine.AnimationSpeed = 0.03F;
            this.btnMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMedicine.BaseColor = System.Drawing.Color.Purple;
            this.btnMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnMedicine.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMedicine.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMedicine.CheckedForeColor = System.Drawing.Color.White;
            this.btnMedicine.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMedicine.CheckedImage")));
            this.btnMedicine.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicine.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMedicine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicine.Location = new System.Drawing.Point(12, 312);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicine.OnHoverImage = null;
            this.btnMedicine.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicine.Size = new System.Drawing.Size(211, 41);
            this.btnMedicine.TabIndex = 3;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.AnimationHoverSpeed = 0.07F;
            this.btnDiagnosis.AnimationSpeed = 0.03F;
            this.btnDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDiagnosis.BaseColor = System.Drawing.Color.Purple;
            this.btnDiagnosis.BorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDiagnosis.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.CheckedImage")));
            this.btnDiagnosis.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDiagnosis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDiagnosis.FocusedColor = System.Drawing.Color.Empty;
            this.btnDiagnosis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.Image")));
            this.btnDiagnosis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDiagnosis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.Location = new System.Drawing.Point(12, 252);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnDiagnosis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.OnHoverImage = null;
            this.btnDiagnosis.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.OnPressedColor = System.Drawing.Color.Black;
            this.btnDiagnosis.Size = new System.Drawing.Size(211, 41);
            this.btnDiagnosis.TabIndex = 2;
            this.btnDiagnosis.Text = "Diagnosis";
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.AnimationHoverSpeed = 0.07F;
            this.btnPatients.AnimationSpeed = 0.03F;
            this.btnPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPatients.BaseColor = System.Drawing.Color.Purple;
            this.btnPatients.BorderColor = System.Drawing.Color.Black;
            this.btnPatients.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPatients.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPatients.CheckedForeColor = System.Drawing.Color.White;
            this.btnPatients.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPatients.CheckedImage")));
            this.btnPatients.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPatients.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatients.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatients.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPatients.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatients.Location = new System.Drawing.Point(12, 192);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnPatients.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPatients.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPatients.OnHoverImage = null;
            this.btnPatients.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatients.OnPressedColor = System.Drawing.Color.Black;
            this.btnPatients.Size = new System.Drawing.Size(211, 42);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.AnimationHoverSpeed = 0.07F;
            this.btnDoctors.AnimationSpeed = 0.03F;
            this.btnDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoctors.BaseColor = System.Drawing.Color.Purple;
            this.btnDoctors.BorderColor = System.Drawing.Color.Black;
            this.btnDoctors.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDoctors.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDoctors.CheckedForeColor = System.Drawing.Color.White;
            this.btnDoctors.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDoctors.CheckedImage")));
            this.btnDoctors.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDoctors.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoctors.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoctors.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
            this.btnDoctors.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDoctors.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDoctors.Location = new System.Drawing.Point(12, 131);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnDoctors.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoctors.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoctors.OnHoverImage = null;
            this.btnDoctors.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDoctors.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoctors.Size = new System.Drawing.Size(211, 41);
            this.btnDoctors.TabIndex = 0;
            this.btnDoctors.Text = "Doctors";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 116);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1000, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital Management System";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtDoctorExperience);
            this.panel3.Controls.Add(this.txtDoctorName);
            this.panel3.Controls.Add(this.txtDoctorId);
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(275, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 245);
            this.panel3.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(752, 39);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 50);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDoctorExperience
            // 
            this.txtDoctorExperience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorExperience.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoctorExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorExperience.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorExperience.HintText = "Years of Experience";
            this.txtDoctorExperience.isPassword = false;
            this.txtDoctorExperience.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorExperience.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorExperience.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorExperience.LineThickness = 3;
            this.txtDoctorExperience.Location = new System.Drawing.Point(507, 39);
            this.txtDoctorExperience.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoctorExperience.Name = "txtDoctorExperience";
            this.txtDoctorExperience.Size = new System.Drawing.Size(221, 50);
            this.txtDoctorExperience.TabIndex = 13;
            this.txtDoctorExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoctorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorName.HintText = "Doctor Name";
            this.txtDoctorName.isPassword = false;
            this.txtDoctorName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorName.LineThickness = 3;
            this.txtDoctorName.Location = new System.Drawing.Point(262, 39);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(218, 50);
            this.txtDoctorName.TabIndex = 12;
            this.txtDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoctorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoctorId.HintForeColor = System.Drawing.Color.Empty;
            this.txtDoctorId.HintText = "Doctor Id";
            this.txtDoctorId.isPassword = false;
            this.txtDoctorId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDoctorId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDoctorId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDoctorId.LineThickness = 3;
            this.txtDoctorId.Location = new System.Drawing.Point(21, 39);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(209, 50);
            this.txtDoctorId.TabIndex = 5;
            this.txtDoctorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnReload
            // 
            this.btnReload.AnimationHoverSpeed = 0.07F;
            this.btnReload.AnimationSpeed = 0.03F;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BaseColor = System.Drawing.Color.Purple;
            this.btnReload.BorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReload.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedForeColor = System.Drawing.Color.White;
            this.btnReload.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReload.CheckedImage")));
            this.btnReload.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.FocusedColor = System.Drawing.Color.Empty;
            this.btnReload.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReload.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReload.Location = new System.Drawing.Point(717, 142);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Radius = 20;
            this.btnReload.Size = new System.Drawing.Size(159, 42);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Purple;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(507, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(159, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Purple;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.CheckedImage")));
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.Location = new System.Drawing.Point(303, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 20;
            this.btnUpdate.Size = new System.Drawing.Size(159, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Purple;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(102, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(159, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doctor\'s Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Doctor\'s List";
            // 
            // DoctorsDGV
            // 
            this.DoctorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoctorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDGV.Location = new System.Drawing.Point(277, 426);
            this.DoctorsDGV.Name = "DoctorsDGV";
            this.DoctorsDGV.RowHeadersWidth = 51;
            this.DoctorsDGV.RowTemplate.Height = 24;
            this.DoctorsDGV.Size = new System.Drawing.Size(979, 322);
            this.DoctorsDGV.TabIndex = 16;
            this.DoctorsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDGV_CellContentClick);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoctorsDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton logoutbtn;
        private Guna.UI.WinForms.GunaAdvenceButton btnMedicine;
        private Guna.UI.WinForms.GunaAdvenceButton btnDiagnosis;
        private Guna.UI.WinForms.GunaAdvenceButton btnPatients;
        private Guna.UI.WinForms.GunaAdvenceButton btnDoctors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnReload;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorExperience;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDoctorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DoctorsDGV;
    }
}