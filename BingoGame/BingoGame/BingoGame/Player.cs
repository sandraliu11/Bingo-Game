using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Sandra Liu
// CIS 3309
// Feb 7, 2018

// Class Purpose: Makes sure the player's name is not left empty
namespace BingoGame
{
    class Player
    {

        //method to make sure user name is not blank
        internal static void validateName(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Your name cannot be left blank. Please Re-enter.");
            }

        }
    }
}
