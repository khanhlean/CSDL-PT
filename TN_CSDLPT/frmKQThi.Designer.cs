using System.Data;

namespace TN_CSDLPT
{
    partial class frmKQThi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbHoTenSV = new System.Windows.Forms.ComboBox();
            this.fKSINHVIENLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.ds1 = new TN_CSDLPT.DS();
            this.cbboxLOP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TenCN = new System.Windows.Forms.ComboBox();
            this.spin_Lanthi = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.btnInBC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new TN_CSDLPT.DSTableAdapters.SINHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Lanthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbHoTenSV);
            this.groupControl1.Controls.Add(this.cbboxLOP);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.comboBox_TenCN);
            this.groupControl1.Controls.Add(this.spin_Lanthi);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.cbbMH);
            this.groupControl1.Controls.Add(this.btnInBC);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1007, 209);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // cbHoTenSV
            // 
            this.cbHoTenSV.DataSource = this.fKSINHVIENLOPBindingSource;
            this.cbHoTenSV.DisplayMember = "HO";
            this.cbHoTenSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoTenSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoTenSV.FormattingEnabled = true;
            this.cbHoTenSV.Location = new System.Drawing.Point(75, 119);
            this.cbHoTenSV.Name = "cbHoTenSV";
            this.cbHoTenSV.Size = new System.Drawing.Size(182, 27);
            this.cbHoTenSV.TabIndex = 63;
            this.cbHoTenSV.ValueMember = "MASV";
            this.cbHoTenSV.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbHoTenSV_Format);
            // 
            // fKSINHVIENLOPBindingSource
            // 
            this.fKSINHVIENLOPBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.fKSINHVIENLOPBindingSource.DataSource = this.bdsLop;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.ds1;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbboxLOP
            // 
            this.cbboxLOP.DataSource = this.bdsLop;
            this.cbboxLOP.DisplayMember = "TENLOP";
            this.cbboxLOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxLOP.FormattingEnabled = true;
            this.cbboxLOP.Location = new System.Drawing.Point(75, 72);
            this.cbboxLOP.Name = "cbboxLOP";
            this.cbboxLOP.Size = new System.Drawing.Size(182, 27);
            this.cbboxLOP.TabIndex = 62;
            this.cbboxLOP.ValueMember = "MALOP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Cơ Sở: ";
            // 
            // comboBox_TenCN
            // 
            this.comboBox_TenCN.DisplayMember = "TENCN";
            this.comboBox_TenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TenCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenCN.FormattingEnabled = true;
            this.comboBox_TenCN.Location = new System.Drawing.Point(69, 23);
            this.comboBox_TenCN.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_TenCN.Name = "comboBox_TenCN";
            this.comboBox_TenCN.Size = new System.Drawing.Size(315, 27);
            this.comboBox_TenCN.TabIndex = 60;
            this.comboBox_TenCN.ValueMember = "TENSERVER";
            this.comboBox_TenCN.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenCN_SelectedIndexChanged);
            // 
            // spin_Lanthi
            // 
            this.spin_Lanthi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_Lanthi.Location = new System.Drawing.Point(825, 83);
            this.spin_Lanthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spin_Lanthi.Name = "spin_Lanthi";
            this.spin_Lanthi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_Lanthi.Properties.Appearance.Options.UseFont = true;
            this.spin_Lanthi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_Lanthi.Properties.IsFloatValue = false;
            this.spin_Lanthi.Properties.MaskSettings.Set("mask", "N00");
            this.spin_Lanthi.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spin_Lanthi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_Lanthi.Size = new System.Drawing.Size(93, 26);
            this.spin_Lanthi.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(750, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Lần thi";
            // 
            // cbbMH
            // 
            this.cbbMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ds1, "MONHOC.TENMH", true));
            this.cbbMH.DataSource = this.bdsMH;
            this.cbbMH.DisplayMember = "TENMH";
            this.cbbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMH.FormattingEnabled = true;
            this.cbbMH.Location = new System.Drawing.Point(417, 78);
            this.cbbMH.Name = "cbbMH";
            this.cbbMH.Size = new System.Drawing.Size(279, 27);
            this.cbbMH.TabIndex = 49;
            this.cbbMH.ValueMember = "MAMH";
            this.cbbMH.SelectedIndexChanged += new System.EventHandler(this.cbbMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.ds1;
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(436, 154);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(129, 40);
            this.btnInBC.TabIndex = 47;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Môn học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Lớp:";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmKQThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 482);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKQThi";
            this.Text = "frmKQThi";
            this.Load += new System.EventHandler(this.frmKQThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Lanthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMH;
        private System.Windows.Forms.Button btnInBC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private DS ds1;
        private DevExpress.XtraEditors.SpinEdit spin_Lanthi;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_TenCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbboxLOP;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cbHoTenSV;
        private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}