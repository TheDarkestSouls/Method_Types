string Method4(int count, string text)  // Take something, return something
{
    int i = 0;
    string result = string.Empty;  // empty string initialization

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(4, "asdf ");
Console.WriteLine(res);