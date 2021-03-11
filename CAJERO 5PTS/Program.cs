using System;

namespace CAJERO_5PTS
{
        class CAJERO5
        {
            static void Main(string[] args)
            {
                //Crear un programa que simule un banco que tiene 
                //3 clientes que pueden hacer depósitos y retiros. 
                //También el banco requiere que al final del día calcule 
                //la cantidad de dinero que hay depositado.

                int a, b, c, d, DE, DM, DS, RE, RM, RS, E = 100000, M = 50000, S = 40500;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Elija su usuario");
                    Console.WriteLine("(1) ELVIS");
                    Console.WriteLine("(2) MIGUEL");
                    Console.WriteLine("(3) SANDRA");
                    Console.WriteLine("(4) Salir");
                    a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Usuario: ELVIS");
                            Console.WriteLine("Elija una opción");
                            Console.WriteLine("(1) Depositar");
                            Console.WriteLine("(2) Retirar");
                            Console.WriteLine("(3) Salir");
                            b = int.Parse(Console.ReadLine());
                            if (b == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", E);
                                Console.WriteLine("Digite cantidad a depositar");
                                DE = int.Parse(Console.ReadLine());
                                E += DE;
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", E);
                                Console.ReadLine();
                            }
                            if (b == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", E);
                                Console.WriteLine("Digite cantidad a retirar");
                                RE = int.Parse(Console.ReadLine());
                                if (RE <= E)
                                {
                                    E -= RE;
                                }
                                else
                                {
                                    Console.WriteLine("No tiene balance suficiente para este reiro");
                                    Console.ReadLine();
                                }
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", E);
                                Console.ReadLine();
                            }
                        } while (b != 3);
                    }
                    if (a == 2)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Usuario: MIGUEL");
                            Console.WriteLine("Elija una opción");
                            Console.WriteLine("(1) Depositar");
                            Console.WriteLine("(2) Retirar");
                            Console.WriteLine("(3) Salir");
                            c = int.Parse(Console.ReadLine());
                            if (c == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", M);
                                Console.WriteLine("Digite cantidad a depositar");
                                DM = int.Parse(Console.ReadLine());
                                M += DM;
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", M);
                                Console.ReadLine();
                            }
                            if (c == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", M);
                                Console.WriteLine("Digite cantidad a retirar");
                                RM = int.Parse(Console.ReadLine());
                                if (RM <= M)
                                {
                                    M -= RM;
                                }
                                else
                                {
                                    Console.WriteLine("No tiene balance suficiente para este reiro");
                                    Console.ReadLine();
                                }

                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", M);
                                Console.ReadLine();
                            }
                        } while (c != 3);
                    }
                    if (a == 3)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Usuario: SANDRA");
                            Console.WriteLine("Elija una opción");
                            Console.WriteLine("(1) Depositar");
                            Console.WriteLine("(2) Retirar");
                            Console.WriteLine("(3) Salir");
                            d = int.Parse(Console.ReadLine());
                            if (d == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", S);
                                Console.WriteLine("Digite cantidad a depositar");
                                DS = int.Parse(Console.ReadLine());
                                S += DS;
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", S);
                                Console.ReadLine();
                            }
                            if (d == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", S);
                                Console.WriteLine("Digite cantidad a retirar");
                                RS = int.Parse(Console.ReadLine());
                                if (RS <= S)
                                {
                                    S -= RS;
                                }
                                else
                                {
                                    Console.WriteLine("No tiene balance suficiente para este reiro");
                                    Console.ReadLine();
                                }

                                Console.Clear();
                                Console.WriteLine("Su balance es de {0} pesos", S);
                                Console.ReadLine();
                            }
                        } while (d != 3);
                    }
                } while (a != 4);
            }
        }
    }
