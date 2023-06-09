﻿namespace Calculadora3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
           // Console.ForegroundColor = ConsoleColor.Gray;
            //Este comentario es para ver si GitHub guarda mi cambio
            //Este es para ver que se guarde completo
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine("   Bienvenido a la calculadora cientidica");
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine();

            //Movere a pedir el primer valor antes del ciclo
            double num1;
            double num2;
            string terminar = "y";
            Console.WriteLine("Ingrese el primer numero: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Clear();
                Console.WriteLine("la entrada no es valida");
                Console.WriteLine("Ingrese el primer numero nuevamente: ");
            }
            Console.WriteLine();
            //creando un ciclo
            while (terminar == "y")
            {
                Console.WriteLine("Ingrese el siguiente numero: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("la entrada no es valida");
                    Console.WriteLine("Ingrese el otro numero nuevamente: ");
                }
                //num2 = Convert.ToDouble(Console.ReadLine());
                // double.TryParse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Escribe el nombre del operador quieres usar: ");
                Console.WriteLine();
                Console.WriteLine("1 - SUMA");
                Console.WriteLine("2 - RESTA");
                Console.WriteLine("3 - MULTIPLICACION");
                Console.WriteLine("4 - DIVICION");
                Console.WriteLine("5 - SENO");
                Console.WriteLine("6 - COSENO");
                Console.WriteLine("7 - TANGENTE");
                Console.WriteLine("8 - EXPONENCIAL");
                Console.WriteLine("9 - LOGARITMO");
                Console.WriteLine("10 - RAIZ CUADRADA");
                Console.WriteLine();
                int operador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                double resultado;
                switch (operador)
                {
                    //voy a usar la variable resultado que esta desclarada pero no se usa
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado de la suma de  {num1} y {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado de la resta de {num1} y {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado de la multiplicacion de  {num1} y {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 4: //Agregando que no se puede dividir entre 0
                        resultado = num1 / num2;
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }
                        else
                        {
                            Console.WriteLine($"El resultado de la divicion de {num1} y {num2} es: " + (resultado));
                        }
                        num1 = resultado;
                        break;
                    case 5:
                        resultado = Math.Sin(num1);
                        Console.WriteLine($"El resultado del seno de  {num1} es: " + (resultado));
                        resultado = Math.Sin(num2);
                        Console.WriteLine($"El resultado del seno de  {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 6:
                        resultado = Math.Cos(num1);
                        Console.WriteLine($"El resultado del coseno de  {num1} es: " + resultado);
                        resultado = Math.Cos(num2);
                        Console.WriteLine($"El resultado del seno de  {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 7:
                        resultado = Math.Tan(num1);
                        Console.WriteLine($"El resultado la tangente de  {num1} es: " + resultado);
                        resultado = Math.Tan(num2);
                        Console.WriteLine($"El resultado del seno de  {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 8:
                        resultado = Math.Exp(num1);
                        Console.WriteLine($"El resultado el exponencial de  {num1} es: " + resultado);
                        resultado = Math.Exp(num2);
                        Console.WriteLine($"El resultado del seno de  {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 9:
                        resultado = Math.Log(num1);
                        Console.WriteLine($"El resultado del logaritmo de {num1} y {num2} es: " + resultado);
                        resultado = Math.Log(num2);
                        Console.WriteLine($"El resultado del seno de  {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    case 10:
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine($"El resultado del logaritmo de {num1} y {num2} es: " + resultado);
                        resultado = Math.Sqrt(num2);
                        Console.WriteLine($"El resultado del seno de  {num2} es: " + (resultado));
                        num1 = resultado;
                        break;
                    default:
                        Console.WriteLine("Ingresaste un valor invalido, regresa al menu.");
                        break;
                }
                Console.WriteLine("Pulse Y para seguir operando");
                terminar = Console.ReadLine().Trim().ToLower();
            }
        }

    }
}