using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region #반복문
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("i=" + i);
            }
            Console.WriteLine("----------------------");
            for (int i = 5; i >=1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");
            int n = 10;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                Console.WriteLine($"현제 i의 값 : {i} \r\n 현재 합게 {sum}\r\n");
            }
            #endregion
            #region # 실습 1
            //실습
            Console.WriteLine("--------------------");
            int mySum = 0;
            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    mySum += i;
                    
                }
            }
            Console.WriteLine($"짝수의 합 : {mySum}");
            #endregion
            #region # 실습 2
            Console.WriteLine("---------------------");
            int sum2 = 0;
            for (int i = 1; i < 100; i++)
            {
                if(i%3==0)
                    if (!(i % 5 == 0))
                    {
                        Console.WriteLine(i);
                        sum2 += i;
                    }
            }
            Console.WriteLine($"3의 배수지만 5의 배수는 아닌수의 종합 : {sum2}");
            #endregion
            #region # 중첩for문
            Console.WriteLine("---------------------");
            for (int i =1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i={i}, j={j}");
                }
            }

            #endregion
            #region #구구단
            Console.WriteLine("---------------------");
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
            }
            #endregion
            #region # 별찍기
            Console.WriteLine("----------------------");
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= Math.Abs(5 - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            #region # 별찍기2
            Console.WriteLine("--------------------");
            for (int i = 1; i <= 7; i+=2)
            {
                for (int k = 1; k <= ((int)((Math.Abs(7 - i)/2))); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }

    }
}
