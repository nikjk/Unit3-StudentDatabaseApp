// Creation of Student Name Array.

string[] studentNames = new string[5];
studentNames[0] = "Jennifer Lawrence";
studentNames[1] = "Zendaya";
studentNames[2] = "Anne Hathaway";
studentNames[3] = "Meryl Streep";
studentNames[4] = "Taraji P. Henson";

// Creation of Student Hometown Array.
string[] studentHometown = new string[5];
studentHometown[0] = "Indiana Hills, Kentucky";
studentHometown[1] = "Oakland, California";
studentHometown[2] = "Brooklyn, New York";
studentHometown[3] = "Summit, New Jersey";
studentHometown[4] = "Washington, D.C.";

// Creation of Student Favorite Food Array.
string[] studentFavoriteFood= new string[5];
studentFavoriteFood[0] = "Lasagna";
studentFavoriteFood[1] = "Burritos";
studentFavoriteFood[2] = "Vegetarian Egg Rolls";
studentFavoriteFood[3] = "Pizza";
studentFavoriteFood[4] = "Gummi Bears";

bool runAgain = false;


do
{
    Console.Write("Welcome! Which student would you like to learn more about? Enter a number 1-" + studentNames.Length + " or 0 to list all students:");
    int studentNumber = int.Parse(Console.ReadLine());
    
    if (studentNumber > studentNames.Length)
    {
        do
            {
                Console.WriteLine("That number is too large. Please choose again.");
                studentNumber = int.Parse(Console.ReadLine());

            } while (studentNumber > studentNames.Length);
    }
    

    Console.WriteLine("\n");

    if (studentNumber != 0)
    {
        Console.WriteLine($"Student " + studentNumber + " is " + studentNames[studentNumber - 1] + ". What would you like to know? Enter 'hometown' or 'favorite food' or 'ls' to list all students:");

        string userInput = Console.ReadLine();


        if (userInput.ToLower() == "hometown")
        {
            Console.WriteLine(studentHometown[studentNumber - 1]);
        }

        else if (userInput.ToLower() == "favorite food" || userInput.ToLower() == "fave food")
        {
            Console.WriteLine(studentFavoriteFood[studentNumber - 1]);
        }

        Console.WriteLine("Would you like to learn about another student? (y/n)");

        string goAgain = Console.ReadLine();
        if (goAgain.ToLower() == "y" || goAgain.ToLower() == "yes")
        {
            runAgain = true;
        }
        else
        {
            runAgain = false;
        }

    }

    if (studentNumber == 0)
    {
        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {studentNames[i]}" + ", " + studentHometown[i] + ", " + studentFavoriteFood[i] + "\n");
        }


        Console.WriteLine("\n");
        runAgain= false;  
    }

} while (runAgain == true);


Console.WriteLine("Thanks!");
