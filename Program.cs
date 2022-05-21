Console.Title = "True or False";

string[] questions = new string[]
{
    "Is 2 + 2 = 4?", "5 * 4 = 22?", "5 * 8 = 40?"
};

bool[] answers = new bool[]
{
    true, false, true
};

bool[] responses = new bool[answers.Length];
for (int i = 0; i < responses.Length; i++)
{
    Console.WriteLine(i);
}

int askingIndex = 0;
foreach (string question in questions)
{

    bool inputBool;
    bool isBool;
    Console.WriteLine(question);
    Console.Write("True or False? ");
    string input = Console.ReadLine();
    isBool = Boolean.TryParse(input, out inputBool);

    //will continue to loop while isBool == false
    while (!isBool)
    {
        Console.WriteLine("Input is not True or False");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

    }
}

//will give error if lengths of first two arrays are not the same
if (questions.Length != answers.Length) { Console.WriteLine("Error lengths are not the same"); };
