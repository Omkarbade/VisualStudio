// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine("Enter a Number to get its factors: ");
    int Number = Convert.ToInt32(Console.ReadLine());

    int fact = 1;
    for (int i = 1; i <= Number; i++)
    {
        fact = fact * i;
    }
    Console.WriteLine("Factorial of given number is: " + fact);
}
    

