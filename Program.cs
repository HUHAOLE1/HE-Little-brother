using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择");
            Console.WriteLine("1:取钱");
            Console.WriteLine("2:存钱");
            int a = int.Parse(Console.ReadLine());
            int je= 5000;
            switch(a){
                case 1 :
                    Console.WriteLine("请输入取钱金额");
                    int b = int.Parse(Console.ReadLine());
                    if (b > je)
                    {
                        Console.WriteLine("余额不足，请充值。");
                    }
                    else {
                        if (b <= 0 )
                        {
                            Console.WriteLine("出入错误");
                        }
                        else {
                            Console.WriteLine("余额为:"+(5000-b));
                        }
                    }
                break;
                case 2 :
                    Console.WriteLine("请输入存钱金额");
                    int c = int.Parse(Console.ReadLine());
                    if (c < 0)
                    {
                        Console.WriteLine("输入错误");
                    }

                    else 
                    {
                        
                            Console.WriteLine("你的余额为" + (je + c));
                    }
                     
                break;
                default :
                Console.WriteLine("输入错误");
                break;
            }

        }
    }
}
