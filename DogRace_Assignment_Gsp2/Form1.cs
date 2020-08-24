using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace_Assignment_Gsp2
{
    public partial class Form1 : Form
    {
        int Harpreet = 200, Hapz = 200, Jerman = 200;

        int winnerKuta = 0;

        Runner Run = new Runner();

        public Form1()
        {
            InitializeComponent();
        }

        private void race_btn_Click(object sender, EventArgs e)
        {
            //start the timer to run the Dogs
            runner.Enabled = true;
            runner.Start();
        }

        private void runner_Tick(object sender, EventArgs e)
        {
            kuta1.Left+= Run.jump();
            kuta2.Left += Run.jump();
            kuta3.Left += Run.jump();
            kuta4.Left += Run.jump();

            if (kuta1.Left>610) {
                runner.Stop();
                runner.Enabled = false;
                MessageBox.Show("Dog 1 won the Race ");
                winnerKuta = 1;
                resultDisplay();
            }

            else if (kuta2.Left > 610)
            {
                runner.Stop();
                runner.Enabled = false;
                MessageBox.Show("Dog 2 won the Race ");
                winnerKuta = 2;
                resultDisplay();
            }
            else if (kuta3.Left > 610)
            {
                runner.Stop();
                runner.Enabled = false;
                MessageBox.Show("Dog 3 won the Race ");
                winnerKuta = 3;
                resultDisplay();
            }

            else if (kuta4.Left > 610)
            {
                runner.Stop();
                runner.Enabled = false;
                MessageBox.Show("Dog 4 won the Race ");
                winnerKuta = 4;
                resultDisplay();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pass the amount to the combo box
            int y=0;
            for (y = 1; y < 50; y++) {
                selectionAmount.Items.Add("" + y);
            }

         //   race_btn.Enabled=false;   
        }


        public void resultDisplay() {
            String[] data;
            data = player1.Text.Split(' ');
            if (data.Length==8) {
                Harpreet=Run.balancePlayer(player1.Text,winnerKuta,Harpreet);
            }

            data = player2.Text.Split(' ');
            if (data.Length == 8)
            {
                Hapz = Run.balancePlayer(player2.Text, winnerKuta, Hapz);
            }

            data = player3.Text.Split(' ');
            if (data.Length == 8)
            {
                Jerman= Run.balancePlayer(player3.Text, winnerKuta, Jerman);
            }

            MessageBox.Show("Harpreet Accout Balance " + Harpreet);
            MessageBox.Show("Hapz Accout Balance " + Hapz);
            MessageBox.Show("Jerman Accout Balance " + Jerman);

            kuta1.Left = 0;
            kuta2.Left = 0;
            kuta3.Left = 0;
            kuta4.Left = 0;
            race_btn.Enabled = false;
            winnerKuta =0;
            selectionAmount.Text = "";
            SelectionDog.Text = "";
            SelectionPlayer.Text = "";
            player1.Text = "Player 1 has";
            player2.Text = "Player 2 has";
            player3.Text = "Player 3 has";
        }

        private void bet_btn_Click(object sender, EventArgs e)
        {
            //check the details 
            if (!SelectionDog.Text.Equals("") && !SelectionPlayer.Text.Equals("") && !selectionAmount.Text.Equals(""))
            {
                if (SelectionPlayer.SelectedIndex == 0 && Convert.ToInt32(selectionAmount.Text.ToString()) < Harpreet && !SelectionDog.Text.ToString().Equals(""))
                {
                    player1.Text = "Harpreet Select Dog " + SelectionDog.Text + " with Bet Amount " + selectionAmount.Text;
                    race_btn.Enabled = true;
                }
                else if (SelectionPlayer.SelectedIndex == 1 && Convert.ToInt32(selectionAmount.Text.ToString()) < Hapz && !SelectionDog.Text.ToString().Equals(""))
                {
                    player2.Text = "Hapz Select Dog " + SelectionDog.Text + " with Bet Amount " + selectionAmount.Text;
                    race_btn.Enabled = true;
                }
                else if (SelectionPlayer.SelectedIndex == 2 && Convert.ToInt32(selectionAmount.Text.ToString()) < Jerman && !SelectionDog.Text.ToString().Equals(""))
                {
                    player3.Text = "Jerman Select Dog " + SelectionDog.Text + " with Bet Amount " + selectionAmount.Text;
                    race_btn.Enabled = true;
                }
                else {
                    MessageBox.Show("Check your balance or select the dog ");
                }
               

            }
            else {
                MessageBox.Show("you must have to full fill the requirement of the Game ");
            }
        }
    }
}
