// See https://aka.ms/new-console-template for more information

for (int i = 0; i < 10; i++)
{
    Console.Write($"i = {i} ");
    if (i == 9) {
        Console.Write("\n");
    }
}


for (int i = 0; i < 10; ++i)
{
    Console.Write($"i = {i} ");
    if (i == 9) {
        Console.Write("\n");
    }
}

bool isPrime = true;
int numberToCheck;
Console.WriteLine("Prime Search");

do
{
Console.Write("Enter a number: ");
string input = Console.ReadLine();
 numberToCheck = int.Parse(input);
for (int i = 2; i < numberToCheck-1; i--)
{
    if(numberToCheck % i == 0) {
        isPrime = false;
    }
}

} while (isPrime);

Console.WriteLine($"{numberToCheck} is prime: {isPrime}");