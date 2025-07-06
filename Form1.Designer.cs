namespace calculadora_de_media
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de média";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 61);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Nota 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 90);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Nota 2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 119);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Nota 3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(92, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 148);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "Nota 4";
            // 
            // button1
            // 
            button1.Location = new Point(260, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(260, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 84);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 11;
            label6.Text = "A média é:";
            label6.Click += label6_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 116);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 13;
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 230);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private Label label7;
    }
}
