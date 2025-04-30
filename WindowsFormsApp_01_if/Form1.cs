using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_01_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //RandomNumber(false);

            if(CoinToss(true))
            {
                textBox1.Text=("승리");
            }
            else
            {
                textBox1.Text=("패배");
            }
        }
        #region # 개인 if문 실습
        bool RandomNumber(bool isinput)
        {
            int isZeroOne;
            //int형 난수 생성
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            if (randomNumber % 2 == 0)
            {
                isZeroOne = 0;
                if (isinput == false)
                {
                    MessageBox.Show("승리.");
                }
                else
                {
                    MessageBox.Show("패배.");
                }
            }
            else
            {
                isZeroOne = 1;
                if (isinput == false)
                {
                    MessageBox.Show("패배.");
                }
                else
                {
                    MessageBox.Show("승리.");
                }
            }
            return isinput;
        }
        #endregion
        #region 동전던지기 실습
        bool CoinToss(bool isinput)
        {
            int isZeroOne;
            //int형 난수 생성
            Random random = new Random();
            int randomNumber = random.Next() % 2;
            
            if((randomNumber==1&&isinput==true)||(randomNumber==0&&isinput==false))
                return true;

            return false;
        }
        #endregion
    }
}
