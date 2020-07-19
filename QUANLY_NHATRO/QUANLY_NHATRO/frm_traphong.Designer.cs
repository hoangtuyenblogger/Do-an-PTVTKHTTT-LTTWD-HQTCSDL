namespace QUANLY_NHATRO
{
    partial class frm_traphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_traphong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.combo_Phong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_hoten = new System.Windows.Forms.ComboBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.combo_tientralai = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền trả lại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú:";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.combo_Phong);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.combo_hoten);
            this.groupbox.Controls.Add(this.txtGhichu);
            this.groupbox.Controls.Add(this.combo_tientralai);
            this.groupbox.Controls.Add(this.dateTimePicker1);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(12, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(573, 286);
            this.groupbox.TabIndex = 4;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Thông tin trả phòng";
            // 
            // combo_Phong
            // 
            this.combo_Phong.Location = new System.Drawing.Point(386, 37);
            this.combo_Phong.Name = "combo_Phong";
            this.combo_Phong.Size = new System.Drawing.Size(132, 21);
            this.combo_Phong.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phòng:";
            // 
            // combo_hoten
            // 
            this.combo_hoten.FormattingEnabled = true;
            this.combo_hoten.Location = new System.Drawing.Point(82, 41);
            this.combo_hoten.Name = "combo_hoten";
            this.combo_hoten.Size = new System.Drawing.Size(186, 21);
            this.combo_hoten.TabIndex = 8;
            this.combo_hoten.SelectedIndexChanged += new System.EventHandler(this.combo_hoten_SelectedIndexChanged);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(87, 153);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(433, 118);
            this.txtGhichu.TabIndex = 7;
            // 
            // combo_tientralai
            // 
            this.combo_tientralai.Items.AddRange(new object[] {
            "500000",
            "1000000",
            "1500000"});
            this.combo_tientralai.Location = new System.Drawing.Point(386, 98);
            this.combo_tientralai.Name = "combo_tientralai";
            this.combo_tientralai.Size = new System.Drawing.Size(132, 21);
            this.combo_tientralai.TabIndex = 6;
            this.combo_tientralai.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(246, 316);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(108, 39);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // frm_traphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 380);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(623, 419);
            this.MinimumSize = new System.Drawing.Size(623, 419);
            this.Name = "frm_traphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng";
            this.Load += new System.EventHandler(this.frm_traphong_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.ComboBox combo_hoten;
        private System.Windows.Forms.ComboBox combo_tientralai;
        private System.Windows.Forms.ComboBox combo_Phong;
        private System.Windows.Forms.Label label5;
    }
}