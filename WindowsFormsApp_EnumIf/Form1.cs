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
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;//점수 초기화 레이블 숨김
        }

        Result GamePlayer(RPS rps)
        {//승부 판단 로직
            Random random = new Random();
            int com = random.Next(0, 3); //0~2까지 랜덤으로 생성
            switch (com)
            {

            }
            return Result.Draw;
        }
        void GameStatus()
        {//게임 전체 관리 로직

        }
        async void GameReset()
        {//승부 완료 후, 점수 초기화 로직
            label3.Visible = true;
            playerScore = 0;
            comScore = 0;
            textBox2.Text = playerScore.ToString();
            textBox3.Text = comScore.ToString();
        }
    }
     
}
