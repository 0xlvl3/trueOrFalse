Console.Title = "True or False";

//questions that will be asked in our program
string[] questions = new string[]
{
    "Is 2 + 2 = 4?", "5 * 4 = 22?", "5 * 8 = 40?"
};

//answers to those questions above
bool[] answers = new bool[]
{
    true, false, true
};

//these will be the users responses and will be == answers.length
bool[] responses = new bool[answers.Length];

for (int i = 0; i < responses.Length; i++)
{
    Console.WriteLine(i);
}

//asking index will be used to 
int askingIndex = 0;
//foreach loop to loop through questions
foreach (string question in questions)
{
    //variables to convert user input to bool values
    bool inputBool;
    bool isBool;
    //the loop
    Console.WriteLine(question);
    Console.Write("True or False? ");
    string input = Console.ReadLine();
    //isBool takes user input and out puts bool value
    isBool = Boolean.TryParse(input, out inputBool);

    //will continue to loop while isBool == false
    while (!isBool)
    {
        //loop will ask until we get bool value
        Console.WriteLine("Input is not True or False");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

    }
    //will help us store index to the corresponding questions
    responses[askingIndex] = inputBool;
    askingIndex++;


}

//values used to keep track of question number and total score of correct answers
int scoringIndex = 0;
int score = 0;

//loop for output given back to user on how well they did.
foreach (bool answer in answers)
{
    bool response = responses[scoringIndex];
    if (response == answer)
    {
        score++;
    }
    Console.Write($"\n{++scoringIndex }. Input:{response} | Answer:{answer}");
}
Console.WriteLine($"\nYou got a total of {score} answers correct, well done!");

//will give error if lengths of first two arrays are not the same
if (questions.Length != answers.Length) { Console.WriteLine("Error lengths are not the same"); };



