using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = x turn, false = y turn
        int turn_count = 0;

        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Jek", "Tic Tac Toe ");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //pass thebutton and put = 

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn; //if its not your tunr so its not your turn
            b.Enabled = false; // not allow to press the sam button 2 time
            turn_count++;
            checkForWinner();

        }
        private void checkForWinner()

        {
            //xled row
            bool there_is_a_winner = false;
            if((A1.Text == A2.Text)&&(A2.Text == A3.Text)&& ( !A1.Enabled))
                there_is_a_winner = true;

            else if ((B1.Text == B2.Text) &&(B2.Text == B3.Text)&&(!B1.Enabled))
                there_is_a_winner = true;

           else  if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
                there_is_a_winner = true;
            //yled
           else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal

           else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;

           else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

           

            if (there_is_a_winner) {

                disableButtons();
                String winner = "";
                if (turn)
                    winner = "O ";
                else
                    winner = "X ";
                MessageBox.Show(winner + " wins!", "wooow!");
            }//end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!");
            }

        }//end checkforwinner

        //create method
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//end try
            catch
            {

            }//end catch
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset
            turn = true;
            turn_count = 0 ;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end foreach
            }//end try
            catch
            {

            }//end catch

        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game plays by two players. If a player gets three in x och three o in a row or in a colum or diagonal wins ");
        }

      

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            
                b.Text = "X turn";
                else 
              
                b.Text = " O turn";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
