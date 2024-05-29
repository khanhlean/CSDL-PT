namespace TN_CSDLPT
{
    partial class frmTaoTaiKhoan
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
            System.Windows.Forms.Label hOTENLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox_CN = new System.Windows.Forms.ComboBox();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSGV_CHUATK = new TN_CSDLPT.DS_DSGV_CHUATK();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_LoginName = new System.Windows.Forms.TextBox();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            this.button_DK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_Giangvien = new System.Windows.Forms.RadioButton();
            this.radioButton_Coso = new System.Windows.Forms.RadioButton();
            this.radioButton_Truong = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dS = new TN_CSDLPT.DS();
            this.v_DS_GIAOVIENCHUACOTKTableAdapter = new TN_CSDLPT.DS_DSGV_CHUATKTableAdapters.V_DS_GIAOVIENCHUACOTKTableAdapter();
            this.tableAdapterManager1 = new TN_CSDLPT.DS_DSGV_CHUATKTableAdapters.TableAdapterManager();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSGV_CHUATK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            hOTENLabel.Location = new System.Drawing.Point(86, 147);
            hOTENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(90, 19);
            hOTENLabel.TabIndex = 18;
            hOTENLabel.Text = "GIÁO VIÊN";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox_CN);
            this.groupControl1.Controls.Add(this.TextBox_Username);
            this.groupControl1.Controls.Add(this.textBox_Password);
            this.groupControl1.Controls.Add(this.textBox_LoginName);
            this.groupControl1.Controls.Add(this.hOTENComboBox);
            this.groupControl1.Controls.Add(this.button_DK);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.radioButton_Giangvien);
            this.groupControl1.Controls.Add(this.radioButton_Coso);
            this.groupControl1.Controls.Add(this.radioButton_Truong);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(hOTENLabel);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(553, 534);
            this.groupControl1.TabIndex = 1;
            // 
            // comboBox_CN
            // 
            this.comboBox_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CN.FormattingEnabled = true;
            this.comboBox_CN.Location = new System.Drawing.Point(214, 94);
            this.comboBox_CN.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CN.Name = "comboBox_CN";
            this.comboBox_CN.Size = new System.Drawing.Size(223, 27);
            this.comboBox_CN.TabIndex = 37;
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.TextBox_Username.Enabled = false;
            this.TextBox_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.Location = new System.Drawing.Point(214, 204);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(223, 26);
            this.TextBox_Username.TabIndex = 36;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "V_DS_GIAOVIENCHUACOTK";
            this.bdsGV.DataSource = this.dS_DSGV_CHUATK;
            this.bdsGV.CurrentChanged += new System.EventHandler(this.bdsGV_CurrentChanged);
            // 
            // dS_DSGV_CHUATK
            // 
            this.dS_DSGV_CHUATK.DataSetName = "DS_DSGV_CHUATK";
            this.dS_DSGV_CHUATK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(214, 317);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(223, 26);
            this.textBox_Password.TabIndex = 35;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_LoginName
            // 
            this.textBox_LoginName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoginName.Location = new System.Drawing.Point(214, 255);
            this.textBox_LoginName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_LoginName.Name = "textBox_LoginName";
            this.textBox_LoginName.Size = new System.Drawing.Size(223, 26);
            this.textBox_LoginName.TabIndex = 34;
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataSource = this.bdsGV;
            this.hOTENComboBox.DisplayMember = "MAGV";
            this.hOTENComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hOTENComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(214, 147);
            this.hOTENComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(223, 27);
            this.hOTENComboBox.TabIndex = 33;
            this.hOTENComboBox.ValueMember = "MAGV";
            this.hOTENComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.hOTENComboBox_Format);
            // 
            // button_DK
            // 
            this.button_DK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.button_DK.Location = new System.Drawing.Point(226, 476);
            this.button_DK.Margin = new System.Windows.Forms.Padding(4);
            this.button_DK.Name = "button_DK";
            this.button_DK.Size = new System.Drawing.Size(144, 52);
            this.button_DK.TabIndex = 32;
            this.button_DK.Text = "Đăng ký";
            this.button_DK.UseVisualStyleBackColor = true;
            this.button_DK.Click += new System.EventHandler(this.button_DK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(86, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "CƠ SỞ";
            // 
            // radioButton_Giangvien
            // 
            this.radioButton_Giangvien.AutoSize = true;
            this.radioButton_Giangvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Giangvien.Location = new System.Drawing.Point(385, 405);
            this.radioButton_Giangvien.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Giangvien.Name = "radioButton_Giangvien";
            this.radioButton_Giangvien.Size = new System.Drawing.Size(91, 21);
            this.radioButton_Giangvien.TabIndex = 27;
            this.radioButton_Giangvien.TabStop = true;
            this.radioButton_Giangvien.Text = "Giảng viên";
            this.radioButton_Giangvien.UseVisualStyleBackColor = true;
            // 
            // radioButton_Coso
            // 
            this.radioButton_Coso.AutoSize = true;
            this.radioButton_Coso.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Coso.Location = new System.Drawing.Point(253, 405);
            this.radioButton_Coso.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Coso.Name = "radioButton_Coso";
            this.radioButton_Coso.Size = new System.Drawing.Size(62, 21);
            this.radioButton_Coso.TabIndex = 26;
            this.radioButton_Coso.TabStop = true;
            this.radioButton_Coso.Text = "Cơ sở";
            this.radioButton_Coso.UseVisualStyleBackColor = true;
            // 
            // radioButton_Truong
            // 
            this.radioButton_Truong.AutoSize = true;
            this.radioButton_Truong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Truong.Location = new System.Drawing.Point(90, 405);
            this.radioButton_Truong.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Truong.Name = "radioButton_Truong";
            this.radioButton_Truong.Size = new System.Drawing.Size(70, 21);
            this.radioButton_Truong.TabIndex = 25;
            this.radioButton_Truong.TabStop = true;
            this.radioButton_Truong.Text = "Trường";
            this.radioButton_Truong.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(87, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(86, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "LOGIN NAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(86, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "USERNAME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(181, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 35);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tạo tài khoản";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_GIAOVIENCHUACOTKTableAdapter
            // 
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = TN_CSDLPT.DS_DSGV_CHUATKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.V_DS_GIAOVIENCHUACOTKTableAdapter = this.v_DS_GIAOVIENCHUACOTKTableAdapter;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 534);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSGV_CHUATK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS dS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_Giangvien;
        private System.Windows.Forms.RadioButton radioButton_Coso;
        private System.Windows.Forms.RadioButton radioButton_Truong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource bdsGV;
        private DS_DSGV_CHUATK dS_DSGV_CHUATK;
        private DS_DSGV_CHUATKTableAdapters.V_DS_GIAOVIENCHUACOTKTableAdapter v_DS_GIAOVIENCHUACOTKTableAdapter;
        private System.Windows.Forms.Button button_DK;
        private System.Windows.Forms.ComboBox comboBox_CN;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_LoginName;
        private System.Windows.Forms.ComboBox hOTENComboBox;
        private DS_DSGV_CHUATKTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}