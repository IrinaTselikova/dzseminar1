/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число:");
string firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string secondNumber = Console.ReadLine();
Console.WriteLine("Введите третье число:");
string thirdNumber = Console.ReadLine();

int Num1=int.Parse(firstNumber);
int Num2=int.Parse(secondNumber);
int Num3=int.Parse(thirdNumber);


int max = Num1;
if (Num1 > max) max=Num1;
if (Num2 > max) max=Num2;
if (Num3 > max) max=Num3;

Console.WriteLine($"{Num1} {Num2} {Num3} -> {max}");