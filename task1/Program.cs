/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число (a):");
string firstNumber=Console.ReadLine();
Console.WriteLine("Введите второе число (b):");
string secondNumber=Console.ReadLine();

int Num1=int.Parse(firstNumber);
int Num2=int.Parse(secondNumber);

if (Num1 > Num2)
{
    Console.WriteLine($"a = {Num1}; b = {Num2} -> max = {Num1}");
}

else
{
    Console.WriteLine($"a = {Num1}; b = {Num2} -> max = {Num2}");
}
