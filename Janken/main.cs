using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janken
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //5-7まで

            //画面の初期化
            //手を選択できないようにする
            rookHand.Enabled = false;
            scissorsHand.Enabled = false;
            paperHand.Enabled = false;

        }
        
         private void rookHand_Click(object sender, EventArgs e)//グーの処理
        {
            // プレイヤーの手をグーにする
            var playerHand = JankenHand.Rock;
            Battle(playerHand);
        }

          private void paperHand_Click(object sender, EventArgs e)//チョキを表示する処理
        {
            // プレイヤーの手パーにする
            var playerHand = JankenHand.Paper;
            Battle(playerHand);
        }

          private void scissorsHand_Click(object sender, EventArgs e)//playerHandにパーを表示する処理
        {
            // プレイヤーの手をチョキにする
            var playerHand = JankenHand.Scissors;
            Battle(playerHand);
        }
        
         private void Battle(JankenHand playerHand)//勝ち負けの判定
        {
            //プレイヤーの手に応じた画像をゲームエリアに表示する
            playerHandBox.Image = GetHandImage(playerHand);

            //敵の手をランダムに決める
            var random = new Random();
            var enemyHandValue = random.Next(0, 3);//0~2までのランダムな数値
            var enemyHand = (JankenHand)enemyHandValue;//列挙型にキャスト
            //敵の手に応じた画像をゲームエリアに表示
            enemyHandBox.Image = GetHandImage(enemyHand);//enemyHandにはランダムの値が入っている。

            //勝敗を判定する
            JankenResult jankenResult;
            if (playerHand == enemyHand)
            {
                jankenResult = JankenResult.Even;
            }
            else if ((playerHand == JankenHand.Rock && enemyHand == JankenHand.Scissors) || (playerHand == JankenHand.Scissors && enemyHand == JankenHand.Paper) || (playerHand == JankenHand.Paper && enemyHand == JankenHand.Rock))
            {
                jankenResult = JankenResult.Win;//勝ち
            }
            else
            {
                jankenResult = JankenResult.Losing;//負け
            }
            switch (jankenResult)
            {
                case JankenResult.Even:
                    MessageBox.Show("あいこです");
                    break;
                case JankenResult.Win:
                    MessageBox.Show("勝ちです");
                    break;
                case JankenResult.Losing:
                    MessageBox.Show("負けです");
                    break;
                default:
                    break;
            }
        }
        private void GetHandImage(jankenHand hand)//元々rookHand_clickだったが、関数の抽出で関数化させている。
        //グーをクリックすると、
        {
           
            Image handImage;
            if(hand==JankenHand.Rock)
            {
                handImage = Properties.Resources.rock;
            }
            else if (hand == JankenHand.Scissors)
            {
                handImage = Properties.Resources.scissors;
            }
            else
            {
                handImage = Properties.Resources.paper;
            }
            //押された手に応じた画像をプレイヤーの手にする
            //prayerHand.Image = handImage;
            return handImage;//選ばれた手の列挙型の値を返す（0,1,2）
        }
        

         private void startButton_Click(object sender, EventArgs e)
        {
            //スタートボタンが押されたら、それぞれの手を押せるようにする。
            rookHand.Enabled = true;
            scissorsHand.Enabled = true;
            paperHand.Enabled = true;

            //自分と相手の手を非表示にする
            playerHandBox.Image = null;
            enemyHandBox.Image = null;

            MessageBox.Show("ゲームスターと");
        }

    }
}
