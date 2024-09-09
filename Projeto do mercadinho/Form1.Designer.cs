
namespace Projeto_do_mercadinho
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            textBox5 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(526, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(260, 32);
            label1.TabIndex = 0;
            label1.Text = "Projeto do Mercadinho";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(37, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(232, 28);
            label2.TabIndex = 1;
            label2.Text = "Valor da Compra          R$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(37, 106);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(192, 28);
            label3.TabIndex = 2;
            label3.Text = "Número de parcelas ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(37, 166);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(155, 28);
            label4.TabIndex = 3;
            label4.Text = "Data da Compra";
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            textBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(279, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(120, 34);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            textBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(279, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(120, 34);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(279, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(120, 34);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Lime;
            button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(97, 546);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(233, 55);
            button1.TabIndex = 9;
            button1.Text = "Cálculo das Parcelas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            textBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox4.Location = new System.Drawing.Point(12, 258);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox4.Size = new System.Drawing.Size(492, 194);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(110, 227);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(220, 28);
            label5.TabIndex = 11;
            label5.Text = "Valor e Data da Compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(12, 470);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 28);
            label6.TabIndex = 12;
            label6.Text = "Total a pagar:";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Yellow;
            button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button2.Location = new System.Drawing.Point(566, 375);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(233, 55);
            button2.TabIndex = 13;
            button2.Text = "Pagar as parcelas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            textBox5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox5.Location = new System.Drawing.Point(746, 324);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(120, 34);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(566, 324);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(186, 28);
            label7.TabIndex = 14;
            label7.Text = "Data de pagamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(12, 512);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(0, 28);
            label8.TabIndex = 16;
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(1310, 688);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

