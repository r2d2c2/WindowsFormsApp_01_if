using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_EnumIf
{
    //가위 바위보
    enum RPS
    {
        Rock,
        Paper,
        Scissors
    }
    //승리,무승부,패배
    enum Result
    {
        Win,
        Draw,
        Lose
    }
    public partial class Form1 : Form
    {
        int playerScore = 0; //플레이어 점수
        int comScore = 0; //컴퓨터 점수
        int gameCount = 0; //게임 횟수
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            textBox1.Text = "게임을 시작해 주세요";

            GameStatus();
        }

        Result GamePlayer(RPS rps)
        {//승부 판단 로직
            Random random = new Random();
            int com = random.Next(0, 3); //0~2까지 랜덤으로 생성
            switch (com)
            {
                case 0:
                    textBox1.Text = $"마왕의 선택 : {RPS.Scissors}  \r\n";
                    if(rps == RPS.Scissors)
                    {
                        textBox1.Text += "비겼습니다.";
                        comScore++;
                        return Result.Draw;
                    }
                    else if (rps == RPS.Rock)
                    {
                        textBox1.Text += "당신이 이겼습니다.";
                        playerScore++;
                        return Result.Win;
                    }
                    else
                    {
                        textBox1.Text += "당신이 졌습니다.";
                        comScore++;
                        return Result.Lose;
                    }
                case 1:
                    textBox1.Text = $"마왕의 선택 : {RPS.Rock} \r\n";
                    if (rps == RPS.Rock)
                    {
                        textBox1.Text += "비겼습니다.";
                        comScore++;
                        return Result.Draw;
                    }
                    else if (rps == RPS.Paper)
                    {
                        textBox1.Text += "당신이 이겼습니다.";
                        playerScore++;
                        return Result.Win;
                    }
                    else
                    {
                        textBox1.Text += "당신이 졌습니다.";
                        comScore++;
                        return Result.Lose;
                    }
                case 2:
                    textBox1.Text = $"마왕의 선택 : {RPS.Paper} \r\n";
                    if (rps == RPS.Paper)
                    {
                        textBox1.Text += "비겼습니다.";
                        comScore++;
                        return Result.Draw;
                    }
                    else if (rps == RPS.Scissors)
                    {
                        textBox1.Text += "당신이 이겼습니다.";
                        playerScore++;
                        return Result.Win;
                    }
                    else
                    {
                        textBox1.Text += "당신이 졌습니다.";
                        comScore++;
                        return Result.Lose;
                    }
            }
            return Result.Draw;
        }
        void GameStatus()
        {//게임 전체 관리 로직

            textBox2.Text = playerScore.ToString();
            textBox3.Text = comScore.ToString();
            if (playerScore == 3)
            {
                textBox1.Text = "";
                textBox1.Text += "당신이 이겼습니다.(＊`・ ﾜ・´＊)ノ";
                GameReset();
                return;
            }
            else if (comScore == 3)
            {
                textBox1.Text = "";
                textBox1.Text += "마왕이 우주정복을 했어요 ૮ ․ ․ ྀིა.";
                GameReset();
                return;
            }


        }
        async void GameReset()
        {//승부 완료 후, 점수 초기화 로직
            await Task.Delay(5000);//5초 대기
            label3.Visible = true;
            playerScore = 0;
            comScore = 0;
            gameCount = 0;
            textBox2.Text = playerScore.ToString();
            textBox3.Text = comScore.ToString();
            await Task.Delay(5000);
            label3.Visible = false;
            textBox1.Text = "게임을 시작해 주세요";
            GameStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {//가위
            GamePlayer(RPS.Scissors);
            GameStatus();
        }

        private void button2_Click(object sender, EventArgs e)
        {//바위
            GamePlayer(RPS.Rock);
            GameStatus();
        }

        private void button3_Click(object sender, EventArgs e)
        {//보
            GamePlayer(RPS.Paper);
            GameStatus();
        }
    }
     
}
