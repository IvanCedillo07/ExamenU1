namespace ExamenU1
{
    public partial class Form1 : Form
    {
        double sueldo, cuotafija, LimiterInf, porcentaje, ISR, excedente, sueldonet;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {     
            try
            {
                sueldo = Convert.ToDouble(txtSueldo.Text);

                if (sueldo <= 0)
                {
                    MessageBox.Show("Por favor Ingrese un sueldo valido");
                }
                else
                {
                    MessageBox.Show("ISR calculado con exito");
                    if (sueldo >= 0.01 && sueldo <= 746.04)
                    {
                        LimiterInf = 0.01;
                        cuotafija = 0.00;
                        porcentaje = 1.92 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;

                    }
                    else if (sueldo >= 746.04 && sueldo <= 6332.05)
                    {
                        LimiterInf = 746.04;
                        cuotafija = 14.32;
                        porcentaje = 6.40 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 6332.06 && sueldo <= 11128.01)
                    {
                        LimiterInf = 6332.06;
                        cuotafija = 371.83;
                        porcentaje = 10.88 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 11128.02 && sueldo <= 12935.82)
                    {
                        LimiterInf = 11128.02;
                        cuotafija = 893.63;
                        porcentaje = 16.00 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 12935.83 && sueldo <= 15487.71)
                    {
                        LimiterInf = 12935.83;
                        cuotafija = 1318.26;
                        porcentaje = 17.92 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 15487.72 && sueldo <= 31236.49)
                    {
                        LimiterInf = 15487.72;
                        cuotafija = 1972.12;
                        porcentaje = 21.36 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 31236.50 && sueldo <= 49233.00)
                    {
                        LimiterInf = 31236.50;
                        cuotafija = 5850.76;
                        porcentaje = 23.52 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 49233.01 && sueldo <= 93993.90)
                    {
                        LimiterInf = 49233.01;
                        cuotafija = 10837.02;
                        porcentaje = 30.00 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 93993.91 && sueldo <= 125325.20)
                    {
                        LimiterInf = 93993.91;
                        cuotafija = 26177.04;
                        porcentaje = 32.00 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 125325.21 && sueldo <= 375975.61)
                    {
                        LimiterInf = 125325.21;
                        cuotafija = 38243.68;
                        porcentaje = 34.00 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    else if (sueldo >= 375975.62)
                    {
                        LimiterInf = 125325.21;
                        cuotafija = 142119.38;
                        porcentaje = 35.00 / 100;
                        excedente = sueldo - LimiterInf;
                        ISR = cuotafija + (sueldo - LimiterInf) * porcentaje;
                        sueldonet = sueldo - ISR;
                    }
                    lbISR.Text = ISR.ToString() + "$";
                    lbExecedente.Text = excedente.ToString() + "$";
                    lbSueldoNet.Text = sueldonet.ToString() + "$";
                    lbRegistrado.Text=sueldo.ToString() + "$";
                    txtSueldo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un valor valido", "Error" + MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbExecedente.Text=" ";
            lbISR.Text = " ";
            lbSueldoNet.Text = " ";
            txtSueldo.Text = "";
            txtSueldo.Focus();
        }
    }
}
