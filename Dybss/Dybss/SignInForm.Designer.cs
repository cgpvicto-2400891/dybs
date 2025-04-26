namespace Dybss
{
    partial class SignInForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 31);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Visible = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(168, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 249);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(39, 205);
            button1.Name = "button1";
            button1.Size = new Size(359, 34);
            button1.TabIndex = 4;
            button1.Text = "SignIn";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 140);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 3;
            label2.Text = "mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 86);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 2;
            label1.Text = "email";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 50);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(565, 8);
            button2.Name = "button2";
            button2.Size = new Size(189, 34);
            button2.TabIndex = 1;
            button2.Text = "nouveau utilisateur?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 0;
            label3.Text = "Dybs";
            // 
            // button3
            // 
            button3.Location = new Point(404, 137);
            button3.Name = "button3";
            button3.Size = new Size(42, 34);
            button3.TabIndex = 5;
            button3.Text = "👀";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignInForm";
            Text = "SignInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}