
Random rnd = new Random();
int cpuRandom = rnd.Next(1, 4);

bool loopactive = true;

int numberOfTries = 0;

while (loopactive)
{
    Console.WriteLine("Try to guess the cpu number : ");
    int userguess = Convert.ToInt32(Console.ReadLine());
    numberOfTries++;    
    if(userguess == cpuRandom)
    {
        Console.WriteLine("you won !");
        loopactive = false;
    }
}
Console.WriteLine($"The number of tries: {numberOfTries}");
Console.WriteLine("Have a nice days!");