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
            label1 = new Label();
            Resul1 = new Label();
            cmbOperacion = new ComboBox();
            txtResultado = new TextBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            Num2 = new Label();
            btnCalcular = new Button();
            Num1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Resul1);
            panel1.Controls.Add(cmbOperacion);
            panel1.Controls.Add(txtResultado);
            panel1.Controls.Add(txtNum2);
            panel1.Controls.Add(txtNum1);
            panel1.Controls.Add(Num2);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(Num1);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 393);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 36);
            label1.Name = "label1";
            label1.Size = new Size(344, 60);
            label1.TabIndex = 1;
            label1.Text = "CALCULADORA";
            // 
            // Resul1
            // 
            Resul1.AutoSize = true;
            Resul1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resul1.ForeColor = SystemColors.Highlight;
            Resul1.Location = new Point(410, 300);
            Resul1.Name = "Resul1";
            Resul1.Size = new Size(126, 31);
            Resul1.TabIndex = 7;
            Resul1.Text = "Resultado:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.BackColor = Color.DimGray;
            cmbOperacion.ForeColor = Color.Transparent;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "Suma", "Resta", "Multiplicación", "División" });
            cmbOperacion.Location = new Point(562, 162);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(151, 28);
            cmbOperacion.TabIndex = 6;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.InactiveCaption;
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(562, 304);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 5;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(274, 211);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(192, 27);
            txtNum2.TabIndex = 4;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(274, 138);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(192, 27);
            txtNum1.TabIndex = 3;
            // 
            // Num2
            // 
            Num2.AutoSize = true;
            Num2.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Num2.ForeColor = Color.Transparent;
            Num2.Location = new Point(50, 211);
            Num2.Name = "Num2";
            Num2.Size = new Size(205, 23);
            Num2.TabIndex = 2;
            Num2.Text = "Segundo número:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DimGray;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Transparent;
            btnCalcular.Location = new Point(122, 287);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(225, 55);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Num1
            // 
            Num1.AutoSize = true;
            Num1.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Num1.ForeColor = Color.Transparent;
            Num1.Location = new Point(50, 131);
            Num1.Name = "Num1";
            Num1.Size = new Size(171, 33);
            Num1.TabIndex = 0;
            Num1.Text = "Primer Numero: ";
            Num1.TextAlign = ContentAlignment.BottomRight;
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
        private Button btnCalcular;
        private Label Num1;
        private Label Resul1;
        private ComboBox cmbOperacion;
        private TextBox txtResultado;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label label1;
    }
}
