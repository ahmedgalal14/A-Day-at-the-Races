using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack
{
    class Bet
    {
        public int amount;
        public int dog;
        public Guy myGuy;

        // this constructor to initialize for each varibales
        public Bet(int amount, int dog, Guy Bettor)
        {
            this.amount = amount;
            this.dog = dog;
            this.myGuy = Bettor;   
        }

        // this constructer to initialze the Guy variable only
        // this used when we want to reset the default value of the 
        // textBox.text from getDescription(), and we need the Guy.name
        

        // this function is to return the word to show in the textBok.Text
         public string getDescription()
        {
            // default word
            if (amount == 0 )
            {
                string word2 = myGuy.name + " hasn't placed a bit !";                
                return word2;
            }
            // when bet occurs
            else
            {
                string word = myGuy.name + " bets " + amount + " on dog #" + dog;
                return word;
            }
        }

        // this function is ti compare between the winner dog and the number 
        // of the dog, and return + or - amount
        public int payOut(int winner)
         {
             if (dog == winner)
             {
                 return amount;
             }
             else
             {
                 return -amount;
             }
         }
    }
}
