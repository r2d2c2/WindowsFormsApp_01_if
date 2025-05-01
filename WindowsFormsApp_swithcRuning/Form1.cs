using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_swithcRuning
{
    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
        Error = 999
    }
    enum 주
    {
        월,
        화,
        수,
        목,
        금,
        토,
        일,
        에러 = 999
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // KeyDown 이벤트 핸들러 등록
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox1.KeyPress += MyTest;
        }

        private void MyTest(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터키를 감지
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 엔터키 입력을 TextBox에 표시하지 않음
                ExecuteFunction(); // 특정 기능 실행
            }
        }
        void ExecuteFunction()
        {
            주 day = 주.에러;
            string input = textBox1.Text;
            switch (input)
            {
                case "월":
                    day = 주.월;
                    textBox1.Text = $"{day}요일😬";
                    break;
                case "화":
                    day = 주.화;
                    textBox1.Text = $"{day}요일😐";
                    break;
                case "수":
                    day = 주.수;
                    textBox1.Text = $"{day}요일😮‍💨";
                    break;
                case "목":
                    day = 주.목;
                    textBox1.Text = $"{day}요일🙄";
                    break;
                case "금":
                    day = 주.금;
                    textBox1.Text = $"{day}요일🙃";
                    break;
                case "토":
                    day = 주.토;
                    textBox1.Text = $"{day}요일😌";
                    break;
                case "일":
                    day = 주.일;
                    textBox1.Text = $"{day}요일😒";
                    break;
                default:
                    textBox1.Text = "잘못 입력 하였습니다.";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
