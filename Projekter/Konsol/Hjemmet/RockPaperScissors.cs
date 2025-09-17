namespace Hjemmet
{
    public class RockPaperScissors
    {
        public void Start()
        {
         Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                Console.Clear();
                Console.WriteLine("Rock, Paper, Scissors Game!");
                Console.WriteLine("Choose [R]ock, [P]aper, or [S]cissors:");
                player = Console.ReadLine().ToUpper();
                int computerChoice = random.Next(1, 4);
                switch (computerChoice)
                {
                    case 1:
                        computer = "R";
                        break;
                    case 2:
                        computer = "P";
                        break;
                    case 3:
                        computer = "S";
                        break;
                    default:
                        computer = "R"; // Default case, should not occur
                        break;
                }
                Console.WriteLine($"Computer chose: {computer}");
                if (player == computer)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((player == "R" && computer == "S") ||
                         (player == "P" && computer == "R") ||
                         (player == "S" && computer == "P"))
                {
                    Console.WriteLine("You win!");
                }
                else if ((player == "R" && computer == "P") ||
                         (player == "P" && computer == "S") ||
                         (player == "S" && computer == "R"))
                {
                    Console.WriteLine("Computer wins!");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please choose R, P, or S.");
                }
                Console.WriteLine("Do you want to play again? (Y/N)");
                answer = Console.ReadLine().ToUpper();
                playAgain = (answer == "Y");
            }
        }
    }
}
