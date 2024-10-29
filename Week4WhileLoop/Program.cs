
Random rnd = new Random();
int cpuRandom = rnd.Next(1, 4);

while (true)
{
    Console.WriteLine("Try to guess the cpu number : ");
    int userguess = Convert.ToInt32(Console.ReadLine());

    if(userguess == cpuRandom)
    {
        Console.WriteLine("you won !");
        break;
    }
}
Console.WriteLine("Have a nice days!");