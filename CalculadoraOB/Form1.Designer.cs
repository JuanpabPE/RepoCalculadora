namespace CalculadoraOB
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
            panel1 = new Panel();
            Resul1 = new Label();
            Most1 = new ComboBox();
            textBox3 = new TextBox();
            txtnum2 = new TextBox();
            Txtnum1 = new TextBox();
            Num2 = new Label();
            Btt1 = new Button();
            Num1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Resul1);
            panel1.Controls.Add(Most1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtnum2);
            panel1.Controls.Add(Txtnum1);
            panel1.Controls.Add(Num2);
            panel1.Controls.Add(Btt1);
            panel1.Controls.Add(Num1);
            panel1.Location = new Point(94, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 314);
            panel1.TabIndex = 0;
            // 
            // Resul1
            // 
            Resul1.AutoSize = true;
            Resul1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resul1.ForeColor = SystemColors.Highlight;
            Resul1.Location = new Point(235, 230);
            Resul1.Name = "Resul1";
            Resul1.Size = new Size(126, 31);
            Resul1.TabIndex = 7;
            Resul1.Text = "Resultado:";
            // 
            // Most1
            // 
            Most1.BackColor = Color.FromArgb(255, 255, 192);
            Most1.FormattingEnabled = true;
            Most1.Items.AddRange(new object[] { "Suma", "Resta", "Multiplicación", "División" });
            Most1.Location = new Point(402, 20);
            Most1.Name = "Most1";
            Most1.Size = new Size(151, 28);
            Most1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Enabled = false;
            textBox3.Location = new Point(387, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(213, 141);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(164, 27);
            txtnum2.TabIndex = 4;
            // 
            // Txtnum1
            // 
            Txtnum1.Location = new Point(180, 67);
            Txtnum1.Name = "Txtnum1";
            Txtnum1.Size = new Size(150, 27);
            Txtnum1.TabIndex = 3;
            // 
            // Num2
            // 
            Num2.AutoSize = true;
            Num2.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Num2.ForeColor = SystemColors.ControlDarkDark;
            Num2.Location = new Point(15, 140);
            Num2.Name = "Num2";
            Num2.Size = new Size(192, 23);
            Num2.TabIndex = 2;
            Num2.Text = "Segundo numero";
            // 
            // Btt1
            // 
            Btt1.BackColor = Color.FromArgb(255, 255, 192);
            Btt1.ForeColor = Color.Black;
            Btt1.Location = new Point(449, 98);
            Btt1.Name = "Btt1";
            Btt1.Size = new Size(88, 50);
            Btt1.TabIndex = 1;
            Btt1.Text = "calcular";
            Btt1.UseVisualStyleBackColor = false;
            // 
            // Num1
            // 
            Num1.AutoSize = true;
            Num1.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Num1.ForeColor = Color.Gray;
            Num1.Location = new Point(15, 60);
            Num1.Name = "Num1";
            Num1.Size = new Size(159, 33);
            Num1.TabIndex = 0;
            Num1.Text = "Primer Numero";
            Num1.TextAlign = ContentAlignment.BottomRight;
            Num1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Num2;
        private Button Btt1;
        private Label Num1;
        private Label Resul1;
        private ComboBox Most1;
        private TextBox textBox3;
        private TextBox txtnum2;
        private TextBox Txtnum1;
    }
}
