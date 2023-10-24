namespace RPSLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();

            ComputerPlayer computerPlayer = new ComputerPlayer("");
            computerPlayer.ChooseGesture();
            HumanPlayer humanPlayer = new HumanPlayer("");
            humanPlayer.ChooseGesture();
        }
    }
}