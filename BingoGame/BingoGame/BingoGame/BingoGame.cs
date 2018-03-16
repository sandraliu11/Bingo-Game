using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Sandra Liu
// CIS 3309
// Feb 7, 2018

// Class Purpose: Main form class that controls the entire game
namespace BingoGame
{
    public partial class frmBingoGame : Form
    {

        public frmBingoGame()
        {
            InitializeComponent();
        }

        // private readonly ManualResetEvent mre = new ManualResetEvent(false);

        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        int countOfCalledNumbers;
        int nextCalledNumber;

        private InternalCardType2DimArray internalCardRep2DArray = new InternalCardType2DimArray(BINGOCARDSIZE);
        //private InternalCardTypeWO2DimArray internalCardRepWO2DArray = new InternalCardTypeWO2DimArray(BINGOCARDSIZE);
        private RNGType RNGObj = new RNGType();
        private SelectedNumbersListType usedNumber = new SelectedNumbersListType();

        private string bingoLetters = "BINGO";


        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        // Convert a char to int method
        int convertCharToInt(char c)
        {
            return ((int)(c) - (int)('0'));
        }


        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Make the "Free Space" button unclickable to prevent errors
                    if (newButton[row, col].Name == "btn22")
                    {
                        newButton[row, col].Enabled = false;
                    }
                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar


        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            // Disable yes and no play buttons so user doesn't reset board
            btnYesPlay.Enabled = false;
            btnNoPlay.Enabled = false;

            bool bingoCount2D;
            // int bingoCountWO2D;
            int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

                // Double check that clicked on button value matches called value
                selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);

            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                internalCardRep2DArray.recordCalledNumber(rowID, colID);
                //internalCardRepWO2DArray.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                // Check for winner
                // Go here if player found the number called in his or her card
                // Check for winner for either internal representation
                 bingoCount2D = internalCardRep2DArray.isWinner(rowID, colID);
                //bingoCountWO2D = internalCardRepWO2DArray.isWinner(rowID, colID);
                if ((bingoCount2D == true))
                {
                    MessageBox.Show("You are a Winner!!", "Winner Found! \n"
                        + "Bingos count = " + bingoCount2D + ". Game over!");
                    Close();
                }  // end inner if

                playTheGame();
            }
            else
            {
                MessageBox.Show("Called number does not match the one in the box you selected."
                          + "Try again!", "Numbers Do Not Match");
            } // end outer if
        } // end button clickhandler 

        // Check user's name to make sure it's not blank using validateName method
        private void checkName()
        {
            string username = txtEnterNameHere.Text;
            Player.validateName(username);
        }

        // Method for playing game, the next called number will be matched with it's correct
        //letter, converted to a string, then printed out in the called number area
        private void playTheGame()
        {
            char nextChar;
            if (countOfCalledNumbers < MAXBINGONUMBER - 1)
            {

                countOfCalledNumbers++;
                nextCalledNumber = RNGObj.getNextUniqueRandomValue(1, MAXBINGONUMBER);
                usedNumber.setUsedNumber(nextCalledNumber);
                if (nextCalledNumber < 16)
                {
                    nextChar = 'B';
                }
                else if (nextCalledNumber > 15 && nextCalledNumber < 31)
                {
                    nextChar = 'I';
                }
                else if (nextCalledNumber > 30 && nextCalledNumber < 46)
                {
                    nextChar = 'N';
                }
                else if (nextCalledNumber > 45 && nextCalledNumber < 61)
                {
                    nextChar = 'G';
                }
                else 
                {
                    nextChar = 'O';
                }
                string nextVal = Convert.ToString(nextChar) + Convert.ToString(nextCalledNumber);
                lblCalledNumber.Text = nextVal;
            }
            else
            {
                usedNumber.setUsedNumber(0);
                MessageBox.Show("All numbers have been called, you have missed at least one called number.");
                Close();
            }
        }

        //Event handler for playing game
        private void btnYesPlay_Click(object sender, EventArgs e)
        {
            if (txtEnterNameHere.Text == "") //Makes sure name is not left blank
            {
                checkName();
            }
            else
            {
                createCard();
                playTheGame();
            }
          
        }

        //Event handler for not playing game
        private void btnNoPlay_Click(object sender, EventArgs e)
        {
            // exit game
            this.Close();
        }

        //Event handler for not having called number
        private void btnDontHave_Click(object sender, EventArgs e)
        {

            // Disable yes and no play buttons so user doesn't reset board
            btnYesPlay.Enabled = false;
            btnNoPlay.Enabled = false;
            // don't have so skip to next number
            playTheGame();

        }
    }
}
