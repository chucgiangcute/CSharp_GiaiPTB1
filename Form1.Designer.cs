namespace CSharp_GiaiPTB1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SoA = new TextBox();
            soB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            KetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(122, 29);
            label1.Name = "label1";
            label1.Size = new Size(546, 31);
            label1.TabIndex = 0;
            label1.Text = "GIÚP BẠN GIẢI PHƯƠNG TRÌNH BẬC 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(162, 71);
            label2.Name = "label2";
            label2.Size = new Size(444, 30);
            label2.TabIndex = 1;
            label2.Text = "NHẬP PHƯƠNG TRÌNH BẠN MUỐN GIẢI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 255);
            label3.Location = new Point(88, 160);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 2;
            label3.Text = "Nhập số a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 255);
            label4.Location = new Point(88, 230);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 2;
            label4.Text = "Nhập số b";
            label4.Click += label4_Click;
            // 
            // SoA
            // 
            SoA.BackColor = Color.FromArgb(255, 192, 255);
            SoA.Location = new Point(269, 158);
            SoA.Name = "SoA";
            SoA.Size = new Size(154, 39);
            SoA.TabIndex = 3;
            // 
            // soB
            // 
            soB.BackColor = Color.FromArgb(255, 192, 255);
            soB.Location = new Point(269, 223);
            soB.Name = "soB";
            soB.Size = new Size(154, 39);
            soB.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(525, 156);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 64);
            button2.ForeColor = Color.White;
            button2.Location = new Point(525, 230);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(150, 46);
            button2.TabIndex = 4;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 192, 192);
            label6.ForeColor = Color.White;
            label6.Location = new Point(88, 315);
            label6.Name = "label6";
            label6.Size = new Size(121, 32);
            label6.TabIndex = 5;
            label6.Text = "KẾT QUẢ :";
            // 
            // KetQua
            // 
            KetQua.BackColor = Color.Teal;
            KetQua.ForeColor = Color.White;
            KetQua.Location = new Point(269, 315);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(461, 39);
            KetQua.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KetQua);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(soB);
            Controls.Add(SoA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SoA;
        private TextBox soB;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox KetQua;
    }
}
