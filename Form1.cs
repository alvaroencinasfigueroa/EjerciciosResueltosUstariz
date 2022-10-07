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

        private void button1_Click(object sender, EventArgs e)
        {
            Ust u1 = new Ust();
            int r = u1.Ej1_suma10Numeros();
            string s = r.ToString();
            MessageBox.Show("EL RESULTADO DEL EJERCICIO 1 ES: "+s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ust u2 = new Ust();
            int f  = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO PARA CONOCER SU FACTORIAL:"));
            int r = u2.Ej2_factorialA(f);
            string s = r.ToString();
            MessageBox.Show("EL FACTORIAL ES: "+s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ust u3 = new Ust();
            int resultadoPrimeros20Pares = u3.suma20Pares_b();
            string pares20 = resultadoPrimeros20Pares.ToString();
            MessageBox.Show("LA SUMA DE LOS PRIMEROS 20 NÚMEROS PARES ES: "+pares20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ust u4 = new Ust();
            int resultado30MultiplosDe3 = u4.suma10MultiplosDe3_a();
            string multiplos30 = resultado30MultiplosDe3.ToString();
            MessageBox.Show("LA SUMA DE LOS PRIMEROS 10 MULTIPLOS DE 3 ES: "+multiplos30);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ust u5 = new Ust();
            int [] multiplos7 = u5.multiplosDe7B();    
            for (int i = 1; i < multiplos7.Length; i++)
            {
                MessageBox.Show(""+multiplos7[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ust u6 = new Ust();
            int ent = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO PARA CALCULAR SU CUADRADO: "));
            int cuadrado = u6.calcularCuadrado(ent);
            MessageBox.Show("EL CUADRADO DEL NÚMERO QUE USTED HA INGRESADO ES: "+cuadrado);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ust u7 = new Ust();
            double pi = 3.1416;
            MessageBox.Show("EL PI ES: "+pi);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ust u8 = new Ust();
            double sumaSerie = u8.sumaSerie1();
            MessageBox.Show("LA SUMA DE LA SERIE ES: "+sumaSerie);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ust u9 = new Ust();
            double sumaSerie2 = u9.sumaSerie2();
            MessageBox.Show("LA SUMA DE LA SERIE ES: "+sumaSerie2);
        }

        private void button10_Click(object sender, EventArgs e)
        { 
            Ust u10 = new Ust();
            long[] serie = u10.mostrarSerieA_b();
            for(int i = 0; i < serie.Length; i++)
            {
                MessageBox.Show(" "+serie[i]);
            }
        }

    }
}
