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

int sum = recursiveCountAddition(1, 0);
Console.WriteLine($"Sum: {sum}");

int diff = recursiveCountSubtraction(1000);
Console.WriteLine($"Sub: {diff}");

int fiboNumber = fibonacciMethod(4);
Console.WriteLine(fiboNumber);

int recursiveCountAddition(int currentNumber, int count = 1, int currentValue = 0)
{
    if (count < 1000)
    {
        // Console.WriteLine(currentNumber);
        // Console.WriteLine($"{currentNumber} + {count} = {currentNumber + count}");
        return recursiveCountAddition(currentNumber + count, count + 1, currentValue += currentNumber);
    }
    // return currentNumber + count;
    return currentValue;
}

int recursiveCountSubtraction(int currentNumber, int currentValue = 0, int count = 1000)
{
    if (count > 500)
    {
        // Console.WriteLine(currentNumber);
        // Console.WriteLine($"{currentNumber} / {currentNumber}  - 1 = {currentNumber / currentNumber - 1 + (currentNumber + 1)}");
        currentValue += currentNumber + currentNumber - 1;
        return recursiveCountSubtraction(currentNumber + currentNumber - 1, currentValue, count - 1);
    }
    return currentValue;
}

int fibonacciMethod(int currentNumber)
{

    if (currentNumber == 0)
    {
        // Console.WriteLine($"{currentNumber - 1} + {currentNumber - 2} = {currentNumber - 1 + (currentNumber - 2)}");
        return 0;
    }
    else if (currentNumber == 1)
    {
        // Console.WriteLine($"{currentNumber - 1} + {currentNumber - 2} = {currentNumber - 1 + (currentNumber - 2)}");
        return 1;
    }

    Console.WriteLine(currentNumber);
    return fibonacciMethod(currentNumber - 1) + fibonacciMethod(currentNumber - 2);


}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

// go higher than 1000 if needed until you can see a difference
for (int i = 0; i < 1000; i++)
{
    // Place the code you want to time here
}

stopwatch.Stop();
Console.WriteLine("Elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);