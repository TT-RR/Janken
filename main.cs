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
            var hand = JankenHand.Rock;

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
            prayerHand.Image = handImage;
        }

    }
}
