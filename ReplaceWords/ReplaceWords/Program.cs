// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine("Enter your username");
    String Name = Console.ReadLine();

    if (Name.Length >= 3)
    {
        ReplaceGivenTemplate(Name);
    }
    else
    {
        Console.WriteLine("Please enter atleast 3 characters");
    }
}
 static void ReplaceGivenTemplate(String Name)
{
    String Template = "Hello <UserName> , How are you?";
    if (Template.Contains("<UserName>"))
    {
        string result = Template.Replace("<UserName>", Name);
        Console.WriteLine("After replace : " + result);

    }
}
    
