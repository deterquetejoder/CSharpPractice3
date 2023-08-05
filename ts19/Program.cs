//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter your five-digit number ");
int inp = Convert.ToInt32(Console.ReadLine());
int f,rev,sum =0;

if(inp<0) inp=inp*-1;
if(inp>9999&&inp<100000)
{
   for(f=inp;inp!=0;inp=inp/10)
{
rev= inp % 10;
sum=sum*10+rev;
}
//Console.WriteLine(sum);
if (sum==f)
Console.WriteLine("Your number is a palindrome");
else Console.WriteLine ("your number isn't a palindrom");
}
else Console.WriteLine("your number is not a five-digit number");
