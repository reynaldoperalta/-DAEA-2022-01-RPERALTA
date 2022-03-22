using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Operacion Suma
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Operacion Resta
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Operacion Multiplicacion
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        //Operacion Division
        static dynamic Division(double a, double b)
        {
            if (b == 0)
            {
                return "Division indeterminada";
            }
            double div = 0;
            div = (a / b);
            return div;
        }

        // Convertir grados F° a grados C°
        static int F(int c)
        {
            return (5 * (c - 32) / 9);
        }

        // Convertir grados C° a grados F°
        static int C(int f)
        {
            return ((9 * f) / 5) + 32;
        }

        //10 primeros numeros primos
        static void Primos()
        {
            int n = 2;
            int total = 1;

            while (total <= 10)
            {
                Boolean esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                n++;
            }
        }

        //Raiz de los 10 primeros numeros enteros
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es : {1}", i, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[5] Conversion de temperatura de grados C° a grados F°");
                Console.WriteLine("[6] Conversion de temperatura de grados F° a grados C°");
                Console.WriteLine("[7] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[8] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} = {2}", a1, b1, Resta(a1, b1));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} = {2}", a2, b2, Multiplicacion(a2, b2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Division de {0} y {1} = {2}", a3, b3, Division(a3, b3));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese la temperatura en grados Celsios para convertirla a grados Farenheint");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} grados Celsios son {1} grados Farenhiet", c, C(c));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese la temperatura en grados Farenheint para convertirla a grados Celsios");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} grados Farenheint son {1} grados Celsios", f, F(f));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Los 10 primeros numero primos son:  ");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}

