namespace Dybss
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Dybs\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(338, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(338, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 31);
            textBox4.TabIndex = 5;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 126);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 6;
            label2.Text = "nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 194);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 7;
            label3.Text = "prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 263);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 323);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 9;
            label5.Text = "mot de passe";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 59);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(661, 13);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "signIn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(338, 379);
            button2.Name = "button2";
            button2.Size = new Size(270, 34);
            button2.TabIndex = 11;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(614, 318);
            button3.Name = "button3";
            button3.Size = new Size(46, 34);
            button3.TabIndex = 12;
            button3.Text = "👀";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
