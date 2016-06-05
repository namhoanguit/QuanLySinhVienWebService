namespace QuanLySinhVien
{
    partial class frmThongKeSVTheoKhoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMakhoa = new System.Windows.Forms.ComboBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.dataGridViewTKSV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongSV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // cbMakhoa
            // 
            this.cbMakhoa.FormattingEnabled = true;
            this.cbMakhoa.Location = new System.Drawing.Point(68, 33);
            this.cbMakhoa.Name = "cbMakhoa";
            this.cbMakhoa.Size = new System.Drawing.Size(121, 21);
            this.cbMakhoa.TabIndex = 2;
            this.cbMakhoa.SelectedIndexChanged += new System.EventHandler(this.cbMakhoa_SelectedIndexChanged);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(301, 33);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(217, 20);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // dataGridViewTKSV
            // 
            this.dataGridViewTKSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTKSV.Location = new System.Drawing.Point(15, 90);
            this.dataGridViewTKSV.Name = "dataGridViewTKSV";
            this.dataGridViewTKSV.Size = new System.Drawing.Size(503, 177);
            this.dataGridViewTKSV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng Số SV";
            // 
            // txtTongSV
            // 
            this.txtTongSV.Location = new System.Drawing.Point(142, 294);
            this.txtTongSV.Name = "txtTongSV";
            this.txtTongSV.Size = new System.Drawing.Size(100, 20);
            this.txtTongSV.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(317, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongKeSVTheoKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 337);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTongSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewTKSV);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.cbMakhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKeSVTheoKhoa";
            this.Text = "frmThongKeSVTheoKhoa";
            this.Load += new System.EventHandler(this.frmThongKeSVTheoKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMakhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.DataGridView dataGridViewTKSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongSV;
        private System.Windows.Forms.Button btnThoat;
    }
}