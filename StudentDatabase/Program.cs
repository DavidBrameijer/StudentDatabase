using System.ComponentModel.Design;

string[] names = new string[]
{
    "Justin Jones",
    "DeAngelo Robinson",
    "Martina Basquez",
    "Alain Rene",
    "David Goodwin",
    "Joey Molinski",
    "Wren Grasley",
    "Brady Hartman",
    "David Brameijer",
    "Afseen Salam",
    "Ethan Thomas"
};

string[] hometowns = new string[]
{
    "Westerville",
    "Detroit",
    "Edinburg",
    "Homestead",
    "Jersey City",
    "Toledo",
    "Richmond",
    "Saranac",
    "Grand Rapids",
    "India",
    "Bolivar"
};

string[] favoriteFoods = new string[]
{
    "Baja Blast",
    "Pizza",
    "Leftovers",
    "Chicken Wings",
    "Sushi",
    "Dill Pickles",
    "Pizza",
    "Chicken Wings",
    "Tacos",
    "Shawarma",
    "Grapes"
};

bool runProgram = true;
while (runProgram == true)
{
    Console.WriteLine("Enter a student number. From 1 - 11.");
    int input = int.Parse(Console.ReadLine());
    int studNum = input - 1;

    if (studNum >= 0 && studNum <= names.Length - 1)
    {
        Console.WriteLine($" That student is {names[studNum]}");
        Console.WriteLine("Would you like to see their hometown or favorite food?");
        string answer = Console.ReadLine().ToLower();
        if (answer.Contains("home"))
        {
            Console.WriteLine($"{names[studNum]}'s hometown is {hometowns[studNum]}");
        }
        else if (answer.Contains("food"))
        {
            Console.WriteLine($"{names[studNum]}'s favorite food is {favoriteFoods[studNum]}");
        }
        else
        {
            Console.WriteLine("That is not an option. Please try again.");
            continue;
        }
    }
    else
    {
        Console.WriteLine("That is not a student numer, please try again.");
        continue;
    }
    runProgram = GetContinue();

}

static bool GetContinue()
{
    bool result;
    while (true)
    {
        Console.WriteLine("Would you like to search for another student? y/n");
        string answer = Console.ReadLine().ToLower();
        if(answer == "y" || answer == "yes")
        {
            result = true;
            break;
        }
        else if (answer == "n" || answer == "no")
        {
            result = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            continue;
        }
    }
    return result;
}