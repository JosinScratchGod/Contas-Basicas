using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, loop, min, rpmax, max;
            Console.WriteLine("\nCalculadora de Matemática Básica\n---------------------------\n\nEscolha um modo\n[1] Simples (Adições)\n[2] Díficil (Adições e Subtrações)");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\nAntes de começar, escolha os números\nNúmero mínimo:");
            Console.SetCursorPosition(15, 2);
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número máximo:");
            Console.SetCursorPosition(15, 3);
            rpmax = Convert.ToInt32(Console.ReadLine());
            max = rpmax + 1;
            switch (op)
            {   
                case 1:
                do
                {
                    Console.Clear();
                    int c;
                    int[] resp = new int[10];
                    Random num = new Random();
                    Console.WriteLine("\nResolva as contas a seguir:");
                    for (c = 0; c < 10; c++)
                    {
                        int num1 = num.Next(min, max);
                        int num2 = num.Next(min, max);
                        resp[c] = num1 + num2;
                        Console.WriteLine("{0}. {1} + {2}", c + 1, num1, num2);
                    }
                    Console.WriteLine("\nPronto?\nSe sim, aperte ENTER para ver os resultados");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    for (c = 0; c < 10; c++)
                    {
                        Console.WriteLine("{0}. {1}", c + 1, resp[c]);
                    }
                    Console.WriteLine("\nDeseja continuar?\nSe sim, digite 1");
                    loop = Convert.ToInt32(Console.ReadLine());
                } while (loop != 2);
                break;
                case 2:
                do
                {
                    Console.Clear();
                    int c;
                    int[] resp = new int[10];
                    Random num = new Random();
                    Console.WriteLine("\nResolva as contas a seguir:");
                    for (c = 0; c < 10; c++)
                    {
                        int num1 = num.Next(min, max);
                        int num2 = num.Next(min, max);
                        int num3 = num.Next(min, max);
                        int sig1 = num.Next(0, 2);
                        int sig2 = num.Next(0, 2);
                        int sig3 = num.Next(0, 2);
                            if (sig1 == 0 && sig2 == 0 && sig3 == 0)
                            {
                                Console.WriteLine("{0}. +{1} + {2} + {3}", c + 1, num1, num2, num3);
                                resp[c] = num1 + num2 + num3;
                            }
                            if (sig1 == 1 && sig2 == 0 && sig3 == 0)
                            {
                                Console.WriteLine("{0}. +{1} - {2} + {3}", c + 1, num1, num2, num3);
                                resp[c] = num1 - num2 + num3;
                            }
                            if (sig1 == 0 && sig2 == 1 && sig3 == 0)
                            {
                                Console.WriteLine("{0}. +{1} + {2} - {3}", c + 1, num1, num2, num3);
                                resp[c] = num1 + num2 - num3;
                            }
                            if (sig1 == 1 && sig2 == 1 && sig3 == 0)
                            {
                                Console.WriteLine("{0}. +{1} - {2} - {3}", c + 1, num1, num2, num3);
                                resp[c] = num1 - num2 - num3;
                            }
                            if (sig1 == 0 && sig2 == 0 && sig3 == 1) 
                            {
                                Console.WriteLine("{0}. -{1} + {2} + {3}", c + 1, num1, num2, num3);
                                resp[c] = -num1 + num2 + num3;
                            }
                            if (sig1 == 1 && sig2 == 0 && sig3 == 1)
                            {
                                Console.WriteLine("{0}. -{1} - {2} + {3}", c + 1, num1, num2, num3);
                                resp[c] = -num1 - num2 + num3;
                            }
                            if (sig1 == 0 && sig2 == 1 && sig3 == 1)
                            {
                                Console.WriteLine("{0}. -{1} + {2} - {3}", c + 1, num1, num2, num3);
                                resp[c] = -num1 + num2 - num3;
                            }
                            if (sig1 == 1 && sig2 == 1 && sig3 == 1)
                            {
                                Console.WriteLine("{0}. -{1} - {2} - {3}", c + 1, num1, num2, num3);
                                resp[c] = -num1 - num2 - num3;
                            }
                        }
                    Console.WriteLine("\nPronto?\nSe sim, aperte ENTER para ver os resultados");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine();
                    for (c = 0; c < 10; c++)
                    {
                        Console.WriteLine("{0}. {1}", c + 1, resp[c]);
                    }
                    Console.WriteLine("\nDeseja continuar?\nSe sim, digite 1");
                    loop = Convert.ToInt32(Console.ReadLine());
                } while (loop != 2);
                break;
            }
        }
    }
}
