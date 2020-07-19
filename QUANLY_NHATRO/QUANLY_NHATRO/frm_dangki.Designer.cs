namespace QUANLY_NHATRO
{
    partial class frm_dangki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangki));
            this.combo_Phong = new System.Windows.Forms.ComboBox();
            this.combo_Hoten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Picktime1 = new System.Windows.Forms.DateTimePicker();
            this.Picktime2 = new System.Windows.Forms.DateTimePicker();
            this.comboTiencoc = new System.Windows.Forms.ComboBox();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.group_thongtindangki = new System.Windows.Forms.GroupBox();
            this.group_thongtindangki.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_Phong
            // 
            this.combo_Phong.FormattingEnabled = true;
            this.combo_Phong.Location = new System.Drawing.Point(356, 52);
            this.combo_Phong.Name = "combo_Phong";
            this.combo_Phong.Size = new System.Drawing.Size(137, 21);
            this.combo_Phong.TabIndex = 0;
            this.combo_Phong.SelectedIndexChanged += new System.EventHandler(this.combo_Phong_SelectedIndexChanged);
            // 
            // combo_Hoten
            // 
            this.combo_Hoten.FormattingEnabled = true;
            this.combo_Hoten.Location = new System.Drawing.Point(92, 56);
            this.combo_Hoten.Name = "combo_Hoten";
            this.combo_Hoten.Size = new System.Drawing.Size(137, 21);
            this.combo_Hoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày thuê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày vào:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền cọc:";
            // 
            // Picktime1
            // 
            this.Picktime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Picktime1.Location = new System.Drawing.Point(92, 105);
            this.Picktime1.Name = "Picktime1";
            this.Picktime1.Size = new System.Drawing.Size(137, 20);
            this.Picktime1.TabIndex = 7;
            // 
            // Picktime2
            // 
            this.Picktime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Picktime2.Location = new System.Drawing.Point(356, 105);
            this.Picktime2.Name = "Picktime2";
            this.Picktime2.Size = new System.Drawing.Size(137, 20);
            this.Picktime2.TabIndex = 8;
            // 
            // comboTiencoc
            // 
            this.comboTiencoc.FormattingEnabled = true;
            this.comboTiencoc.Items.AddRange(new object[] {
            "500000",
            "1000000",
            "1500000"});
            this.comboTiencoc.Location = new System.Drawing.Point(92, 155);
            this.comboTiencoc.Name = "comboTiencoc";
            this.comboTiencoc.Size = new System.Drawing.Size(137, 21);
            this.comboTiencoc.TabIndex = 9;
            this.comboTiencoc.Text = "0";
            // 
            // btn_dangki
            // 
            this.btn_dangki.Location = new System.Drawing.Point(229, 331);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(97, 34);
            this.btn_dangki.TabIndex = 10;
            this.btn_dangki.Text = "Đăng kí";
            this.btn_dangki.UseVisualStyleBackColor = true;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(372, 331);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(91, 34);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đăng kí thuê phòng";
            // 
            // group_thongtindangki
            // 
            this.group_thongtindangki.Controls.Add(this.label1);
            this.group_thongtindangki.Controls.Add(this.combo_Phong);
            this.group_thongtindangki.Controls.Add(this.combo_Hoten);
            this.group_thongtindangki.Controls.Add(this.label2);
            this.group_thongtindangki.Controls.Add(this.label3);
            this.group_thongtindangki.Controls.Add(this.label4);
            this.group_thongtindangki.Controls.Add(this.label5);
            this.group_thongtindangki.Controls.Add(this.Picktime1);
            this.group_thongtindangki.Controls.Add(this.Picktime2);
            this.group_thongtindangki.Controls.Add(this.comboTiencoc);
            this.group_thongtindangki.Location = new System.Drawing.Point(54, 75);
            this.group_thongtindangki.Name = "group_thongtindangki";
            this.group_thongtindangki.Size = new System.Drawing.Size(596, 233);
            this.group_thongtindangki.TabIndex = 14;
            this.group_thongtindangki.TabStop = false;
            this.group_thongtindangki.Text = "Thông tin đăng kí";
            // 
            // frm_dangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.group_thongtindangki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(740, 446);
            this.MinimumSize = new System.Drawing.Size(740, 446);
            this.Name = "frm_dangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí thuê phòng";
            this.Load += new System.EventHandler(this.frm_dangki_Load);
            this.group_thongtindangki.ResumeLayout(false);
            this.group_thongtindangki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Phong;
        private System.Windows.Forms.ComboBox combo_Hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Picktime1;
        private System.Windows.Forms.DateTimePicker Picktime2;
        private System.Windows.Forms.ComboBox comboTiencoc;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox group_thongtindangki;
    }
}