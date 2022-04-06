using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if simplificado, dentro do parentese fica a condição e fora do parenteses fica o que vai ser feito.
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            Console.WriteLine();

            DateTime d = new DateTime(2022, 03, 24, 22, 44, 55);

            DateTime d2 = new DateTime(2022, 04, 6, 22, 44, 55);

            DateTime d1 = d.AddDays(13);

            TimeSpan t = d2.Subtract(d);

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine();
            Console.WriteLine(t);
            Console.WriteLine();
            Console.WriteLine(t1);
            Console.WriteLine();
            Console.WriteLine(t2);
            Console.WriteLine();
            Console.WriteLine(t3);
        }
    }
}

/*          Console.Write("Enter the array order you want: "); ;
            int Line = int.Parse(Console.ReadLine());
            int Column = Line;
            int[,] mat = new int[Line, Column];
            Console.WriteLine();

            for(int i = 0; i < Line; i++)
            { 
                for (int jo = 0; jo < Column; jo++)
                {
                    Console.Write("Enter the number to be used in the matrix: ");
                    mat[i,jo] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < Line; i++)
            {
                Console.WriteLine();

                for (int jo = 0; jo < Column; jo++)
                {
                    Console.Write(" " + mat[i, jo] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < Line; i++)
            {
                for (int jo = 0; jo < Column; jo++)
                {
                    if (i == jo)
                    {                        
                        Console.Write(mat[i, jo] + " ");
                    }
                }
            }

            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < Line; i++)
            {
                for (int jo = 0; jo < Column; jo++)
                {
                    
                    if (mat[i,jo] < 0)
                    {
                        count++;                      
                    }
                }
            }
            Console.WriteLine("Negative numbers: ");
            Console.WriteLine(count);
        }
    }*/

/*Console.Write("Enter the array order you want: "); ;
            int Line = int.Parse(Console.ReadLine());

            Console.Write("Enter the array order you want: "); ;
            int Column = int.Parse(Console.ReadLine());

            int[,] mat = new int[Line, Column];
            Console.WriteLine();

            for(int i = 0; i < Line; i++)
            {
                string[]  values = Console.ReadLine().Split(' ');
                for (int jo = 0; jo < Column; jo++)
                {                   
                    mat[i,jo] = int.Parse(values[jo]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < Line; i++)
            {
                Console.WriteLine();

                for (int jo = 0; jo < Column; jo++)
                {
                    Console.Write(" " + mat[i, jo] + " ");
                }
            }

            Console.WriteLine();

            Console.Write("Enter the number you want to search in the matrix: ");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < Line; i++)
            {
                Console.WriteLine();

                for (int jo = 0; jo < Column; jo++)
                {
                    if(mat[i,jo] == search);
                    {
                        Console.WriteLine("The numbers around it in the matrix are: ");
                        if (jo > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, jo - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, jo]);
                        }
                        if (jo < Line)
                        {
                            Console.WriteLine("Right: " + mat[i, jo + 1]);
                        }
                        if (jo < Column)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, jo]);
                        }
                    }
                }
            } */