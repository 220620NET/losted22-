using System;


//Methods
//1....define a function, remember to start with what you want your method to return
//2... method must have a name followed by opening and closing brackets
//3...method must have definition denoted by closing and opening curly braces
//4...lastly, for a function to run, you must call it by the name.
void SayHello()
{
    Console.WriteLine("Hello...tell us your name");
    var pharellInput = Console.ReadLine();  //collected user input and save it

    Console.WriteLine("Welcome " + pharellInput);
    Console.WriteLine();
}

int CollectUserGuess()
{
    Console.WriteLine("Please guess a number between 1-100 and you can only try 20 times");
    var userGuess = Convert.ToInt32(Console.ReadLine());

    return userGuess;
}

bool ValidateUserInput(int userNumber)
{
    if (userNumber < 1 || userNumber > 100)
    {
        return false;
    }
    return true;

}



SayHello();//call your function
var randGen = new Random();

var computerGuess = randGen.NextInt64(1, 101);
//Console.WriteLine("Compuer guess: " + computerGuess);

var guess = CollectUserGuess();
Console.WriteLine("user guessed " + guess);
Console.WriteLine();

var statusOfValidation = ValidateUserInput(guess);

if (statusOfValidation == false)
{
    Console.WriteLine(guess + " is not between 1-100! Start all over");
}
else
{
    var trial = 1;
    while (trial < 20)
    {
        if (guess > computerGuess)
        {
            Console.WriteLine("Number is too large");
            trial += 1;

        }
        else if (guess < computerGuess)
        {
            Console.WriteLine("Number is too small");
            trial += 1;
        }
        else if (guess == computerGuess)
        {
            Console.WriteLine("You guessed correctly!");
            break;
        }
        guess = CollectUserGuess();

    }
    if (guess == computerGuess)
    {
        Console.WriteLine("Congratulations! you got it after " + trial + " tries");
    }
    else
    {
        Console.WriteLine("Game over!...Computer guess was: " + computerGuess);
    }

}

