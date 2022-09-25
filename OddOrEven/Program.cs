Console.WriteLine("Sisesta number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

//paaris või paaritu

int result = userNum % 2;

if(result != 0)
{
    Console.WriteLine("Number on paarituarv");
}
else
{
    Console.WriteLine("Number on paarisarv");
}

