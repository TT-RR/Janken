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
        
         private void rookHand_Click(object sender, EventArgs e)
        {
            // プレイヤーの手をグーにする
            var playerHand = JyankenHand.Rock;
            Battle(playerHand);
        }

        
         private void Battle(JyankenHand playerHand)
        {
            //プレイヤーの手に応じた画像をゲームエリアに表示する

            playerHandBox.Image = GetHandImage(playerHand);

            //敵の手をランダムに決める
            var random = new Random();
            var enemyHandValue = random.Next(0, 3);//0~2までのランダムな数値
            var enemyHand = (JyankenHand)enemyHandValue;//列挙型にキャスト
            //敵の手に応じた画像をゲームエリアに表示
            enemyHandBox.Image = GetHandImage(enemyHand);//enemyHandにはランダムの値が入っている。

            //勝敗を判定する
            JyankenResult jyankenResult;
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
        

    }
}
