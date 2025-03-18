namespace hospitalmanagement
{
    partial class Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
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
            this.btnReload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtbydoctor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicinetype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicineName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MedicineDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDGV)).BeginInit();
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
            this.panel1.TabIndex = 4;
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
            this.btnMedicine.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.btnDoctors.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
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
            this.panel2.TabIndex = 5;
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
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtbydoctor);
            this.panel3.Controls.Add(this.txtMedicinetype);
            this.panel3.Controls.Add(this.txtMedicineName);
            this.panel3.Controls.Add(this.txtMedId);
            this.panel3.Location = new System.Drawing.Point(275, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 245);
            this.panel3.TabIndex = 6;
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
            // 
            // txtbydoctor
            // 
            this.txtbydoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbydoctor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbydoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbydoctor.HintForeColor = System.Drawing.Color.Empty;
            this.txtbydoctor.HintText = "By Doctor";
            this.txtbydoctor.isPassword = false;
            this.txtbydoctor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtbydoctor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbydoctor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbydoctor.LineThickness = 3;
            this.txtbydoctor.Location = new System.Drawing.Point(754, 30);
            this.txtbydoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtbydoctor.Name = "txtbydoctor";
            this.txtbydoctor.Size = new System.Drawing.Size(195, 51);
            this.txtbydoctor.TabIndex = 5;
            this.txtbydoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicinetype
            // 
            this.txtMedicinetype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicinetype.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMedicinetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicinetype.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicinetype.HintText = "Medicine Type";
            this.txtMedicinetype.isPassword = false;
            this.txtMedicinetype.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicinetype.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicinetype.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicinetype.LineThickness = 3;
            this.txtMedicinetype.Location = new System.Drawing.Point(507, 30);
            this.txtMedicinetype.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicinetype.Name = "txtMedicinetype";
            this.txtMedicinetype.Size = new System.Drawing.Size(228, 51);
            this.txtMedicinetype.TabIndex = 4;
            this.txtMedicinetype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineName.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicineName.HintText = "Medicine Name";
            this.txtMedicineName.isPassword = false;
            this.txtMedicineName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicineName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineName.LineThickness = 3;
            this.txtMedicineName.Location = new System.Drawing.Point(248, 30);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(233, 51);
            this.txtMedicineName.TabIndex = 3;
            this.txtMedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedId
            // 
            this.txtMedId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMedId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedId.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedId.HintText = "Medicine Id";
            this.txtMedId.isPassword = false;
            this.txtMedId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedId.LineThickness = 3;
            this.txtMedId.Location = new System.Drawing.Point(13, 30);
            this.txtMedId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedId.Name = "txtMedId";
            this.txtMedId.Size = new System.Drawing.Size(217, 51);
            this.txtMedId.TabIndex = 2;
            this.txtMedId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Medicines Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Medicines List";
            // 
            // MedicineDGV
            // 
            this.MedicineDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineDGV.Location = new System.Drawing.Point(276, 426);
            this.MedicineDGV.Name = "MedicineDGV";
            this.MedicineDGV.RowHeadersWidth = 51;
            this.MedicineDGV.RowTemplate.Height = 24;
            this.MedicineDGV.Size = new System.Drawing.Size(979, 322);
            this.MedicineDGV.TabIndex = 15;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedicineDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDGV)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbydoctor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicinetype;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MedicineDGV;
    }
}