using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Sandra Liu
// CIS 3309
// Feb 7, 2018

// Class Purpose: Checks the game for a win everytime player clicks a cell. 
namespace BingoGame
{
    class InternalCardType2DimArray
    {
        char[,] recordedNumbersArray = new char[5,5];

        // Constructor for type InternalCardType2DimArray object
        public InternalCardType2DimArray(int cardSize)
        {
            recordedNumbersArray[2, 2] = 'M';
        }  // end InternalCardType2DimArray


        //Records the numbers called
        public void recordCalledNumber(int row, int col)
        {
            recordedNumbersArray[row, col] = 'M';
        }

        //Checks for a bingo(if any number in the array hits 5)
        public bool isWinner(int row, int col)
        {
            //check rows for bingo
            int countRows = 0; //declares count of rows marked
            for (int i = 0; i <= 4; i++)
            {
                countRows = 0; //reset count to 0 after each row checked
                for (int j = 0; j <= 4; j++)
                {
                    if (recordedNumbersArray[j,i] == 'M')
                    {
                        countRows++;

                    }
                    if (countRows == 5)
                    {
                        return true;
                    }
                }
            }
            

            //check columns for bingo
            int countCols = 0; //declares count of columns marked 
            for (int i = 0; i <= 4; i++)
            {
                countCols = 0; //reset count to 0 after each column checked
                for (int j = 0; j <= 4; j++)
                {
                    if (recordedNumbersArray[i, j] == 'M')
                    {
                        countCols++;
                    }
                    if (countCols == 5)
                    {
                        return true;
                    }
                }
            }
            //check forward diagonal for bingo 
            int countFrontDiag = 0; //declares count of numbers in forward diagonal marked
            int k = 4; //cardsize of diagonal
            for (int i = 0; i <= 4; i++)
            {
                if (recordedNumbersArray[i, k] == 'M')
                {
                    countFrontDiag++;
                }
                if (countFrontDiag == 5)
                {
                    return true;
                }
                k--; //k decreases everytime i increases for frontwards diagonal check
            }

            //check backword diagonal for bingo
            int countBackDiag = 0; //declares count of numbers in back diagonal marked
            for (int i = 0; i <= 4; i++)
            {
                if (recordedNumbersArray[i,i] == 'M'){
                    countBackDiag++;
                }
                if (countBackDiag == 5)
                {
                    return true;
                }
            }
            return false;
        }
    }   
}
                            