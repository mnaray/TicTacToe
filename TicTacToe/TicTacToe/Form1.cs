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
        // VARIABLES
        int roundCounter = 1;


        public Form1()
        {
            InitializeComponent();
        }


        // START AND RESET
        private void start_button_Click(object sender, EventArgs e)
        {
            board_picture.Visible = true;

            turn_label.Text = "Turn of: " + CheckTurn();
            turn_label.Visible = true;
            ShowSetLabels();
            start_button.Visible = false;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }


        // SET CELL
        private void set_A1_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_A1, X_A1, set_A1);
        }

        private void set_A2_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_A2, X_A2, set_A2);
        }

        private void set_A3_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_A3, X_A3, set_A3);
        }

        private void set_B1_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_B1, X_B1, set_B1);
        }

        private void set_B2_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_B2, X_B2, set_B2);
        }

        private void set_B3_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_B3, X_B3, set_B3);
        }

        private void set_C1_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_C1, X_C1, set_C1);
        }

        private void set_C2_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_C2, X_C2, set_C2);
        }

        private void set_C3_Click(object sender, EventArgs e)
        {
            RunWhenSet(O_C3, X_C3, set_C3);
        }


        // FUNCITONS

        // Does everything that needs to be done when cell is set
        public void RunWhenSet(PictureBox o, PictureBox x, Label label)
        {
            label.Visible = false;
            SetCell(o, x);
            roundCounter++;
            turn_label.Text = "Turn of: " + CheckTurn();

            switch (Winner())
            {
                case 'O':
                    MessageBox.Show("The winner is O!!!");
                    break;

                case 'X':
                    MessageBox.Show("The winner is X!!!");
                    break;

                case 'd':
                    MessageBox.Show("It's a draw!");
                    break;

                default:
                    break;
            }
        }

        // Checks whose turn it is (X or O)
        public char CheckTurn()
        {
            if (roundCounter % 2 == 0)
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        // Makes the image of the player visible in the cell
        public void SetCell(PictureBox o, PictureBox x)
        {
            switch (CheckTurn())
            {
                case 'O':
                    o.Visible = true;
                    break;

                case 'X':
                    x.Visible = true;
                    break;

                default:
                    turn_label.Text = "Something went wrong.\nPlease Reset the game.";
                    break;
            }
        }

        // Shows the clickable labels to set your turn
        public void ShowSetLabels()
        {
            set_A1.Visible = true;
            set_A2.Visible = true;
            set_A3.Visible = true;
            set_B1.Visible = true;
            set_B2.Visible = true;
            set_B3.Visible = true;
            set_C1.Visible = true;
            set_C2.Visible = true;
            set_C3.Visible = true;

            board_picture.SendToBack();
        }

        // Checks for 3 in a row for O
        public bool CheckForWinO()
        {
            if (O_A1.Visible && O_A2.Visible && O_A3.Visible)
            {
                return true;
            }
            else if (O_B1.Visible && O_B2.Visible && O_B3.Visible)
            {
                return true;
            }
            else if (O_C1.Visible && O_C2.Visible && O_C3.Visible)
            {
                return true;
            }
            else if (O_A1.Visible && O_B1.Visible && O_C1.Visible)
            {
                return true;
            }
            else if (O_A2.Visible && O_B2.Visible && O_C2.Visible)
            {
                return true;
            }
            else if (O_A3.Visible && O_B3.Visible && O_C3.Visible)
            {
                return true;
            }
            else if (O_A1.Visible && O_B2.Visible && O_C3.Visible)
            {
                return true;
            }
            else if (O_A3.Visible && O_B2.Visible && O_C1.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks for 3 in a row for X
        public bool CheckForWinX()
        {
            if (X_A1.Visible && X_A2.Visible && X_A3.Visible)
            {
                return true;
            }
            else if (X_B1.Visible && X_B2.Visible && X_B3.Visible)
            {
                return true;
            }
            else if (X_C1.Visible && X_C2.Visible && X_C3.Visible)
            {
                return true;
            }
            else if (X_A1.Visible && X_B1.Visible && X_C1.Visible)
            {
                return true;
            }
            else if (X_A2.Visible && X_B2.Visible && X_C2.Visible)
            {
                return true;
            }
            else if (X_A3.Visible && X_B3.Visible && X_C3.Visible)
            {
                return true;
            }
            else if (X_A1.Visible && X_B2.Visible && X_C3.Visible)
            {
                return true;
            }
            else if (X_A3.Visible && X_B2.Visible && X_C1.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks who won
        public char Winner()
        {
            if (CheckForWinO())
            {
                return 'O';
            }
            else if (CheckForWinX())
            {
                return 'X';
            }
            else if (roundCounter > 9)
            {
                return 'd';
            }
            else
            {
                return '-';
            }
        }
    }
}