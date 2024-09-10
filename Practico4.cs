using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trabajo4
{
    public partial class FPractico4 : Form
    {
        public FPractico4()
        {
            InitializeComponent();
            ConfiguracionGrafico();
        }

        private void ConfiguracionGrafico()
        {
            CHgrafico.Series.Clear();
            Series serieNumero = new Series("Numeros");
            serieNumero.ChartType = SeriesChartType.Column;
            CHgrafico.Series.Add(serieNumero);
        }

        private void ActualizarGrafico()
        {
            CHgrafico.Series["Numeros"].Points.Clear();

            foreach (var item in LBlistnum.Items)
            {
                int numero;
                if (int.TryParse(item.ToString(), out numero))
                {
                    CHgrafico.Series["Numeros"].Points.AddY(numero);
                }
            }
        }

        private void Bgenerar_Click(object sender, EventArgs e)
        {
            //Limpiar el listbox antes de agregar otro valor
            LBlistnum.Items.Clear();

            //validación de campos
            if (string.IsNullOrEmpty(Tdesde.Text) || string.IsNullOrEmpty(Thasta.Text))
            {
                MessageBox.Show("Complete ambos campos");
                return;
            }

            //variables
            int desde, hasta;

            //validación de los valores ingresados
            if (!int.TryParse(Tdesde.Text, out desde) || !int.TryParse(Thasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo numeros");
                return;
            }

            if (desde > hasta)
            {
                MessageBox.Show("El valor desde debe ser menor o igual a hasta");
                return;
            }

            for (int i = desde; i <= hasta; i++)
            {
                LBlistnum.Items.Add(i.ToString());
            }

            ActualizarGrafico();
        }

        private void Bpar_Click(object sender, EventArgs e)
        {
            LBlistnum.Items.Clear();

            int desde, hasta;

            //Validación
            if (!int.TryParse(Tdesde.Text, out desde) || !int.TryParse(Thasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo números");
                return;
            }

            //Validación de rango
            if (desde > hasta)
            {
                MessageBox.Show("El valor desde debe ser menor o igual a hasta");
                return;
            }

            //Agregar numeros pares
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0)
                {
                    LBlistnum.Items.Add(i.ToString());
                }
            }

            ActualizarGrafico();
        }

        private void Bimpar_Click(object sender, EventArgs e)
        {
            LBlistnum.Items.Clear();

            int desde, hasta;

            //Validación 
            if (!int.TryParse(Tdesde.Text, out desde) || !int.TryParse(Thasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo numeros");
                return;
            }

            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0)
                {
                    LBlistnum.Items.Add(i.ToString());
                }
            }

            ActualizarGrafico();
        }

        private void Bprimo_Click(object sender, EventArgs e)
        {
            LBlistnum.Items.Clear();

            int desde, hasta;

            if (!int.TryParse(Tdesde.Text, out desde) || !int.TryParse(Thasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo números");
                return;
            }

            for (int i = desde; i <= hasta; i++)
            {
                if (esprimo(i))
                {
                    LBlistnum.Items.Add(i.ToString());
                }

            }

            ActualizarGrafico();

        }

        private bool esprimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void Llistnum_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void PFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
