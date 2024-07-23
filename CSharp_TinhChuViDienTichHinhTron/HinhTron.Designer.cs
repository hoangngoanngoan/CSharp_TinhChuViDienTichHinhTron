namespace CSharp_TinhChuViDienTichHinhTron
{
    partial class HinhTron
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtBK = new TextBox();
            butTinh = new Button();
            butCV = new Button();
            butDT = new Button();
            butThoat = new Button();
            labKQ = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(800, 36);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH HÌNH TRÒN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 96);
            label2.Name = "label2";
            label2.Size = new Size(117, 33);
            label2.TabIndex = 1;
            label2.Text = "Bán kính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 167);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtBK
            // 
            txtBK.Location = new Point(218, 89);
            txtBK.Name = "txtBK";
            txtBK.Size = new Size(227, 40);
            txtBK.TabIndex = 4;
            // 
            // butTinh
            // 
            butTinh.Location = new Point(27, 224);
            butTinh.Name = "butTinh";
            butTinh.Size = new Size(119, 53);
            butTinh.TabIndex = 6;
            butTinh.Text = "Tính";
            butTinh.UseVisualStyleBackColor = true;
            butTinh.Click += butTinh_Click;
            // 
            // butCV
            // 
            butCV.Location = new Point(25, 300);
            butCV.Name = "butCV";
            butCV.Size = new Size(220, 54);
            butCV.TabIndex = 7;
            butCV.Text = "Tính Chu Vi";
            butCV.UseVisualStyleBackColor = true;
            // 
            // butDT
            // 
            butDT.Location = new Point(335, 300);
            butDT.Name = "butDT";
            butDT.Size = new Size(207, 54);
            butDT.TabIndex = 8;
            butDT.Text = "Tính Diện Tích";
            butDT.UseVisualStyleBackColor = true;
            // 
            // butThoat
            // 
            butThoat.Location = new Point(655, 300);
            butThoat.Name = "butThoat";
            butThoat.Size = new Size(118, 54);
            butThoat.TabIndex = 9;
            butThoat.Text = "Thoát";
            butThoat.UseVisualStyleBackColor = true;
            // 
            // labKQ
            // 
            labKQ.AutoSize = true;
            labKQ.Location = new Point(218, 167);
            labKQ.Name = "labKQ";
            labKQ.Size = new Size(85, 33);
            labKQ.TabIndex = 10;
            labKQ.Text = "label3";
            // 
            // HinhTron
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 459);
            Controls.Add(labKQ);
            Controls.Add(butThoat);
            Controls.Add(butDT);
            Controls.Add(butCV);
            Controls.Add(butTinh);
            Controls.Add(txtBK);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(8);
            Name = "HinhTron";
            Text = "CSharp_TinhChuViDienTichHinhTron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtBK;
        private Button butTinh;
        private Button butCV;
        private Button butDT;
        private Button butThoat;
        private Label labKQ;
    }
}
