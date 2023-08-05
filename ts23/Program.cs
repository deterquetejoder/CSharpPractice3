//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=num;i++)
{
    int cubed = i*i*i;
    Console.WriteLine(cubed);
}