namespace SelectionStatementsExercise2
{
    public class Program
    {
        //Only a single URL can be submitted, so both Exercise #1 and Exercise #2 are included below
        static void Spacer()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            //Establish Favorite
            int favNumber = MakeFavoriteNum();
            int userInput = 0;
            string userInput2;
            int exerciseDone = 3;
            //Exercise #1 - 29:00
            if (exerciseDone != 2)
            {
                Console.WriteLine("Guess my favorite number:");
                while (userInput != favNumber)
                {
                    userInput = GuessFavoriteNum(favNumber);
                }
            }
            if (exerciseDone != 1 && exerciseDone != 2) Spacer();
            //Exercise #2
            if (exerciseDone != 1)
            {
                Console.WriteLine("Name your favorite subject:");
                userInput2 = Console.ReadLine();
                JudgeSubject(userInput2);
            }
        }
        //Exercise #1
        static int MakeFavoriteNum()
        {
            var r = new Random();
            int favNumber = r.Next(1, 1000);
            return favNumber;
        }
        static int GuessFavoriteNum(int target)
        {
            int userInput = 0;
            userInput = int.Parse(Console.ReadLine());
            if (userInput > target)
            {
                Console.WriteLine("Too high!");
            } else if (userInput < target)
            {
                Console.WriteLine("Too low!");
            } else if (userInput == target)
            {
                Console.WriteLine("You guessed it!!!");
            }
            return userInput;
        }
        //Exercise #2
        static void JudgeSubject(string subject)
        {
            switch (subject.ToLower())
            {
                case "english":
                    Console.WriteLine("Studying a language you already speak seems ambitious!");
                    break;
                case "science":
                    Console.WriteLine("Biology? Chemistry? Physics? Your lack of specificity is not convincing.");
                    break;
                case "math":
                    Console.WriteLine("I bet you are a lot of fun at parties...");
                    break;
                case "history":
                    Console.WriteLine("I sense museum work in your future.");
                    break;
                case "art":
                    Console.WriteLine("Ah, I see you have excellent job prospects!");
                    break;
                default:
                    Console.WriteLine("I genuinely know nothing about that, but good luck!");
                    break;
            }
            /*if (subject != "English" && subject != "Science" && subject != "Math" && subject != "History" && subject != "Art")
            {
                Console.WriteLine("I genuinely know nothing about that, but good luck!");
            }*/
        }
    }
}