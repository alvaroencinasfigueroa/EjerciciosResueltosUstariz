using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ust u1 = new Ust();
            int r = u1.Ej1_suma10Numeros();
            string s = r.ToString();
            MessageBox.Show("EL RESULTADO DEL EJERCICIO 1 ES: " + s);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ust u2 = new Ust();
            int f = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO PARA CONOCER SU FACTORIAL:"));
            int r = u2.Ej2_factorialA(f);
            string s = r.ToString();
            MessageBox.Show("EL FACTORIAL ES: " + s);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ust u3 = new Ust();
            int resultadoPrimeros20Pares = u3.suma20Pares_b();
            string pares20 = resultadoPrimeros20Pares.ToString();
            MessageBox.Show("LA SUMA DE LOS PRIMEROS 20 NÚMEROS PARES ES: " + pares20);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ust u4 = new Ust();
            int resultado30MultiplosDe3 = u4.suma10MultiplosDe3_a();
            string multiplos30 = resultado30MultiplosDe3.ToString();
            MessageBox.Show("LA SUMA DE LOS PRIMEROS 10 MULTIPLOS DE 3 ES: " + multiplos30);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ust u5 = new Ust();
            int[] multiplos7 = u5.multiplosDe7B();
            for (int i = 1; i < multiplos7.Length; i++)
            {
                MessageBox.Show("El múltiplo es: " + multiplos7[i]);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ust u6 = new Ust();
            int ent = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO PARA CALCULAR SU CUADRADO: "));
            int cuadrado = u6.calcularCuadrado(ent);
            MessageBox.Show("EL CUADRADO DEL NÚMERO QUE USTED HA INGRESADO ES: " + cuadrado);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Ust u7 = new Ust();
            double sumaSerie = u7.sumaSerie1();
            MessageBox.Show("LA SUMA DE LA SERIE: " + sumaSerie);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Ust u8 = new Ust();
            double sumaSerie = u8.sumaSerie2();
            MessageBox.Show("LA SUMA DE LA SERIE ES: " + sumaSerie);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Ust u9 = new Ust();
            double sumaGregory = u9.calcularPIGregory();
            MessageBox.Show("LA SUMA DE LA SERIE ES: " + sumaGregory);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Ust u11A = new Ust();
            long[] serie = u11A.mostrarSerie11A();
            for (int i = 0; i < serie.Length; i++)
            {
                MessageBox.Show(" " + serie[i]);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Ust u11b = new Ust();
            long [] serieB = u11b.mostrarSerie11B();
            for (int i = 0; i < serieB.Length; i++)
            {
                MessageBox.Show(" " + serieB[i]);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Ust u11c = new Ust();
            long [] serieC = u11c.mostrarSerie11C();
            for (int i = 0; i < serieC.Length; i++) {
                MessageBox.Show(" " + serieC[i]);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
                Ust u12 = new Ust();
                double numero = Convert.ToDouble(Interaction.InputBox("INGRESAR UN NÚMERO CUALQUIERA: "));
                double promedio = u12.promedio10Numeros(numero);
                MessageBox.Show("EL PROMEDIO DE LOS 10 NÚMEROS ES: " + promedio);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Ust u13 = new Ust();
            int numero = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO CUALQUIERA: "));
            int mayor = u13.mayorDe10Numeros(numero);
            MessageBox.Show("EL MAYOR DE LOS 10 NÚMERO ES: " + mayor);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Ust u14 = new Ust();
            int numero = Convert.ToInt32(Interaction.InputBox("INGRESAR NÚMEROS: "));
            int positivos = u14.contarPositivos(numero);
            MessageBox.Show("LA CANTIDAD DE POSITIVOS ES: " + positivos);
        }
    }
}
