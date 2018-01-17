using System;

namespace FirstApplication
{
    class RPSGame
    {
        static void Main(string[] args)
        {
            String MenuChoice;
            again:
            Console.Clear();
            again1:
            Console.WriteLine("\n\t ROCK-PAPER-SCISSOR");
            Console.WriteLine("\t 1.PLAY");
            Console.WriteLine("\t 2.RULES");
            Console.WriteLine("\t 3.EXIT");
            MenuChoice=Console.ReadLine();
            switch(MenuChoice)
            {
                case "1": RPSGame obj = new RPSGame();
                          obj.Result();
                          goto again;
                case "2": Console.Clear();
                          Console.WriteLine("General Rules of the GAME are: \n 1.Rock Beats Scissors\n 2.Paper Beats Rock\n 3.Scissors Beat Paper");
                          Console.WriteLine("\n Enter any key to go back");
                          Console.ReadLine();
                          goto again;
                case "3": Console.Clear();
                          Environment.Exit(-1);
                          break;
                default: Console.WriteLine("Wrong Option.. Try Again");
                         goto again1;
            }
        }
             public void Result()
        {
            int UserChoiceI,CompChoice,UserScore=0,CompScore=0;
            String UserChoiceS;
            int i=1;
            for(i=1;i<4;i++)
            {
                Console.Clear();
                goback: 
                Console.WriteLine("\nRound : {0}",i);
                Console.WriteLine("Make a Choice:\n1.Rock 2.Paper 3.Scissor 4.Main Menu");
                UserChoiceS=Console.ReadLine();

                switch(UserChoiceS)
                {
                    case "1":Console.WriteLine("You Choose Rock");
                           break;
                    case "2":Console.WriteLine("You Choose Paper");
                           break;
                    case "3":Console.WriteLine("You Choose Scissor");
                           break;
                    case "4": return;
                    default:Console.WriteLine("Wrong Input! Enter Again");
                           goto goback;
                }   

                UserChoiceI=Convert.ToInt32(UserChoiceS);
                Random r = new Random();
                CompChoice=(r.Next(1,100))%3;

                switch(CompChoice)
                {
                    case 0:Console.WriteLine("Computer Choose Rock");
                           break;
                    case 1:Console.WriteLine("Computer Choose Paper");
                           break;
                    case 2:Console.WriteLine("Computer Choose Scissor");
                           break;
                }

                int temp = (UserChoiceI-(CompChoice+1));
                if(temp==0)
                {
                    Console.WriteLine("It's a DRAW");
                    Console.WriteLine("Score: \t YOU: {0} \t COMPUTER: {1} \n Press Enter to Continue",UserScore,CompScore);
                    Console.ReadLine();
                }
                else if(temp==1 || temp==-2)
                {
                    Console.WriteLine("You WIN this Round");
                    UserScore++;
                    Console.WriteLine("Score: \t YOU: {0} \t COMPUTER: {1} \n Press Enter to Continue",UserScore,CompScore);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You LOSE this Round");
                    CompScore++;
                    Console.WriteLine("Score: \t YOU: {0} \t COMPUTER: {1} \n Press Enter to Continue",UserScore,CompScore);
                    Console.ReadLine();
                }   
            }
            if(UserScore>CompScore)
            {
                Console.WriteLine("\n\nYOU WIN :)");
                Console.ReadLine();
            }
            else if(UserScore<CompScore)
            {
                Console.WriteLine("\n\nYOU LOSE :(");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\nIT's a TIE.");
                Console.ReadLine();
            }
        }
    }
}
