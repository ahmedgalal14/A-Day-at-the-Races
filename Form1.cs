using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RaceTrack
{
    public partial class Form1 : Form
    {   
        // create array of objects from the Greyhound
        Greyhound[] dogs = new Greyhound[4];
        //public bool before = false;

        // create array of objects from the Guy
        Guy[] guys = new Guy[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create object from Greyhound class and
            // define each dogs to the myPictureBoc in Greyhound
            dogs[0] = new Greyhound(dog1);
            dogs[1] = new Greyhound(dog2);
            dogs[2] = new Greyhound(dog3);
            dogs[3] = new Greyhound(dog4);
            
            /////////////////////////////////////////////////////////////////

            // create object from Guy class and
            // define the name and cashe of each guys in Guy
            guys[0] = new Guy("Joe", 50, JoeRadio, JoeLabel);
            guys[1] = new Guy("Bob", 75, BobRadio, BobLabel);
            guys[2] = new Guy("Al", 45, AlRadio, AlLabel);

            /////////////////////////////////////////////////////////////////
            // to give initialization value of the Radio.Text
            guys[0].updateLabel();
            guys[1].updateLabel();
            guys[2].updateLabel();

            /////////////////////////////////////////////////////////////////
            // to give initialization value of the Label.Text
            // and give initial value is zero to show the initial text
            guys[0].placeBit(0, 0);
            guys[1].placeBit(0, 0);
            guys[2].placeBit(0, 0);
            
            /////////////////////////////////////////////////////////////////
            // the enable of this button is false during there isn't
            // any radioButton checked
            BetsButton.Enabled = false;

        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            //before = true;
            bool b = false;
            // this loop is about racing, and this will stop 
            // when the run() return true only           
            while (!b)
            {
                // to move each dog one step
                for (int i = 0; i < 4; i++)
                {
                  b =  dogs[i].run();
                    
                    // check if the any dog reach to the final
                    if (b)
                    {
                        // to know which dog is winner
                        int winnerDog = i + 1;
                        win(winnerDog);
                        reset();
                        break;
                    }
                }
            }
            //before = false;
        }
       
        // this function is to tell collect() in Guy class
        // which dog is winner
        public void win(int winner)
        {
            for (int i = 0; i < 3; i++)
            {
                // send all dogs, winner dog and lose dog
                // to add or minus the amount
                guys[i].collect(winner);               
            }

        }

        // this function is to call the takeStartingPostion() in Greyhound
        // to reset the position of all dogs
        public void reset()
        {
            for (int i = 0; i < 4; i++)
            {
                // send one object after one to reset position
                dogs[i].takeStartingPostion();
            }
        }

         private void BetsButton_Click(object sender, EventArgs e)
        {
             // to take the value from the GUI in the variable
            int BuckValue = Convert.ToInt32(upDown_amount.Value);
            int dogReq = Convert.ToInt32(upDown_dog.Value);

            // if checked radio button, the the text of the textbox
            // will be changed to the bet
            if (JoeRadio.Checked)
            {
                guys[0].placeBit(BuckValue, dogReq);
                JoeLabel.BackColor = Color.FromArgb(224, 224, 224);
                //beforeRacing();
            }
            if (BobRadio.Checked)
            {
                guys[1].placeBit(BuckValue, dogReq);
                BobLabel.BackColor = Color.FromArgb(224, 224, 224);
               // beforeRacing();
            }
            if (AlRadio.Checked)
            {
                guys[2].placeBit(BuckValue, dogReq);
                AlLabel.BackColor = Color.FromArgb(224, 224, 224);
                //beforeRacing();
            }
        }

        // this to set the name of the label before bet button
        // and enable the betButton
        // and the same for each next one
         private void JoeRadio_CheckedChanged(object sender, EventArgs e)
         {
             guyName.Text = guys[0].name;
             BetsButton.Enabled = true;
         }

         private void BobRadio_CheckedChanged(object sender, EventArgs e)
         {
             guyName.Text = guys[1].name;
             BetsButton.Enabled = true;
         }

         private void AlRadio_CheckedChanged(object sender, EventArgs e)
         {
             guyName.Text = guys[2].name;
             BetsButton.Enabled = true;
         }

         private void AboutButton_Click(object sender, EventArgs e)
         {
             string groupName = "Group 25";
             string boyName = "Ahmed Galal, Mohamed Elmansy, Mahmoud Farid";
             string girlName = "Asmaa Ismail, Radwa AbdElMenam, Rana Magdy";
             MessageBox.Show(groupName + "\n" +boyName + "\n" +girlName );
         }

         private void upDown_amount_ValueChanged(object sender, EventArgs e)
         {

         }

         private void groupBox1_Enter(object sender, EventArgs e)
         {

         }

        //public void beforeRacing()
        // {
        //     while (!before)
        //     {
        //         for (int i = 0; i < 4; i++)
        //         {
        //             dogs[i].beforeRacing();
        //             Application.DoEvents();
        //             System.Threading.Thread.Sleep(50);
        //             reset(); 
        //         }
                
                 
        //     }
        // }

    }
}

