using System;
using System.Threading;

namespace rock_paper_scissors_
{
    class Program
    {
        static void WinBeep(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("You Win!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Beep(200,250);
            Console.Beep(250,250);
            Console.Beep(300,250);
            Console.Beep(250,250);
            Console.Beep(200,250);
            Console.Beep(250,250);
            Console.Beep(400,250);
        }
        static void LoseBeep(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You Lose!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Beep(400,250);
            Console.Beep(250,250);
            Console.Beep(200,250);
            Console.Beep(250,250);
            Console.Beep(300,250);
            Console.Beep(250,250);
            Console.Beep(200,250);
        }
        static void TieBeep(){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Its a tie!!!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Beep(200,250);
            Console.Beep(200,250);
            Console.Beep(200,250);
            Console.Beep(200,250);
            Console.Beep(200,250);
            Console.Beep(200,250);
            Console.Beep(200,250);
        }
        static void Main(string[] args)
        {
            Console.Clear();
            bool playable = true;
            while(playable)
            {
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@" 
  _____            _      _____                         _____      _                        
 |  __ \          | |    |  __ \                       / ____|    (_)                       
 | |__) |___   ___| | __ | |__) |_ _ _ __   ___ _ __  | (___   ___ _ ___ ___  ___  _ __ ___ 
 |  _  // _ \ / __| |/ / |  ___/ _` | '_ \ / _ \ '__|  \___ \ / __| / __/ __|/ _ \| '__/ __|
 | | \ \ (_) | (__|   <  | |  | (_| | |_) |  __/ |     ____) | (__| \__ \__ \ (_) | |  \__ \
 |_|  \_\___/ \___|_|\_\ |_|   \__,_| .__/ \___|_|    |_____/ \___|_|___/___/\___/|_|  |___/
                                    | |                                                     
                                    |_|                                                     
          
            ");
            
System.Console.WriteLine("Type Rock, Paper, Scissors, Lizard, or Spock to play!");
Random random = new Random();
int randoInt = random.Next(1,6);
System.Console.WriteLine(randoInt);
string play = Console.ReadLine().ToLower();
switch(play){
    case "rock":
    case "paper":
    case "scissors":
    case "lizard":
    case "spock":
    break;
    default:
    System.Console.WriteLine($"Oopsy daisy! {play}, ain't gonna fly hoss. Let's try that again.");
    Thread.Sleep(3500);
    Console.Clear();
    continue;
}
System.Console.WriteLine($"You play {play}");
string computer = "";
switch(randoInt){
    case 1:
    computer = "rock";
    break;
    case 2:
    computer = "paper";
    break;
    case 3:
    computer = "scissors";
    break;
    case 4:
    computer = "lizard";
    break;
    case 5:
    computer = "spock";
    break;
}
System.Console.WriteLine($"Computer plays {computer}");
bool skip = true;
if(play == computer)
{
   TieBeep();
   skip = false;
};
if (skip)
{
switch(play)
{
case "rock":
if (computer == "paper" || computer == "spock")
{
    LoseBeep();
} else
{
WinBeep();
}
break;
case "paper":
if (computer == "scissors" || computer == "lizard")
{
    LoseBeep();
} else
{
WinBeep();
}
break;
case "scissors":
if (computer == "rock" || computer == "spock")
{
    LoseBeep();
} else
{
WinBeep();
}
break;
case "lizard":
if (computer == "scissors" || computer == "rock")
{
    LoseBeep();
} else
{
WinBeep();
}
break;
case "spock":
if (computer == "lizard" || computer == "paper")
{
    LoseBeep();
} else
{
WinBeep();
}
break;
}
}
System.Console.WriteLine(@"Good Game!
Would you like to play again? y/n");
            string noYes = System.Console.ReadLine().ToLower();
            if (noYes == "y" || noYes == "yes")
            {
                 Thread.Sleep(500);
                Console.Clear();
                continue;
            }else if (noYes == "n" || noYes == "no")
            {
                 Thread.Sleep(500);
                Console.Clear();
                break;
            } else
            {
                System.Console.WriteLine($"I'm not sure what you meant by {noYes}, but I bet you want to keep playing!");
                Thread.Sleep(3500);
               Console.Clear();
                continue;
            }
            }
        }
    }
}