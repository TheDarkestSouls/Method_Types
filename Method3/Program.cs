int Method3() // Take nothing, return something
{
    return DateTime.Now.Year;
}

int Year = Method3();
Console.WriteLine(Year);