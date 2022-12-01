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

        private int roundCount;
        private int wonCount;
        private int lossCount;
        private PictureBox[] winLossResults;

        //ライフ関連
        private Life playerLife;
        private Life enemyLife;

        //試合中か動かを設定する
        private bool InGame
        {
            set
            {
                rookHand.Enabled = value;
                scissorsHand.Enabled = value;
                paperHand.Enabled = value;
            }
        }
        public main()
        {
            InitializeComponent();

            winLossResults = new[]
            {
                winLoss1PictureBox,
                winLoss2PictureBox,
                winLoss3PictureBox,
                winLoss4PictureBox,
                winLoss5PictureBox
            };

            playerLife = new Life(playerBar, 5);
            enemyLife = new Life(enemyBar, 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void rookHand_Click(object sender, EventArgs e)//グーの処理
        {
            // プレイヤーの手をグーにする
            var playerHand = JankenHand.Rock;
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
                    MessageBox.Show("あいこです" + Environment.NewLine + "もう一度手を選んでください");
                    //あいこの場合もう一回勝負するため
                    return;

                case JankenResult.Win:
                    //敵のHPバー減らす
                    enemyLife.Attack();
                    MessageBox.Show("勝ちです");
                    winLossResults[roundCount - 1].Image = Properties.Resources.circle;
                    break;

                case JankenResult.Losing:
                    //プレイヤーのHPバー減らす
                    playerLife.Attack();
                    MessageBox.Show("負けです");
                    winLossResults[roundCount - 1].Image = Properties.Resources.cross;
                    break;

                default:
                    break;
            }

            //ライフが残っていればラウンドを継続する
            if (playerLife.Alive && enemyLife.Alive)
            {
                return;
            }

            //どちらかのライフがなくなったのでラウンドを終了する
            Image winlossResultImage;
            if (playerLife.Alive)
            {
                MessageBox.Show($"{roundCount}回戦はあなたの勝ちです");
                wonCount += 1;  //ラウンドごとの勝ち数
                winlossResultImage = Properties.Resources.circle;
            }
            else
            {
                MessageBox.Show($"{roundCount}回戦はあなたの負けです");
                lossCount += 1; //ラウンドごとの負け数
                winlossResultImage = Properties.Resources.cross;
            }
            winLossResults[roundCount - 1].Image = winlossResultImage;

            //試合終了を判定する
            if (wonCount == 3 || lossCount == 3)
            {
                MessageBox.Show("試合終了");
                string gameResult;
                if (wonCount > lossCount)
                {
                    gameResult = "ゲームクリア！";
                }
                else
                {
                    gameResult = "ゲームオーバー！";
                }
                MessageBox.Show($"{ gameResult} ({wonCount}勝{lossCount}敗)");

                //試合ではない
                InGame = false;

                return;
            }
            //次のラウンドに移る
            NextRound();
        }
        private static Image GetHandImage(JankenHand hand)//元々rookHand_clickだったが、関数の抽出で関数化させている。
        //グーをクリックすると、
        {

            Image handImage;
            if (hand == JankenHand.Rock)
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




        private void enemyHandBox_Click(object sender, EventArgs e)
        {

        }

        private void paperHand_Click_1(object sender, EventArgs e)
        {
            // プレイヤーの手パーにする
            var playerHand = JankenHand.Paper;
            Battle(playerHand);
        }

        private void scissorsHand_Click_1(object sender, EventArgs e)
        {
            // プレイヤーの手をチョキにする
            var playerHand = JankenHand.Scissors;
            Battle(playerHand);
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {

            StartGame();

        }

        private void StartGame()//元々、startButton_Click_1メソッドの処理の一部
        {
            //試合中
            InGame = true;

            //自分と相手の手を非表示にする
            playerHandBox.Image = null;
            enemyHandBox.Image = null;

            //勝敗表をクリアにする
            foreach (var pictureBox in winLossResults)
            {
                pictureBox.Image = null;
            }

            MessageBox.Show("ゲームスタート");

            //ラウンド数を初期化
            roundCount = 0;
            //勝敗を初期化
            wonCount = 0;
            lossCount = 0;

            //最初のラウンドを始める
            NextRound();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //5-7まで

            //画面の初期化
            /*//手を選択できないようにする
            rookHand.Enabled = false;
            scissorsHand.Enabled = false;
            paperHand.Enabled = false;*/

            //試合ではない
            InGame = false;
        }
        //次のラウンドに移動する
        private void NextRound()
        {
            //ライフリセット
            playerLife.Reset();
            enemyLife.Reset();

            //手の画像をクリア
            playerHandBox.Image = null;
            enemyHandBox.Image = null;

            roundCount += 1;
            MessageBox.Show($"{roundCount}回戦");
        }

       

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //スタートメニューを押されたら
            StartGame();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //終了を押したとき
            Close();
        }

     
        private void AboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //情報ボタンを押したときの処理
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog();
            }
        }
    }
}