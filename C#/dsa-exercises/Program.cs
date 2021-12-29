using System.Diagnostics;

dsa_exercises._001._001 test = new();

int Min = -1000000;
int Max = 1000000;

int[] array = new int[10000000];

Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(Min, Max);
}

Stopwatch stopwatch = new Stopwatch();

Console.WriteLine($"Array count : {array.Length}");

stopwatch.Start();
int result = test.FindLowestIntNotPresent(array);
stopwatch.Stop();



Console.WriteLine($"The lowest integer found was : {result}, execution time sec:  {stopwatch.ElapsedMilliseconds / 1000}");