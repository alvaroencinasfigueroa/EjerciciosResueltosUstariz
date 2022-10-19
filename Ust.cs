using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    class Ust
    {
        //Ejercicio 1
        public int Ej1_suma10Numeros()
        {
            int s = 0;
            for (int i = 1; i < 11; i++)
            {
                s = s + i;
            }
            return s;
        }

        //Ejercicio 2
        public int Ej2_factorialA(int n)
        {
            int factorial = 1;
            for (int c = 1; c <= n; c++)
            {
                factorial = factorial * c;
            }
            return factorial;
        }

        //Ejercicio 3
        public int suma20Pares_b()
        {
            int s = 0;
            for (int c = 2; c <= 40; c++)
            {
                if (c % 2 == 0)
                {
                    s = s + c;
                }
            }
            return s;
        }

        //Ejercicio 4 a
        public int suma10MultiplosDe3_a()
        {
            int s = 1, k = 0;
            for (int c = 1; c < 30 || k == 10; c++)
            {
                if (c % 3 == 0)
                {
                    s = s + c;
                    k++;
                }
            }
            return s;
        }

        //Ejercicio 5
        public int[] multiplosDe7B()
        {
            int ac = 105;
            int[] res = new int[15];
            res[1] = ac;
            for (int c = 2; c <= 14; c++)
            {
                ac = ac + 7;
                res[c] = ac;
            }
            return res;
        }

        //Ejercicio 6
        public int calcularCuadrado(int num)
        {
            int s = 1;
            int c = 1;
            for (int k = 1; k < num; k++)
            {
                c = c + 2; // este hace el trabajo según el enunciado o sea 4 -> 1+3+5+7=16
                s = s + c;
            }
            return s;
        }

        //Ejercicio 7
        public double sumaSerie1()
        {
            double n;
            double d = 0;
            double s = 0;
            double t;
            for (int c = 1; c <= 10; c++)
            {
                n = 1;
                d = d + 1;
                t = n / d;
                s = s + t;
            }
            return s;
        }

        //Ejercicio 8
        public double sumaSerie2()
        {
            double n = -1;
            double d = 1;
            double s = 1;
            double t = n / d;
            s = s + t;
            for (int c = 1; c <= 20; c++)
            {
                n = n + 2;
                d = d * 2;
                t = n / d;
                s = s + t;
            }
            return s;
        }

        // Ejercicio 9
        public double calcularPIGregory()
        {
            int n = -1;
            double s = 1;
            int d = 1;
            double t = 0;
            for (int c = 1; c < 100; c++)
            {
                n = n * (-1);
                d = d * 2;
                t = n / d;
                s = s + t;
            }
            return s;
        }

        //Ejercicio 10

        //Ejercicio 11 A
        public long[] mostrarSerie11A()
        {
            long ac = 1;
            long[] res = new long[11];
            res[0] = ac;
            for (int c = 1; c <= 10; c++)
            {
                ac = ac * 3;
                res[c] = ac;
            }
            return res;
        }

        // Ejercicio 11 B
        public long[] mostrarSerie11B()
        {
            long[] nuevo = new long[11];
            long p = 0;
            long u = 1;
            for (int c = 1; c <= 10; c++)
            {
                nuevo[c] = p + u;
                long n = nuevo[c];
                p = u;
                u = n;
            }
            return nuevo;
        }

        //Ejercicio 11 C
        public long[] mostrarSerie11C()
        {
            long[] nuevo = new long[11];
            long an = 0;
            long pe = 6;
            long ul = 0;
            for (int c = 1; c <= 10; c++)
            {
                nuevo[c] = an + pe;
                long n = nuevo[c];
                an = pe;
                pe = ul;
                ul = n;
            }
            return nuevo;
        }

        //Ejercicio 12
        public double promedio10Numeros(double numero)
        {
            double s = 0;
            double p;
            for (int c = 1; c < 10; c++)
            {
                numero = Convert.ToDouble(Interaction.InputBox("INGRESAR UN NÚMERO CUALQUIERA: "));
                s = s + numero;
            }
            p = (s / 10);

            return p;
        }

        //Ejercicio 13
        public int mayorDe10Numeros(int numero)
        {
            int mayor = numero;
            for (int c = 1; c < 10; c++)
            {
                numero = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO CUALQUIERA: "));
                mayor = numero;
                if (numero > mayor)
                {
                    mayor = numero;
                }
            }
            return mayor;
        }

        //Ejercicio 14
        public int contarPositivos(int numero)
        {
            int cantidadPositivos = 0;
            for (int i = 1; i < 10; i++)
            {
                numero = Convert.ToInt32(Interaction.InputBox("INGRESAR 10 NÚMEROS CUALQUIERA: "));
                if (numero > 0)
                {
                    cantidadPositivos = cantidadPositivos + 1;
                }

            }
            return cantidadPositivos;
        }

        public void mostrarVector(long[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = 0;
            }
        }

        public int controlarNumeroSiEstaEntre_0_100(int numero)
        {
            int bb = 0;
            while (bb == 0)
            {
                MessageBox.Show("DIGITAR UN NÚMERO ENTRE 0 Y 1OO... ");
                numero = Convert.ToInt32(Interaction.InputBox("INGRESAR UN NÚMERO... "));
                if (numero >= 0 && numero <= 100)
                {
                    bb = 1;
                }

            }
            return bb;
        }

    }
}
