using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFuncionesyproc
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            //este evento
            //se ejecuta cada vez que se abre el
            //formulario

            //establecer el control txtX2 de solo
            //lectura
            this.txtX2.ReadOnly = true;
        }

        //crear un método o procedimiento
        private double calcularX1(double a, double b, double c)
        {
            //declarar variables
            double x1=0, d=0;

            //calcular discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a distinto de cero
            if(a==0)
            {
                MessageBox.Show("Error al dividir para cero...");
                return 0;//abandonar
            }

            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuación tiene soluciones imaginarias...");
                return 0;
            }

            x1 = (-b + Math.Sqrt(d))/(2*a);
            return x1;
        }

        private double calcularX2(double a, double b, double c)
        {
            //declarar variables
            double x2 = 0, d = 0;

            //calcular discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a distinto de cero
            if (a == 0)
            {
                MessageBox.Show("Error al dividir para cero...");
                return 0;//abandonar
            }

            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuación tiene soluciones imaginarias...");
                return 0;
            }

            x2 = (-b -Math.Sqrt(d)) / (2 * a);
            return x2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //llamada a la función calcularX1
            double a, b, c;
            //validar si el usuario a ingresado valores
            if (this.txtA.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingresa el valor de A...");
                this.txtA.Focus();//ubica el cursor en el cuadro de texto
                return;//abandonar
            }
            a = Double.Parse( this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);

            double x1 = calcularX1(a,b,c);
            double x2 = calcularX2(a, b, c);
            //asigno el resultado de x1 en el textbox txtX1
            this.txtX1.Text = x1.ToString();
            this.txtX2.Text = x2.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtA.Text = "";
            this.txtB.Text = String.Empty;
            this.txtC.Text = String.Empty;
            this.txtX1.Text = String.Empty;
            this.txtX2.Text = String.Empty;
            this.txtA.Focus();

        }
    }
}
