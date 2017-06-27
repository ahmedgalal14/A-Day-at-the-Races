using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace RaceTrack
{
    class Guy
    {
        public string name;
        public int cashe;
        public Bet myBet;
        public RadioButton myRadio;
        public TextBox myLabel;


        public Guy(string name, int cashe, RadioButton myRadio, TextBox myLabel)
        {
            this.name = name;
            this.cashe = cashe;
            this.myRadio = myRadio;
            this.myLabel = myLabel;
            
        }

        // this function is to update the RadioButton.Text
        public void updateLabel()
        {
            myRadio.Text = name + " has " + cashe + " Bucks ";
        }

        // this function is to reset the default text of the textbox
        // when the race is finished
        public void clearBit()
        {
            // pass the guy object, to know his name in getDescription()
            myBet = new Bet(0, 0, this);
            myLabel.Text = myBet.getDescription();
        }

        // this function is to compare between amount & cashe
        // and update the Label.Text
        public bool placeBit(int amount, int dog)
        {
            
            if (amount <= cashe)
            {
                // to make initialization value of myBet by parameters value
                myBet = new Bet(amount, dog, this);
                // to update Label.Text
                myLabel.Text = myBet.getDescription();
                return true;  
            }
            else
            {
                myBet = new Bet(0, dog, this);
                myLabel.Text = myBet.getDescription();
                return false;
            }
            
        }

        // to change the cashe value by increasing or decreasing by payOut()
        // this parameter is refer to the winner dog
        public void collect (int winner)
        {
            cashe += myBet.payOut(winner);
            // to change the the cashe of radioButton text
            updateLabel();
            // to reset the default value of textbox when the race is finished
            clearBit();

        }


    }
}
