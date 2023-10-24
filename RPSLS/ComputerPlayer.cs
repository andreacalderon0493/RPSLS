using System;
namespace RPSLS
{
	internal class ComputerPlayer : Player 
	{
        public ComputerPlayer(string name) 
		{
			this.name = "R2D2";
            
        }
        public override void ChooseGesture()
		{
            //Get a random number, save it as a variable
            
            Random rnd = new Random();
            int randomNumber;

            randomNumber = rnd.Next(0, 4); // returns random integers >= 0 and < 4





            //Use that variable as your list index to grab value from this.gestures
            
            Console.WriteLine(gestures[randomNumber]);
            //set value to this.chosenGesture            //this.gestures;


        }

    }
}

