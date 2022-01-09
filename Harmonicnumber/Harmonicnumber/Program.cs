// See https://aka.ms/new-console-template for more informatio

Console.WriteLine("Enter a number to print Harmonic Number: ");
int number = Convert.ToInt32(Console.ReadLine());

double harmonicSum = 0.0;
for (int count = 0; count <= number; count++)
{
    if (count == 0)
        Console.WriteLine("Please enter positive number: ");
    else
        harmonicSum += 1 / (float)count;
}
Console.WriteLine("Harmonic Number is: " + harmonicSum);
        
    
