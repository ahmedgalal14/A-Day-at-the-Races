using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RaceTrack
{
    class Greyhound
    {
        // the value of the start point
        public int startingPosition = 12;   

        public int raceTrackLength = 460; 
        // to store dogs object here
        public PictureBox myPictureBox = null;
        Random randomizer;


        // constructor, to make myPictureBox = dog1, dog2 ... etc
        public Greyhound(PictureBox my_dog)
        {
           this.myPictureBox = my_dog;            
        }      
       
        // this function to move the dogs & return true when any dog is win 
        // any false when noone is win
        public bool run()
        {
            randomizer = new Random();
            int distance = randomizer.Next(1, 20);
            // to take the location of dogs to update it
            Point p = myPictureBox.Location;
                
                // check, if the any dog reach to the end
            if (p.X >= raceTrackLength)
                {
                    MessageBox.Show("The winner is : #" + myPictureBox.Name);
                    return true;
                }
                else
                {  
                    // update the location by adding the random variable
                    p.X += distance;
                    myPictureBox.Location = p;
                    // to refresh the GUI when sleep occured
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                    return false;
                }
        }

        //public void beforeRacing()
        //{
        //    randomizer = new Random();
        //    Point p = myPictureBox.Location;
        //    p.X += randomizer.Next(1, 10);
        //    myPictureBox.Location = p;
        //}

        // this function is to return all dogs to the start position
        public void takeStartingPostion() 
        {
            myPictureBox.Left = startingPosition;
        }

    }
}
