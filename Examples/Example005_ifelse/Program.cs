Console.WriteLine("Enter your name:");
string username = Console.ReadLine()!;
//Console.WriteLine("Hello Mary!");
//DisplayWeatherReport();
//void DisplayWeatherReport()
//{
    if(username?.ToLower() == "mary")
    {
   Console.WriteLine("Hello Mary!");
    }
    else
    {
        Console.WriteLine("Hello " + username);
    }
//}