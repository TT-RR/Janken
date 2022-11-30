using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janken
{
    class Life
    {
        private ProgressBar progressBar;

        public Life(ProgressBar progressBar,int maxLife)
        {
            //初期化
            this.progressBar = progressBar;
            this.progressBar.Maximum = maxLife;
            //HPを減らす機能
            this.progressBar.Step = -1;
        }

        public void Attack()
        //Attackが呼び出されたら、PerformStep実行
        {
            this.progressBar.PerformStep();
        }

        public bool Alive => this.progressBar.Value > 0;
        //AliveプロパティでHPバーが0より大きいか判定する
        //=>とは構造体のポインタと同じ使い方


        public void Reset()
        {
            //HPバーのゲージリセット
            this.progressBar.Value = this.progressBar.Maximum;
        }
    }
}
