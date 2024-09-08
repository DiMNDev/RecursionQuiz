// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("____________________..rEcUrSiOn Is BeTtEr.._______________________________");
string mockBob = """
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⢯⡙⠳⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡁⠀⠀⠀⠙⣆⠹⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣇⠀⣀⠀⠀⠘⣦⠹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⡄⠸⣇⡀⠀⠘⢧⡹⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣄⠙⣇⠀⡀⠈⠳⡽⣆⠀⠀⠀⠀⠀⢀⣀⡀⠀⠀⠀⣀⣀⣀⣀⣀⠀⣀⣠⣤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠖⠲⣦⣤⣿⣶⠻⠗⠃⠀⠀⢹⣾⡟⠲⣶⣖⣞⠋⠉⠉⠛⠒⣻⣿⣷⣦⡉⠙⠛⠉⣠⠞⠛⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢀⣀⣴⡾⠁⠘⣿⣿⣿⣿⣿⣿⣄⡀⣀⣠⣾⣿⣷⡄⠙⣿⣿⣷⣤⣤⣄⡀⠈⠙⠛⠛⠁⠀⣠⠞⠁⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣀⣴⠟⠁⠀⠀⠀⠀⢸⣿⣿⣦⠀⠀⣸⣿⡿⠟⠛⢹⣿⠃⠐⢿⣿⣿⣿⣿⣿⠟⠀⠀⠀⠀⣠⠼⠃⠀⠀⠀⠀⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣴⡿⠿⢦⣀⣀⡤⠶⠷⠶⠬⣉⡉⣹⡶⠟⠋⠁⠀⢀⣴⣿⠏⠠⢤⣠⣤⠾⠟⠛⡶⠤⠤⠤⠴⠾⡅⠀⠀⢀⣴⣶⣦⠘⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠂⠹⣧⡀⣶⣶⣶⡆⠀⠀⠀⠀⠀⠀⢿⣷⣤⣤⣴⣶⣿⠿⠋⠀⠀⠀⠀⠀⣀⣤⠾⢿⣷⣀⡀⠀⠀⣿⠀⢠⣿⣿⣿⣿⡇⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⠀⠀
⠀⠀⠈⢹⣿⡭⠙⣿⠀⢠⡀⠀⠀⠀⠀⠉⠙⠛⠋⠉⠁⠀⠀⠀⠀⠀⡴⠛⠉⣷⡀⢠⣧⠈⠙⠂⠀⣿⠀⠸⣿⣿⣿⣿⠃⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠛⢻⡇⠀⠀⠀⠀
⠀⠀⢠⡾⣿⣴⠾⠛⠓⠛⠿⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⡶⠚⠛⠛⠛⠛⠲⣤⡀⠀⢻⡄⠀⠘⠛⠛⠁⠀⠀⠳⣄⠀⠀⠀⢀⣀⡀⣀⡴⠛⣵⠀⣸⡇⠀⠀⠀⠀
⠀⠀⢻⡿⣫⣤⣤⣄⡀⠀⠀⠀⢻⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠁⠀⠀⠀⠀⣤⣤⣤⠈⢿⠀⠀⠙⢦⠀⠀⢠⣴⣿⣇⠀⢹⣆⣠⠟⠉⠀⠉⠻⣤⠟⣽⠀⣿⠀⣠⣤⣀⠀
⠀⠀⢸⡃⣿⣿⣷⢌⡷⠀⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠁⠀⠀⠀⠀⢾⣿⣿⣮⣷⣼⠀⠀⠀⠸⡇⠀⠀⠸⡿⠃⠀⢸⣿⠁⠀⠀⠀⠀⠀⣿⠀⡿⠀⣿⣸⣿⢏⣿⡦
⠀⠀⠘⢧⡙⠻⠿⠛⠁⠀⠀⢀⡾⠁⣀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠘⢧⡀⠀⠀⠀⠈⠻⣿⣿⣯⠟⠀⠀⠀⠀⡇⠀⠀⠀⠀⢀⣠⣾⠁⠀⠀⠀⠀⢀⣤⠋⢀⡇⢀⣿⣿⡟⣼⢁⣿
⠀⠀⠀⠈⠹⢦⣄⣀⣀⡤⠶⠋⣀⡴⠋⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⣶⠶⠶⠶⢛⣉⣥⠆⠀⠀⢀⠀⠹⣄⠀⠀⢠⣾⣿⡇⠀⠀⢀⣀⣶⣿⣷⣶⣿⡇⠸⣋⡤⠘⠃⣼⠇
⠀⠀⠀⠀⠀⠀⠙⢻⣏⣀⣴⠞⠋⠀⢠⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠓⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠈⢳⡀⢸⣿⣿⣿⡶⠒⠛⠛⢿⣿⣿⣿⣿⣧⠀⠟⠁⣠⣾⠁⠀
⠀⠀⠀⠀⠀⠀⣴⠟⠋⠁⠀⠀⠀⣠⠟⠀⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠈⠻⠿⠋⠀⠀⣤⣄⠀⢹⠏⠀⠸⣿⣿⣶⣿⣿⣿⡆⠀
⠀⠀⠀⠀⠀⠀⠻⣇⣀⣀⣠⣤⠞⠁⠀⠘⠛⠀⠀⠀⠀⠀⢀⣤⣴⣶⣿⣿⣿⣿⣶⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠦⣄⠀⠀⠀⠘⣿⣿⠀⠸⣆⠀⠀⢿⣿⣿⣿⣿⣿⣿⡆
⠀⠀⠀⠀⠀⠀⠀⠈⠉⠙⡿⠁⠀⠀⠀⠀⠀⠀⠀⢀⣴⣾⣿⣿⣿⣿⡿⠿⠟⠛⠋⠉⣀⠀⠀⠀⣠⣴⣶⣶⣶⣦⣤⠀⠀⠈⢧⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠘⣿⣿⣿⣿⡿⠿⠉
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣇⠀⠀⠀⠀⠀⠀⢀⣴⢿⣿⡿⠟⠋⠉⣁⣀⣠⡤⠶⠶⠛⠉⠀⠀⠀⠻⠿⠿⠿⠿⠟⠋⢀⡀⠀⠘⢧⣠⣀⡀⠀⠀⠀⣿⠀⠀⠀⣿⡿⠛⠉⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⣰⢿⡿⠛⢉⣲⣶⣶⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡿⠀⠀⠀⠈⠹⠶⡶⢶⡘⣦⡴⠖⠋⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⠀⠀⠀⣰⠇⠈⠛⠛⠉⠁⠀⠈⠙⠓⣶⣤⣤⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⣀⣠⣤⣤⣤⣶⣾⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢷⡀⢠⠏⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⠟⠉⠙⠛⠛⠛⠛⠛⠛⠋⠉⠉⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣽⠟⢋⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⢿⡏⢹⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣞⢁⣾⣟⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡎⢀⣿⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⣿⣿⡛⠦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣇⣸⣷⣦⣀⣀⣠⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣷⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠿⣿⣀⠉⢻⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⠿⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⡿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠻⠿⠿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
""";
Console.WriteLine(mockBob);

int inputValue = 40;

Stopwatch recursionStopwatch = new Stopwatch();
recursionStopwatch.Start();
int recursionMethodNumber = fibonacciRecursionMethod(inputValue);
recursionStopwatch.Stop();

Stopwatch standardMethodStopwatch = new Stopwatch();
standardMethodStopwatch.Start();
int standardMethodNumber = fibonacciStandardMethod(inputValue);
standardMethodStopwatch.Stop();

Console.WriteLine($"Recursive Method Output: {recursionMethodNumber}");
Console.WriteLine($" The recursion method completed in: {recursionStopwatch.ElapsedMilliseconds}");
Console.WriteLine($"Standard Method Output: {standardMethodNumber}");
Console.WriteLine($" The standard method completed in: {standardMethodStopwatch.ElapsedMilliseconds}");
Console.Beep();

int fibonacciRecursionMethod(int currentNumber)
{

    if (currentNumber == 0)
    {
        return 0;
    }
    else if (currentNumber == 1)
    {
        return 1;
    }
    else
    {
        return fibonacciRecursionMethod(currentNumber - 1) + fibonacciRecursionMethod(currentNumber - 2);
    }


}


int fibonacciStandardMethod(int fibNumber)
{
    int solution = 0;
    int firstNum = 0;
    int secondNum = 1;
    for (int i = 2; i <= fibNumber; i++)
    {
        solution = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = solution;
    }
    return solution;
}