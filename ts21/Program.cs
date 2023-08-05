

Console.WriteLine("Enter X coordinate of the first point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinate of the first point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z coordinate of the first point: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X coordinate of the second point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinate of the second point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z coordinate of the second point: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltaX = x2 - x1;
int deltaX = y2 - y1;
int deltaX = z2 - z1;
return Math.Sqrt(deltaX*deltaX+deltaY*deltaY+deltaZ*deltaZ);
}
Console.Write($"The distance you were searching for is {dis(x1, y1, z1, x2, y2, z2)}");