namespace Authentication
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            textBox2 = new TextBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            textBox3 = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 55, 77);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1271, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 41);
            label2.Name = "label2";
            label2.Size = new Size(1016, 39);
            label2.TabIndex = 0;
            label2.Text = "COLLEGE FOR UNIVERSAL TECHNOLOGY EDUCATION";
            label2.Click += label2_Click_1;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(448, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(823, 598);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 191);
            label1.Name = "label1";
            label1.Size = new Size(319, 34);
            label1.TabIndex = 0;
            label1.Text = "Create your Account";
            label1.Click += label1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(157, 178, 191);
            panel6.Controls.Add(textBox2);
            panel6.Location = new Point(19, 322);
            panel6.Name = "panel6";
            panel6.Size = new Size(408, 43);
            panel6.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(157, 178, 191);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.ForeColor = Color.Gainsboro;
            textBox2.Location = new Point(13, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 29);
            textBox2.TabIndex = 2;
            textBox2.Text = "Password";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(157, 178, 191);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(19, 256);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 43);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(157, 178, 191);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.ForeColor = Color.Gainsboro;
            textBox1.Location = new Point(13, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 29);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter your email";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 55, 77);
            button1.Font = new Font("Georgia", 11F);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(147, 466);
            button1.Name = "button1";
            button1.Size = new Size(151, 42);
            button1.TabIndex = 4;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 109, 130);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 598);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(157, 178, 191);
            panel7.Controls.Add(textBox3);
            panel7.Location = new Point(19, 387);
            panel7.Name = "panel7";
            panel7.Size = new Size(408, 43);
            panel7.TabIndex = 4;
            panel7.Paint += panel7_Paint;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(157, 178, 191);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.ForeColor = Color.Gainsboro;
            textBox3.Location = new Point(13, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(392, 29);
            textBox3.TabIndex = 2;
            textBox3.Text = "Re-enter Password";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(162, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(120, 120);
            panel5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(281, 536);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 7;
            label5.Text = "Log In";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 542);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(105, 536);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 5;
            label3.Text = "Have an account already?";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1271, 723);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel6;
        private TextBox textBox2;
        private Panel panel4;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Panel panel7;
        private TextBox textBox3;
    }
}
