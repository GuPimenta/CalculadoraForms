namespace Calc
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
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b2 = new Button();
            b1 = new Button();
            b3 = new Button();
            b0 = new Button();
            mult = new Button();
            clear = new Button();
            sub = new Button();
            div = new Button();
            resultado = new Button();
            soma = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // b7
            // 
            b7.Location = new Point(12, 41);
            b7.Name = "b7";
            b7.Size = new Size(50, 50);
            b7.TabIndex = 0;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Location = new Point(68, 41);
            b8.Name = "b8";
            b8.Size = new Size(50, 50);
            b8.TabIndex = 1;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(124, 41);
            b9.Name = "b9";
            b9.Size = new Size(50, 50);
            b9.TabIndex = 2;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b4
            // 
            b4.Location = new Point(12, 97);
            b4.Name = "b4";
            b4.Size = new Size(50, 50);
            b4.TabIndex = 3;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Location = new Point(68, 97);
            b5.Name = "b5";
            b5.Size = new Size(50, 50);
            b5.TabIndex = 4;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Location = new Point(124, 97);
            b6.Name = "b6";
            b6.Size = new Size(50, 50);
            b6.TabIndex = 5;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b2
            // 
            b2.Location = new Point(68, 153);
            b2.Name = "b2";
            b2.Size = new Size(50, 50);
            b2.TabIndex = 6;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b1
            // 
            b1.Location = new Point(12, 153);
            b1.Name = "b1";
            b1.Size = new Size(50, 50);
            b1.TabIndex = 7;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b3
            // 
            b3.Location = new Point(124, 153);
            b3.Name = "b3";
            b3.Size = new Size(50, 50);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b0
            // 
            b0.Location = new Point(12, 209);
            b0.Name = "b0";
            b0.Size = new Size(50, 50);
            b0.TabIndex = 9;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // mult
            // 
            mult.Location = new Point(180, 209);
            mult.Name = "mult";
            mult.Size = new Size(50, 50);
            mult.TabIndex = 11;
            mult.Text = "X";
            mult.UseVisualStyleBackColor = true;
            mult.Click += mult_Click;
            // 
            // clear
            // 
            clear.Location = new Point(180, 11);
            clear.Name = "clear";
            clear.Size = new Size(50, 24);
            clear.TabIndex = 12;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // sub
            // 
            sub.Location = new Point(180, 97);
            sub.Name = "sub";
            sub.Size = new Size(50, 50);
            sub.TabIndex = 13;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // div
            // 
            div.Location = new Point(180, 153);
            div.Name = "div";
            div.Size = new Size(50, 50);
            div.TabIndex = 14;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // resultado
            // 
            resultado.Location = new Point(68, 209);
            resultado.Name = "resultado";
            resultado.Size = new Size(106, 50);
            resultado.TabIndex = 15;
            resultado.Text = "=";
            resultado.UseVisualStyleBackColor = true;
            resultado.Click += resultado_Click;
            // 
            // soma
            // 
            soma.Location = new Point(180, 41);
            soma.Name = "soma";
            soma.Size = new Size(50, 50);
            soma.TabIndex = 16;
            soma.Text = "+";
            soma.UseVisualStyleBackColor = true;
            soma.Click += soma_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 11);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 17;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 266);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(soma);
            Controls.Add(resultado);
            Controls.Add(div);
            Controls.Add(sub);
            Controls.Add(clear);
            Controls.Add(mult);
            Controls.Add(b0);
            Controls.Add(b3);
            Controls.Add(b1);
            Controls.Add(b2);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b7;
        private Button b8;
        private Button b9;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b2;
        private Button b1;
        private Button b3;
        private Button b0;
        private Button mult;
        private Button clear;
        private Button sub;
        private Button div;
        private Button resultado;
        private Button soma;
        private TextBox textBox1;
        private Label label1;
    }
}
