// See h Console.WriteLine(quiz.Questions);ttps://aka.ms/new-console-template for more information


using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

        Test quiz = new Test
        {
            Questions = "What is the capital of France?",
            Options = { "Berlin", "Madrid", "Paris", "Rome" },
            CorrectAnswerIndex = 2
        };

        Console.WriteLine(quiz.Questions);
        Console.WriteLine();
        // Display options properly
        for (int i = 0; i < quiz.Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {quiz.Options[i]}");
        }

        Console.WriteLine("Answer 1-4");

        string? input = Console.ReadLine();
        if (int.TryParse(input, out int answer) && answer - 1 == quiz.CorrectAnswerIndex)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is: " + quiz.Options[quiz.CorrectAnswerIndex]);
        }



        Identity person = new Identity
        {
            FirstName = "John",
            LastName = "Spade",
            Age = 15,
            Sex = "Male"


        };
        //Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age},Sex : {person.Sex}");
        Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Sex: {person.Sex}");
        if (person.Age >= 18)
        {
            Console.WriteLine($"{person.FirstName} is an adult");
        }
        else
        {
            Console.WriteLine($"{person.FirstName} is minor");
        }

        Vehicles car = new Vehicles
        {
            Question1 = "Which is the fastest car?",
            Question2 = "Which is the fastest driver?",

             CarOptions = { "Toyota", "Benz", "Volswagen", "Ford", "Volvo"},
              DriverOptions = { "Ken", "Oz", "Mizer", "Shun", "Phil" },
               CorrectCarIndex = 1,
                CorrectDriverIndex = 3

        };
        Console.WriteLine(car.Question1);
        Console.WriteLine();
        for (int i = 0; i < car.CarOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{car.CarOptions[i]}");
        }

        Console.WriteLine("Answer 1-5");

        string? choice = Console.ReadLine();
        if (int.TryParse(choice, out int selected) && selected - 1 == car.CorrectCarIndex) 
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct vehicle is: " + car.CarOptions[car.CorrectCarIndex]);
        }
        // for driver question
        Console.WriteLine(car.Question2);
        Console.WriteLine();
        for (int i = 0; i < car.DriverOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{car.DriverOptions[i]}");
        }
        Console.WriteLine("Answer 1-5");

        string? driverChoice = Console.ReadLine();
        if (int.TryParse(driverChoice, out int selectedDriver) && selectedDriver - 1 == car.CorrectDriverIndex)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct driver is: " + car.DriverOptions[car.CorrectDriverIndex]);
        }
        Console.WriteLine("*****************************************************************************************************");
        Console.WriteLine( );
        Console.WriteLine("Many thanks! This is the end of the quiz. ");
        Console.WriteLine( "Please press any key to exit the application");
        Console.ReadKey();

    }
}



