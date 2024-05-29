namespace TN_CSDLPT
{
    partial class frmThi
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
            System.Windows.Forms.Label mAMHLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_TENLOP = new System.Windows.Forms.Label();
            this.label_MALOP = new System.Windows.Forms.Label();
            this.label_TENSV = new System.Windows.Forms.Label();
            this.label_MASV = new System.Windows.Forms.Label();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelTenSV_GV = new System.Windows.Forms.Label();
            this.labelMaSV_GV = new System.Windows.Forms.Label();
            this.label_TT = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.spinEditTG_GV = new DevExpress.XtraEditors.SpinEdit();
            this.labelTG_GV = new System.Windows.Forms.Label();
            this.spinEdit_SCT = new DevExpress.XtraEditors.SpinEdit();
            this.comboBox_TD = new System.Windows.Forms.ComboBox();
            this.dateEdit_NT = new DevExpress.XtraEditors.DateEdit();
            this.button_Find = new System.Windows.Forms.Button();
            this.spinEdit_LAN = new DevExpress.XtraEditors.SpinEdit();
            this.label_SCT = new System.Windows.Forms.Label();
            this.label_TD = new System.Windows.Forms.Label();
            this.button_NOPBAI = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_MAMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TN_CSDLPT.DS();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_THI = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mONHOCTableAdapter = new TN_CSDLPT.DSTableAdapters.MONHOCTableAdapter();
            this.lopTableAdapter1 = new TN_CSDLPT.DSTableAdapters.LOPTableAdapter();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new TN_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTG_GV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_SCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_LAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(150, 2);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            mAMHLabel.Size = new System.Drawing.Size(122, 19);
            mAMHLabel.TabIndex = 11;
            mAMHLabel.Text = "Môn học: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label_Timer);
            this.groupControl1.Controls.Add(this.label_TENLOP);
            this.groupControl1.Controls.Add(this.label_MALOP);
            this.groupControl1.Controls.Add(this.label_TENSV);
            this.groupControl1.Controls.Add(this.label_MASV);
            this.groupControl1.Controls.Add(this.labelTenLop);
            this.groupControl1.Controls.Add(this.labelMaLop);
            this.groupControl1.Controls.Add(this.labelTenSV_GV);
            this.groupControl1.Controls.Add(this.labelMaSV_GV);
            this.groupControl1.Controls.Add(this.label_TT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1128, 70);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(750, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 27);
            this.label11.TabIndex = 21;
            this.label11.Text = "Thời gian:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_Timer.Location = new System.Drawing.Point(880, 15);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(98, 40);
            this.label_Timer.TabIndex = 20;
            this.label_Timer.Text = "00:00";
            this.label_Timer.Click += new System.EventHandler(this.label_Timer_Click);
            // 
            // label_TENLOP
            // 
            this.label_TENLOP.AutoSize = true;
            this.label_TENLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENLOP.Location = new System.Drawing.Point(539, 39);
            this.label_TENLOP.Name = "label_TENLOP";
            this.label_TENLOP.Size = new System.Drawing.Size(45, 19);
            this.label_TENLOP.TabIndex = 19;
            this.label_TENLOP.Text = "label9";
            // 
            // label_MALOP
            // 
            this.label_MALOP.AutoSize = true;
            this.label_MALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MALOP.Location = new System.Drawing.Point(539, 2);
            this.label_MALOP.Name = "label_MALOP";
            this.label_MALOP.Size = new System.Drawing.Size(45, 19);
            this.label_MALOP.TabIndex = 18;
            this.label_MALOP.Text = "label8";
            // 
            // label_TENSV
            // 
            this.label_TENSV.AutoSize = true;
            this.label_TENSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENSV.Location = new System.Drawing.Point(274, 39);
            this.label_TENSV.Name = "label_TENSV";
            this.label_TENSV.Size = new System.Drawing.Size(45, 19);
            this.label_TENSV.TabIndex = 17;
            this.label_TENSV.Text = "label7";
            // 
            // label_MASV
            // 
            this.label_MASV.AutoSize = true;
            this.label_MASV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MASV.Location = new System.Drawing.Point(274, 2);
            this.label_MASV.Name = "label_MASV";
            this.label_MASV.Size = new System.Drawing.Size(45, 19);
            this.label_MASV.TabIndex = 16;
            this.label_MASV.Text = "label6";
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenLop.Location = new System.Drawing.Point(466, 39);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(62, 19);
            this.labelTenLop.TabIndex = 15;
            this.labelTenLop.Text = "Tên lớp: ";
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.Location = new System.Drawing.Point(466, 2);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(60, 19);
            this.labelMaLop.TabIndex = 14;
            this.labelMaLop.Text = "Mã lớp: ";
            // 
            // labelTenSV_GV
            // 
            this.labelTenSV_GV.AutoSize = true;
            this.labelTenSV_GV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSV_GV.Location = new System.Drawing.Point(176, 39);
            this.labelTenSV_GV.Name = "labelTenSV_GV";
            this.labelTenSV_GV.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.labelTenSV_GV.Size = new System.Drawing.Size(88, 19);
            this.labelTenSV_GV.TabIndex = 13;
            this.labelTenSV_GV.Text = "Tên SV: ";
            // 
            // labelMaSV_GV
            // 
            this.labelMaSV_GV.AutoSize = true;
            this.labelMaSV_GV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMaSV_GV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV_GV.Location = new System.Drawing.Point(167, 2);
            this.labelMaSV_GV.Name = "labelMaSV_GV";
            this.labelMaSV_GV.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.labelMaSV_GV.Size = new System.Drawing.Size(86, 19);
            this.labelMaSV_GV.TabIndex = 12;
            this.labelMaSV_GV.Text = "Mã SV: ";
            // 
            // label_TT
            // 
            this.label_TT.AutoSize = true;
            this.label_TT.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_TT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TT.Location = new System.Drawing.Point(2, 2);
            this.label_TT.Name = "label_TT";
            this.label_TT.Size = new System.Drawing.Size(165, 22);
            this.label_TT.TabIndex = 11;
            this.label_TT.Text = "Thông tin sinh viên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.spinEditTG_GV);
            this.groupControl2.Controls.Add(this.labelTG_GV);
            this.groupControl2.Controls.Add(this.spinEdit_SCT);
            this.groupControl2.Controls.Add(this.comboBox_TD);
            this.groupControl2.Controls.Add(this.dateEdit_NT);
            this.groupControl2.Controls.Add(this.button_Find);
            this.groupControl2.Controls.Add(this.spinEdit_LAN);
            this.groupControl2.Controls.Add(this.label_SCT);
            this.groupControl2.Controls.Add(this.label_TD);
            this.groupControl2.Controls.Add(this.button_NOPBAI);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(mAMHLabel);
            this.groupControl2.Controls.Add(this.ComboBox_MAMH);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 70);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1128, 63);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // spinEditTG_GV
            // 
            this.spinEditTG_GV.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditTG_GV.Location = new System.Drawing.Point(278, 34);
            this.spinEditTG_GV.Name = "spinEditTG_GV";
            this.spinEditTG_GV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditTG_GV.Properties.Appearance.Options.UseFont = true;
            this.spinEditTG_GV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditTG_GV.Properties.IsFloatValue = false;
            this.spinEditTG_GV.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditTG_GV.Properties.MaxValue = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.spinEditTG_GV.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditTG_GV.Size = new System.Drawing.Size(56, 24);
            this.spinEditTG_GV.TabIndex = 33;
            // 
            // labelTG_GV
            // 
            this.labelTG_GV.AutoSize = true;
            this.labelTG_GV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTG_GV.Location = new System.Drawing.Point(197, 35);
            this.labelTG_GV.Name = "labelTG_GV";
            this.labelTG_GV.Size = new System.Drawing.Size(67, 19);
            this.labelTG_GV.TabIndex = 32;
            this.labelTG_GV.Text = "Thời gian:";
            // 
            // spinEdit_SCT
            // 
            this.spinEdit_SCT.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_SCT.Location = new System.Drawing.Point(795, 36);
            this.spinEdit_SCT.Name = "spinEdit_SCT";
            this.spinEdit_SCT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_SCT.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_SCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_SCT.Properties.IsFloatValue = false;
            this.spinEdit_SCT.Properties.MaskSettings.Set("mask", "N00");
            this.spinEdit_SCT.Properties.MaxValue = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.spinEdit_SCT.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_SCT.Size = new System.Drawing.Size(56, 24);
            this.spinEdit_SCT.TabIndex = 31;
            // 
            // comboBox_TD
            // 
            this.comboBox_TD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TD.FormattingEnabled = true;
            this.comboBox_TD.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox_TD.Location = new System.Drawing.Point(795, 3);
            this.comboBox_TD.Name = "comboBox_TD";
            this.comboBox_TD.Size = new System.Drawing.Size(43, 25);
            this.comboBox_TD.TabIndex = 30;
            this.comboBox_TD.SelectedIndexChanged += new System.EventHandler(this.comboBox_TD_SelectedIndexChanged);
            // 
            // dateEdit_NT
            // 
            this.dateEdit_NT.EditValue = new System.DateTime(2001, 8, 13, 21, 6, 0, 0);
            this.dateEdit_NT.Location = new System.Drawing.Point(564, 2);
            this.dateEdit_NT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEdit_NT.Name = "dateEdit_NT";
            this.dateEdit_NT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_NT.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NT.Size = new System.Drawing.Size(121, 26);
            this.dateEdit_NT.TabIndex = 27;
            // 
            // button_Find
            // 
            this.button_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Find.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find.Location = new System.Drawing.Point(891, 2);
            this.button_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(87, 59);
            this.button_Find.TabIndex = 23;
            this.button_Find.Text = "Tìm";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Visible = false;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // spinEdit_LAN
            // 
            this.spinEdit_LAN.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_LAN.Location = new System.Drawing.Point(564, 32);
            this.spinEdit_LAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinEdit_LAN.Name = "spinEdit_LAN";
            this.spinEdit_LAN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_LAN.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_LAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_LAN.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_LAN.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_LAN.Size = new System.Drawing.Size(55, 26);
            this.spinEdit_LAN.TabIndex = 14;
            // 
            // label_SCT
            // 
            this.label_SCT.AutoSize = true;
            this.label_SCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SCT.Location = new System.Drawing.Point(718, 35);
            this.label_SCT.Name = "label_SCT";
            this.label_SCT.Size = new System.Drawing.Size(72, 19);
            this.label_SCT.TabIndex = 25;
            this.label_SCT.Text = "Số câu thi:";
            // 
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TD.Location = new System.Drawing.Point(723, 2);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(66, 19);
            this.label_TD.TabIndex = 24;
            this.label_TD.Text = "Trình độ: ";
            // 
            // button_NOPBAI
            // 
            this.button_NOPBAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NOPBAI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NOPBAI.Location = new System.Drawing.Point(998, 2);
            this.button_NOPBAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_NOPBAI.Name = "button_NOPBAI";
            this.button_NOPBAI.Size = new System.Drawing.Size(120, 59);
            this.button_NOPBAI.TabIndex = 22;
            this.button_NOPBAI.Text = "Bắt đầu thi";
            this.button_NOPBAI.UseVisualStyleBackColor = true;
            this.button_NOPBAI.Click += new System.EventHandler(this.button_NOPBAI_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lần: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày thi: ";
            // 
            // ComboBox_MAMH
            // 
            this.ComboBox_MAMH.DataSource = this.bdsMH;
            this.ComboBox_MAMH.DisplayMember = "TENMH";
            this.ComboBox_MAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MAMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MAMH.FormattingEnabled = true;
            this.ComboBox_MAMH.Location = new System.Drawing.Point(278, 2);
            this.ComboBox_MAMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_MAMH.Name = "ComboBox_MAMH";
            this.ComboBox_MAMH.Size = new System.Drawing.Size(197, 27);
            this.ComboBox_MAMH.TabIndex = 13;
            this.ComboBox_MAMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thông tin thi";
            // 
            // flowLayoutPanel_THI
            // 
            this.flowLayoutPanel_THI.AutoScroll = true;
            this.flowLayoutPanel_THI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_THI.ForeColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_THI.Location = new System.Drawing.Point(0, 133);
            this.flowLayoutPanel_THI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_THI.Name = "flowLayoutPanel_THI";
            this.flowLayoutPanel_THI.Size = new System.Drawing.Size(1128, 287);
            this.flowLayoutPanel_THI.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter1
            // 
            this.lopTableAdapter1.ClearBeforeFill = true;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.CHITIETTHITableAdapter = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = this.lopTableAdapter1;
            this.tableAdapterManager1.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TN_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 420);
            this.Controls.Add(this.flowLayoutPanel_THI);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTG_GV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_SCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_LAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label_TENLOP;
        private System.Windows.Forms.Label label_MALOP;
        private System.Windows.Forms.Label label_TENSV;
        private System.Windows.Forms.Label label_MASV;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label labelTenSV_GV;
        private System.Windows.Forms.Label labelMaSV_GV;
        private System.Windows.Forms.Label label_TT;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_THI;
        private System.Windows.Forms.Label label_SCT;
        private System.Windows.Forms.Label label_TD;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Button button_NOPBAI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox_MAMH;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateEdit_NT;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SpinEdit spinEdit_LAN;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.LOPTableAdapter lopTableAdapter1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox comboBox_TD;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private DevExpress.XtraEditors.SpinEdit spinEdit_SCT;
        private System.Windows.Forms.Label labelTG_GV;
        private DevExpress.XtraEditors.SpinEdit spinEditTG_GV;
    }
}