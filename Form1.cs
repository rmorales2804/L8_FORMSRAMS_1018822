using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L8_FORMSRAMS_1018822
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Seleccionaste Sumatoria");
                    tabControl1.SelectedTab = tabPage0;
                    break;
                case 1:
                    MessageBox.Show("Seleccionaste Factorial");
                    tabControl1.SelectedTab = tabPage1;
                    break;
                case 2:
                    MessageBox.Show("Seleccionaste Tablas de multiplicar");
                    tabControl1.SelectedTab = tabPage2;
                    break;
                case 3:
                    MessageBox.Show("Seleccionaste Número perfecto");
                    tabControl1.SelectedTab = tabPage3;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(sumatoria.Text);
                int sumaa = 0;
                int a = 1;
                do
                {
                    sumaa += a++;
                }
                while (a <= n);
                {
                    resultadosumatoria.Text = "La suma de 1 a " + (n) + " es: " + (sumaa);
                }
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnumperfecto_Click(object sender, EventArgs e)
        {
            try
            {
                int suma = 0;
                int num = int.Parse(numeroperfecto.Text);

                for(int i=1; i<num; i++)
                {
                    if(num % i == 0 )
                    {
                        suma += i;
                    }
                }
                if(suma == num)
                {
                    resultadonumperfecto.Text = "ES PERFETO";
                }
                else
                {
                    resultadonumperfecto.Text = "NO ES PERFECTO";                
                }
            }
            catch
            {

            }
        }

        private void numeroperfecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage0_Click(object sender, EventArgs e)
        {

        }

        private void btnmultiplicación_Click(object sender, EventArgs e)
        {
            int tabla = int.Parse(numerotabla.Text);

            for (int j=1; j <=10; j++)
            {
                resultadomultiplicacion.Text += (tabla + "x" + j + "=" + (tabla*j)+"\n");
            }
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            int n = int.Parse(factorial_txt.Text);

            int fa = 1;
            for (int l = 1; l <= n; l++)
            {
                fa = fa * l;
            }
            resultadofactorial.Text = (n) + " es: " + (fa);
        }
    }
}
