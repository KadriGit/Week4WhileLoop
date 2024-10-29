
Random rnd = new Random();
int cpuRandom = rnd.Next(1, 4);

bool loopactive = true;

while (loopactive)
{
    Console.WriteLine("Try to guess the cpu number : ");
    int userguess = Convert.ToInt32(Console.ReadLine());

    if(userguess == cpuRandom)
    {
        Console.WriteLine("you won !");
        loopactive = false;
    }
}
Console.WriteLine("Have a nice days!");