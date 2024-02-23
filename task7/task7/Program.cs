string input = Console.ReadLine();
int balance = 0;
while (balance <= 10)
{
    if (input == "@@@" || input =="###" || input == "$$$")
    {
        Console.WriteLine(balance++);
    }
    else 
    {
        Console.WriteLine(balance--);
        break;
    }
    
}