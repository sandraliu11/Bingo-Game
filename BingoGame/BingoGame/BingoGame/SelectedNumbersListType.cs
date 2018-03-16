using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Sandra Liu
// CIS 3309
// Feb 7, 2018

// Class purpose: Sets and checks if a number is in the used numbers array so it is not used again
namespace BingoGame
{
    public class SelectedNumbersListType
    {  
        RNGType rng = new RNGType();
        int[] usedNumbersArray = new int[76]; // declare array of size 75

        // create selectedNumbersListObj object
        public SelectedNumbersListType()
        {
            for (int i = 0; i < 76; i++)
            {
                usedNumbersArray[i] = 0;
            }
        }

        // method to reset used number array
        public void reset()
        {
            for (int i = 0; i < 76; i++)
            {
                usedNumbersArray[i] = 0;
            }
        }

        //method to check if number called is used already 
        //by seeing if it's in the array of used numbers
        public bool isUsedNumber(int r)
        {
                if (usedNumbersArray[r] == 1)
                {
                    return true;
                }
            return false;
        }

        // method to insert newly used numbers to the usedNumbersArray
        public void setUsedNumber(int r)
        {
            usedNumbersArray[r] = 1;
        }
            
    }
}
