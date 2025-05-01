using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum testEnum 
{ 
    start,
    end=10000000
}
namespace WindowsFormsApp_01_if
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //RandomNumber(false);

            GotoSwitch();

        }
        #region # goto문
        void TestGoto()
        {
            int i = 0;
            goto end;  // +1을 건너뛰고 이동
            i++;
        end:
            MessageBox.Show("i=" + i);
        }

        void TestGoto2()
        {
            int selection = 0;
            textBox_print.Text = "Start \r\n";
        Location:
            textBox_print.Text += "Location \r\n";
            if(selection == 0)
            {
                textBox_print.Text+= "if문안 \r\n";
                selection = 1;
                goto Location;
            }
        }
        //goto switch문
        //switch문에서 중복없이 처리하기위함
        void GotoSwitch()
        {
            CoffeeMenu choice = CoffeeMenu.WithIceCream;
            switch (choice)
            {
                case CoffeeMenu.Plain:
                    textBox_print.Text += "Coffee";
                    break;
                case CoffeeMenu.WithMilk:
                    textBox_print.Text += " with Milk";
                    break;
                case CoffeeMenu.WithIceCream:
                    textBox_print.Text += " with Ice Cream";
                    goto case CoffeeMenu.Plain;
                    //break;
                default:
                    textBox_print.Text += " Coffee";
                    break;
            }
        }

        #endregion

        #region # enum
        enum CoffeeMenu
        {
            Plain,
            WithMilk,
            WithIceCream
        }
        enum Food
        {
            Pizza,
            Burger,
            Pasta,
            Kimchi=100

        }
        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Error=999
        }
        #endregion
        #region #  switch
        void TestSwitch()
        {
            string anmal = "cat";
            switch(anmal)
            {
                case "dog":
                    MessageBox.Show("강아지");
                    break;
                case "cat":
                    MessageBox.Show("고양이");
                    break;
                case "tiger":
                    MessageBox.Show("호랑이");
                    break;
                default:
                    MessageBox.Show("모르겠다.");
                    break;
            }

            //같은 enum 타입만 비교가능하고 다른 enum 타입은 비교 불가
            Food food = Food.Pizza;
            if(food==Food.Pizza)
            {

            }
            switch(food)
            {
                case Food.Pizza:
                    MessageBox.Show("피자");
                    break;
                case Food.Burger:
                    MessageBox.Show("햄버거");
                    break;
                case Food.Pasta:
                    MessageBox.Show("파스타");
                    break;
                default:
                    MessageBox.Show("모르겠다.");
                    break;
            }

        }

        #endregion

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

        #region # 실습 3

        void ViewText(bool inputBool)
        {
            if (CoinToss(inputBool))
            {
                textBox1.Text = ("승리");
            }
            else
            {
                textBox1.Text = ("패배");
            }
        }
        private void radioButtonTrue_CheckedChanged(object sender, EventArgs e)
        {
            bool isTure = true;
            ViewText( isTure);
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBoxInput.Text;// 택스트 붙붙

            
            try
            {
                bool isText = bool.Parse(textBoxInput.Text);
                ViewText( isText);
            }
            catch (Exception ex)
            {
                textBox1.Text = "잘못된 입력 입니다";
            }
            if (textBoxInput.Text == "" || textBoxInput.Text == string.Empty)
            {//textBoxInput.Text.Length>0
                ViewText(radioButtonTrue.Checked);
            }

        }

        private void radioButtonfalse_CheckedChanged(object sender, EventArgs e)
        {
            bool isTure = false;
            ViewText( isTure);
        }
    }
    #endregion
}
