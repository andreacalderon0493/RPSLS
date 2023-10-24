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
			Console.WriteLine("Please choose a gesture of the following below ");
			foreach (var gesture in gestures)
			{
				Console.WriteLine(gesture);
            }
            string chosenGesture = Console.ReadLine();

        }
    }
}

