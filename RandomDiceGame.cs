namespace FreeCodeCamp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int sum = roll1 + roll2 + roll3;

            Console.WriteLine($"The first number{roll1}, second number{roll2}, third{roll3} and sum {sum}");

            if (sum > 10)
            {
                Console.WriteLine("You Win!");

            }
            else if (sum < 10)
                    {
                Console.WriteLine("You Lose!");
            }

             if ((roll1==roll2) || (roll1==roll3) || (roll2==roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to sum!");
                sum += 2;
            }
             if ((roll1==roll2) && (roll2==roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to sum!");
                sum += 6;
            }

            
          
        }
    }
}
