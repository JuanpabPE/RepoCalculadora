namespace CalculadoraOB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Items.Add("Suma");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Obtenemos los valores ingresados en txt
            double numero1, numero2, resultado;
            bool esNum1Valido = double.TryParse(txtNum1.Text, out numero1);
            bool esNum2Valido = double.TryParse(txtNum2.Text, out numero2);
            
            if(!esNum1Valido || !esNum2Valido)
            {
                MessageBox.Show("Ingrese números validos, por favor.");
                return;
            }

            if(cmbOperacion.SelectedItem?.ToString() == "Suma")
            {
                resultado = numero1 + numero2;

                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Seleccionar la operacion de sumar.");
            }
        }
    }
}
