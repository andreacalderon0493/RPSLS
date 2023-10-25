using System;
namespace RPSLS
{
	internal class HumanPlayer : Player 
	{

		public HumanPlayer(string name)
		{
			this.name = name;
			

		}

        public override void ChooseGesture()
        {
			Console.WriteLine($"{this.name} Please choose a gesture of the following below ");
			foreach (var gesture in gestures)
			{
				Console.WriteLine(gesture);
                
            }
            chosenGesture = Console.ReadLine();
			chosenGesture = chosenGesture.ToLower(); 

        }
    }
}

