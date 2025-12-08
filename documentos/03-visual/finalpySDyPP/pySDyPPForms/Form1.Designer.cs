namespace pySDyPPForms
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(547, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(547, 39);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 69);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 21);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 3;
            label2.Text = "PACIENTES";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(547, 39);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(547, 39);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 243);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(547, 39);
            textBox5.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 128);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 7;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 188);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 8;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 246);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 9;
            label5.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 305);
            label6.Name = "label6";
            label6.Size = new Size(97, 32);
            label6.TabIndex = 10;
            label6.Text = "Género:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 801);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
