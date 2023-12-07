namespace PersonelProject
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.msdPhone = new System.Windows.Forms.MaskedTextBox();
            this.chckIA = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelID,
            this.Birim,
            this.Adı,
            this.Soyadı,
            this.Telefon,
            this.Adres,
            this.Email,
            this.Tarih,
            this.BirimID,
            this.IsActive});
            this.dataGridView1.Location = new System.Drawing.Point(23, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PersonelID
            // 
            this.PersonelID.DataPropertyName = "PersonelD";
            this.PersonelID.HeaderText = "Personel ID";
            this.PersonelID.MinimumWidth = 6;
            this.PersonelID.Name = "PersonelID";
            // 
            // Birim
            // 
            this.Birim.DataPropertyName = "UnitName";
            this.Birim.HeaderText = "Birim Adı";
            this.Birim.MinimumWidth = 6;
            this.Birim.Name = "Birim";
            // 
            // Adı
            // 
            this.Adı.DataPropertyName = "Name";
            this.Adı.HeaderText = "Adı";
            this.Adı.MinimumWidth = 6;
            this.Adı.Name = "Adı";
            // 
            // Soyadı
            // 
            this.Soyadı.DataPropertyName = "LastName";
            this.Soyadı.HeaderText = "Soyadı";
            this.Soyadı.MinimumWidth = 6;
            this.Soyadı.Name = "Soyadı";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Phone";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Address";
            this.Adres.HeaderText = "Adres";
            this.Adres.MinimumWidth = 6;
            this.Adres.Name = "Adres";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Date";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            // 
            // BirimID
            // 
            this.BirimID.DataPropertyName = "UnitID";
            this.BirimID.HeaderText = "Birim ID";
            this.BirimID.MinimumWidth = 6;
            this.BirimID.Name = "BirimID";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ara :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(116, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(116, 388);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(203, 22);
            this.txtPersonelID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel ID : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 416);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birim :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(116, 444);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Soyadı : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(495, 469);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(519, 75);
            this.txtAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Durumu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tarih";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(495, 413);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Email :";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DisplayMember = "UnitName";
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(116, 470);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(203, 24);
            this.cmbUnit.TabIndex = 21;
            this.cmbUnit.ValueMember = "UnitID";
            // 
            // msdPhone
            // 
            this.msdPhone.Location = new System.Drawing.Point(495, 385);
            this.msdPhone.Mask = "(999) 000-0000";
            this.msdPhone.Name = "msdPhone";
            this.msdPhone.Size = new System.Drawing.Size(203, 22);
            this.msdPhone.TabIndex = 22;
            // 
            // chckIA
            // 
            this.chckIA.AutoSize = true;
            this.chckIA.Location = new System.Drawing.Point(116, 359);
            this.chckIA.Name = "chckIA";
            this.chckIA.Size = new System.Drawing.Size(54, 20);
            this.chckIA.TabIndex = 23;
            this.chckIA.Text = "Aktif";
            this.chckIA.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1149, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 37);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1079, 385);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 37);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "Yeni ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1079, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 37);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(495, 441);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(203, 22);
            this.dtpDate.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 677);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chckIA);
            this.Controls.Add(this.msdPhone);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Personel Yönetim";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.MaskedTextBox msdPhone;
        private System.Windows.Forms.CheckBox chckIA;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

