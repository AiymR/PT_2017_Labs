using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_recursion
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            F2();
        }
            private static void F1(){
            

           Console.ReadLine();
                Stack<long> fibo = new Stack<long>();
                fibo.Push(0);
                fibo.Push(1);
            int n = int.Parse(Console.ReadLine());
                for (int i = 2; i < n; i++)
                {
                    long prev = fibo.Pop();
                    long next = prev + fibo.Peek();
                    fibo.Push(prev);

                    fibo.Push(next);


                    
                }

            Console.WriteLine(fibo.Peek());

            Console.ReadKey();
            }
        private static void F2()
        {
            Class Fibo {
                int n;
            }
           
            int Fibo(int n)
            {
                 

                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return Fibo(n - 1) + Fibo(n - 2);
                }
            }

        }
        }

        }

    }
    
    

