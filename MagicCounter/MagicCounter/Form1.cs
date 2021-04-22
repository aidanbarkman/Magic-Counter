using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int playLife = 0;
        int numberPlay = 0;
       
        private void Form1_Load(object sender, EventArgs e)
        {
           // IsVisible(false);
            int size = ClientSize.Width;
            

        }

        public void IsVisible(bool visible)
        {
            playNumLbl.Visible = visible;
            playersLbl.Visible = visible;
            playerAdd.Visible = visible;
            playerRemove.Visible = visible;
            playerNum.Visible = visible;
        
            
        }
        public void play3Visible(bool visible)
        {
            playtb3.Visible = visible;
            add3.Visible = visible;
            sub3.Visible = visible;
            play3.Visible = visible;
        }
        public void play4Visible(bool visible)
        {
            textBox4.Visible = visible;
            add4.Visible = visible;
            sub4.Visible = visible;
            play4.Visible = visible;
        }

        private void twenty_Click(object sender, EventArgs e)
        {
           
            playersLife.Text = "20";          
            IsVisible(true);
        }

        private void thirty_Click(object sender, EventArgs e)
        {
       
            playersLife.Text = "30";         
            IsVisible(true);

        }

        private void fourty_Click(object sender, EventArgs e)
        {
      
            playersLife.Text = "40";
            IsVisible(true);
        }

        private void playersLife_Click(object sender, EventArgs e)
        {

        }

        private void playerAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(playerNum.Text) < 4)
                playerNum.Text = (Convert.ToInt16(playerNum.Text) + 1).ToString();
            else
                MessageBox.Show("only 4 players");
        }

        private void playerRemove_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(playerNum.Text) > 2)
                playerNum.Text = (Convert.ToInt16(playerNum.Text) - 1).ToString();
            else
                MessageBox.Show("Minimum 2 players");
        }

        private void counterTabs_Click(object sender, EventArgs e)
        {
           
        }

        private void counterTab_Click(object sender, EventArgs e)
        {
            playLife = Convert.ToInt16(playersLife.Text);
            numberPlay = Convert.ToInt16(playerNum.Text);
            play1.Text = playLife.ToString();
            play2.Text = playLife.ToString();
            play3.Text = playLife.ToString();
            play4.Text = playLife.ToString();

            if (Convert.ToInt16(playerNum.Text) == 2)
            {
                play3Visible(false);
                play4Visible(false);
            }
            else if (Convert.ToInt16(playerNum.Text) == 3)
            {
                play3Visible(true);
                play4Visible(false);
            }
            else if (Convert.ToInt16(playerNum.Text) == 4)
            {
                play3Visible(true);
                play4Visible(true);
            }
            
             
        }

        private void add1_Click(object sender, EventArgs e)
        {
            play1.Text = (Convert.ToInt16(play1.Text)+1).ToString();
        }

        private void sub1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(play1.Text) > 0)
            play1.Text = (Convert.ToInt16(play1.Text) - 1).ToString();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            play2.Text = (Convert.ToInt16(play2.Text) + 1).ToString();
        }

        private void sub2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(play2.Text) > 0)
                play2.Text = (Convert.ToInt16(play2.Text) - 1).ToString();
        }

        private void add3_Click(object sender, EventArgs e)
        {
            play3.Text = (Convert.ToInt16(play3.Text) + 1).ToString();
        }

        private void sub3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(play3.Text) > 0)
                play3.Text = (Convert.ToInt16(play3.Text) - 1).ToString();
        }

        private void add4_Click(object sender, EventArgs e)
        {
            play4.Text = (Convert.ToInt16(play3.Text) + 1).ToString();
        }

        private void sub4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(play4.Text) > 0)
                play4.Text = (Convert.ToInt16(play4.Text) - 1).ToString();
        }
    }
}
