﻿int[] num1=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] num2=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

bool isIdentical = true;
for (int i = 0; i < num1.Length; i++)
{
    if (num1[i] != num2[i])
    {
        isIdentical = false;
        break;
    }
    
}
if(!isIdentical)
{
    Console.WriteLine($"Arrays are not identical");
}
else
{
    Console.WriteLine($"Arrays are indentical");
}