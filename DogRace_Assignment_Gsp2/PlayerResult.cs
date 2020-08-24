using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace_Assignment_Gsp2
{
   public class PlayerResult
    {
        //reset the account balance of the player after playing the game 
        public int balancePlayer(String details,int Winner,int Account) {
            string []data = details.Split(' ');
            int Dog = Convert.ToInt32(data[3]);
            int Amunt = Convert.ToInt32(data[7]);
            if (Dog == Winner)
            {
                Account = Account + Amunt;
                return Account;
            }
            else {
                Account = Account - Amunt;
                return Account;
            }
            
        }
    }
}
