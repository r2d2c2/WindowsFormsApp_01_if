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
        }

    }
}
