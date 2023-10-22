namespace PersonalTrackingSystem.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            P_PersonalBasisModule = new Panel();
            DGV_PersonalBasisModule = new DataGridView();
            B_Enter_PersonalBasisModule = new Button();
            B_PhotoPath_PersonalBasisModule = new Button();
            L_Title_PersonalBasisModule = new Label();
            L_BirthDate_PersonalBasisModule = new Label();
            DTP_BirthDate_PersonalBasisModule = new DateTimePicker();
            TB_Name_PersonalBasisModule = new TextBox();
            TB_BirthPlace_PersonalBasisModule = new TextBox();
            TB_MaritalStatus_PersonalBasisModule = new TextBox();
            TB_PhotoPath_PersonalBasisModule = new TextBox();
            TB_FathersName_PersonalBasisModule = new TextBox();
            TB_City_PersonalBasisModule = new TextBox();
            TB_MothersName_PersonalBasisModule = new TextBox();
            TB_Surname_PersonalBasisModule = new TextBox();
            TB_TIN_PersonalBasisModule = new TextBox();
            P_PersonalFileModule = new Panel();
            DGV_PersonalFileModule = new DataGridView();
            B_Enter_PersonalFileModule = new Button();
            button2 = new Button();
            L_Title_PersonalFileModule = new Label();
            TB_Address_PersonalFileModule = new TextBox();
            P_PersonalBasisModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PersonalBasisModule).BeginInit();
            P_PersonalFileModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PersonalFileModule).BeginInit();
            SuspendLayout();
            // 
            // P_PersonalBasisModule
            // 
            P_PersonalBasisModule.BackColor = SystemColors.GradientInactiveCaption;
            P_PersonalBasisModule.Controls.Add(DGV_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(B_Enter_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(B_PhotoPath_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(L_Title_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(L_BirthDate_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(DTP_BirthDate_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_Name_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_BirthPlace_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_MaritalStatus_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_PhotoPath_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_FathersName_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_City_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_MothersName_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_Surname_PersonalBasisModule);
            P_PersonalBasisModule.Controls.Add(TB_TIN_PersonalBasisModule);
            P_PersonalBasisModule.Location = new Point(12, 12);
            P_PersonalBasisModule.Name = "P_PersonalBasisModule";
            P_PersonalBasisModule.Size = new Size(660, 578);
            P_PersonalBasisModule.TabIndex = 0;
            // 
            // DGV_PersonalBasisModule
            // 
            DGV_PersonalBasisModule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PersonalBasisModule.Location = new Point(21, 378);
            DGV_PersonalBasisModule.Name = "DGV_PersonalBasisModule";
            DGV_PersonalBasisModule.RowTemplate.Height = 25;
            DGV_PersonalBasisModule.Size = new Size(614, 172);
            DGV_PersonalBasisModule.TabIndex = 4;
            // 
            // B_Enter_PersonalBasisModule
            // 
            B_Enter_PersonalBasisModule.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            B_Enter_PersonalBasisModule.Location = new Point(271, 324);
            B_Enter_PersonalBasisModule.Name = "B_Enter_PersonalBasisModule";
            B_Enter_PersonalBasisModule.Size = new Size(109, 34);
            B_Enter_PersonalBasisModule.TabIndex = 3;
            B_Enter_PersonalBasisModule.Text = "Giriş";
            B_Enter_PersonalBasisModule.UseVisualStyleBackColor = true;
            B_Enter_PersonalBasisModule.Click += B_Enter_PersonalBasisModule_Click;
            // 
            // B_PhotoPath_PersonalBasisModule
            // 
            B_PhotoPath_PersonalBasisModule.Location = new Point(197, 273);
            B_PhotoPath_PersonalBasisModule.Name = "B_PhotoPath_PersonalBasisModule";
            B_PhotoPath_PersonalBasisModule.Size = new Size(110, 23);
            B_PhotoPath_PersonalBasisModule.TabIndex = 3;
            B_PhotoPath_PersonalBasisModule.Text = "Fotoğraf Yükle:";
            B_PhotoPath_PersonalBasisModule.UseVisualStyleBackColor = true;
            B_PhotoPath_PersonalBasisModule.Click += B_PhotoPath_PersonalBasisModule_Click;
            // 
            // L_Title_PersonalBasisModule
            // 
            L_Title_PersonalBasisModule.AutoSize = true;
            L_Title_PersonalBasisModule.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_Title_PersonalBasisModule.Location = new Point(224, 15);
            L_Title_PersonalBasisModule.Name = "L_Title_PersonalBasisModule";
            L_Title_PersonalBasisModule.Size = new Size(201, 25);
            L_Title_PersonalBasisModule.TabIndex = 2;
            L_Title_PersonalBasisModule.Text = "Personel Kayıt Modülü";
            // 
            // L_BirthDate_PersonalBasisModule
            // 
            L_BirthDate_PersonalBasisModule.AutoSize = true;
            L_BirthDate_PersonalBasisModule.Location = new Point(93, 166);
            L_BirthDate_PersonalBasisModule.Name = "L_BirthDate_PersonalBasisModule";
            L_BirthDate_PersonalBasisModule.Size = new Size(81, 15);
            L_BirthDate_PersonalBasisModule.TabIndex = 2;
            L_BirthDate_PersonalBasisModule.Text = "Doğum Tarihi:";
            // 
            // DTP_BirthDate_PersonalBasisModule
            // 
            DTP_BirthDate_PersonalBasisModule.Format = DateTimePickerFormat.Short;
            DTP_BirthDate_PersonalBasisModule.Location = new Point(180, 160);
            DTP_BirthDate_PersonalBasisModule.MaxDate = new DateTime(2002, 12, 31, 0, 0, 0, 0);
            DTP_BirthDate_PersonalBasisModule.MinDate = new DateTime(1935, 1, 1, 0, 0, 0, 0);
            DTP_BirthDate_PersonalBasisModule.Name = "DTP_BirthDate_PersonalBasisModule";
            DTP_BirthDate_PersonalBasisModule.Size = new Size(200, 23);
            DTP_BirthDate_PersonalBasisModule.TabIndex = 1;
            DTP_BirthDate_PersonalBasisModule.Value = new DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // TB_Name_PersonalBasisModule
            // 
            TB_Name_PersonalBasisModule.Location = new Point(176, 102);
            TB_Name_PersonalBasisModule.MaxLength = 30;
            TB_Name_PersonalBasisModule.Name = "TB_Name_PersonalBasisModule";
            TB_Name_PersonalBasisModule.PlaceholderText = "Ad:";
            TB_Name_PersonalBasisModule.Size = new Size(149, 23);
            TB_Name_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_BirthPlace_PersonalBasisModule
            // 
            TB_BirthPlace_PersonalBasisModule.Location = new Point(485, 160);
            TB_BirthPlace_PersonalBasisModule.MaxLength = 30;
            TB_BirthPlace_PersonalBasisModule.Name = "TB_BirthPlace_PersonalBasisModule";
            TB_BirthPlace_PersonalBasisModule.PlaceholderText = "Doğum Yeri:";
            TB_BirthPlace_PersonalBasisModule.Size = new Size(149, 23);
            TB_BirthPlace_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_MaritalStatus_PersonalBasisModule
            // 
            TB_MaritalStatus_PersonalBasisModule.Location = new Point(452, 221);
            TB_MaritalStatus_PersonalBasisModule.MaxLength = 30;
            TB_MaritalStatus_PersonalBasisModule.Name = "TB_MaritalStatus_PersonalBasisModule";
            TB_MaritalStatus_PersonalBasisModule.PlaceholderText = "Medeni Durum:";
            TB_MaritalStatus_PersonalBasisModule.Size = new Size(149, 23);
            TB_MaritalStatus_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_PhotoPath_PersonalBasisModule
            // 
            TB_PhotoPath_PersonalBasisModule.Location = new Point(313, 273);
            TB_PhotoPath_PersonalBasisModule.MaxLength = 300;
            TB_PhotoPath_PersonalBasisModule.Name = "TB_PhotoPath_PersonalBasisModule";
            TB_PhotoPath_PersonalBasisModule.PlaceholderText = "Fotoğraf Konumu:";
            TB_PhotoPath_PersonalBasisModule.ReadOnly = true;
            TB_PhotoPath_PersonalBasisModule.Size = new Size(149, 23);
            TB_PhotoPath_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_FathersName_PersonalBasisModule
            // 
            TB_FathersName_PersonalBasisModule.Location = new Point(254, 221);
            TB_FathersName_PersonalBasisModule.MaxLength = 50;
            TB_FathersName_PersonalBasisModule.Name = "TB_FathersName_PersonalBasisModule";
            TB_FathersName_PersonalBasisModule.PlaceholderText = "Baba Adı:";
            TB_FathersName_PersonalBasisModule.Size = new Size(149, 23);
            TB_FathersName_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_City_PersonalBasisModule
            // 
            TB_City_PersonalBasisModule.Location = new Point(486, 102);
            TB_City_PersonalBasisModule.MaxLength = 30;
            TB_City_PersonalBasisModule.Name = "TB_City_PersonalBasisModule";
            TB_City_PersonalBasisModule.PlaceholderText = "Yaşadığı Şehir:";
            TB_City_PersonalBasisModule.Size = new Size(149, 23);
            TB_City_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_MothersName_PersonalBasisModule
            // 
            TB_MothersName_PersonalBasisModule.Location = new Point(59, 221);
            TB_MothersName_PersonalBasisModule.MaxLength = 50;
            TB_MothersName_PersonalBasisModule.Name = "TB_MothersName_PersonalBasisModule";
            TB_MothersName_PersonalBasisModule.PlaceholderText = "Anne Adı:";
            TB_MothersName_PersonalBasisModule.Size = new Size(149, 23);
            TB_MothersName_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_Surname_PersonalBasisModule
            // 
            TB_Surname_PersonalBasisModule.Location = new Point(331, 102);
            TB_Surname_PersonalBasisModule.MaxLength = 30;
            TB_Surname_PersonalBasisModule.Name = "TB_Surname_PersonalBasisModule";
            TB_Surname_PersonalBasisModule.PlaceholderText = "Soyad:";
            TB_Surname_PersonalBasisModule.Size = new Size(149, 23);
            TB_Surname_PersonalBasisModule.TabIndex = 0;
            // 
            // TB_TIN_PersonalBasisModule
            // 
            TB_TIN_PersonalBasisModule.Location = new Point(21, 102);
            TB_TIN_PersonalBasisModule.MaxLength = 11;
            TB_TIN_PersonalBasisModule.Name = "TB_TIN_PersonalBasisModule";
            TB_TIN_PersonalBasisModule.PlaceholderText = "TC Kimlik No:";
            TB_TIN_PersonalBasisModule.Size = new Size(149, 23);
            TB_TIN_PersonalBasisModule.TabIndex = 0;
            // 
            // P_PersonalFileModule
            // 
            P_PersonalFileModule.BackColor = SystemColors.GradientInactiveCaption;
            P_PersonalFileModule.Controls.Add(DGV_PersonalFileModule);
            P_PersonalFileModule.Controls.Add(B_Enter_PersonalFileModule);
            P_PersonalFileModule.Controls.Add(button2);
            P_PersonalFileModule.Controls.Add(L_Title_PersonalFileModule);
            P_PersonalFileModule.Controls.Add(TB_Address_PersonalFileModule);
            P_PersonalFileModule.Location = new Point(12, 12);
            P_PersonalFileModule.Name = "P_PersonalFileModule";
            P_PersonalFileModule.Size = new Size(660, 578);
            P_PersonalFileModule.TabIndex = 1;
            // 
            // DGV_PersonalFileModule
            // 
            DGV_PersonalFileModule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PersonalFileModule.Location = new Point(21, 378);
            DGV_PersonalFileModule.Name = "DGV_PersonalFileModule";
            DGV_PersonalFileModule.RowTemplate.Height = 25;
            DGV_PersonalFileModule.Size = new Size(614, 172);
            DGV_PersonalFileModule.TabIndex = 5;
            // 
            // B_Enter_PersonalFileModule
            // 
            B_Enter_PersonalFileModule.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            B_Enter_PersonalFileModule.Location = new Point(271, 313);
            B_Enter_PersonalFileModule.Name = "B_Enter_PersonalFileModule";
            B_Enter_PersonalFileModule.Size = new Size(109, 34);
            B_Enter_PersonalFileModule.TabIndex = 3;
            B_Enter_PersonalFileModule.Text = "Giriş";
            B_Enter_PersonalFileModule.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(59, 130);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 3;
            button2.Text = "Fotoğraf Yükle:";
            button2.UseVisualStyleBackColor = true;
            // 
            // L_Title_PersonalFileModule
            // 
            L_Title_PersonalFileModule.AutoSize = true;
            L_Title_PersonalFileModule.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_Title_PersonalFileModule.Location = new Point(224, 15);
            L_Title_PersonalFileModule.Name = "L_Title_PersonalFileModule";
            L_Title_PersonalFileModule.Size = new Size(208, 25);
            L_Title_PersonalFileModule.TabIndex = 2;
            L_Title_PersonalFileModule.Text = "Personel Özlük Modülü";
            // 
            // TB_Address_PersonalFileModule
            // 
            TB_Address_PersonalFileModule.Location = new Point(21, 73);
            TB_Address_PersonalFileModule.MaxLength = 200;
            TB_Address_PersonalFileModule.Name = "TB_Address_PersonalFileModule";
            TB_Address_PersonalFileModule.PlaceholderText = "Tam İkametgah Adresi:";
            TB_Address_PersonalFileModule.Size = new Size(614, 23);
            TB_Address_PersonalFileModule.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(684, 602);
            Controls.Add(P_PersonalBasisModule);
            Controls.Add(P_PersonalFileModule);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            P_PersonalBasisModule.ResumeLayout(false);
            P_PersonalBasisModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PersonalBasisModule).EndInit();
            P_PersonalFileModule.ResumeLayout(false);
            P_PersonalFileModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PersonalFileModule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel P_PersonalBasisModule;
        private TextBox TB_Name_PersonalBasisModule;
        private TextBox TB_Surname_PersonalBasisModule;
        private TextBox TB_TIN_PersonalBasisModule;
        private Label L_BirthDate_PersonalBasisModule;
        private DateTimePicker DTP_BirthDate_PersonalBasisModule;
        private TextBox TB_BirthPlace_PersonalBasisModule;
        private TextBox TB_MaritalStatus_PersonalBasisModule;
        private TextBox TB_FathersName_PersonalBasisModule;
        private TextBox TB_MothersName_PersonalBasisModule;
        private Button B_Enter_PersonalBasisModule;
        private Button B_PhotoPath_PersonalBasisModule;
        private TextBox TB_City_PersonalBasisModule;
        private Label L_Title_PersonalBasisModule;
        private Panel P_PersonalFileModule;
        private Button B_Enter_PersonalFileModule;
        private Button button2;
        private Label L_Title_PersonalFileModule;
        private Label label2;
        private DateTimePicker DTP__PersonalBasisModule;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox TB_Address_PersonalFileModule;
        private TextBox TB_PhotoPath_PersonalBasisModule;
        private DataGridView DGV_PersonalBasisModule;
        private DataGridView DGV_PersonalFileModule;
    }
}