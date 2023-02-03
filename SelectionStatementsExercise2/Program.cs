namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var schoolSubject =(Console.ReadLine());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");

            switch (schoolSubject.ToLower())
            {
                case "history":
                    Console.WriteLine("Those who don't know history are doomed to repeat it, " +
                        "especially software engineers");
                    break;

                case "algebra":
                    Console.WriteLine("Gotta know how to do math");
                    break;

                case "english":
                    Console.WriteLine("Me fail english? Thats unpossible");
                    break;

                case "science":
                    Console.WriteLine("Science invented the very computer you're typing on");
                    break;

                case "lunch":
                    Console.WriteLine("That was always my best subject");
                    break;

                default:
                    Console.WriteLine($"Yeah im not too sharp on {schoolSubject}");
                    break;
                   

            }
        }
    }
}