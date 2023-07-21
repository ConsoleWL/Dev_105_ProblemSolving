int counter = 0;
while (true)
{
    if (counter < 5)
    {
        Console.WriteLine("Enter text to reverse");
        string text = Console.ReadLine();

        string result = ReverseString(text);
        Console.WriteLine(result);
        Console.WriteLine();
        counter++;
    }
    else
    {
        Console.Clear();

        counter = 0;
    } 
}

static string ReverseString(string text)
{
	if(text == null || text == "" || text == " ")
	{
        return "";
    }
	else
	{
        string temp = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            temp += text[i];
        }
        return temp;
    }
}





//string newStr = ReverseString(str);
//Console.WriteLine(newStr);

//static string ReverseString(string textToReverse)
//{
//    char[] array = textToReverse.ToCharArray();
//    Array.Reverse(array);
//    return new string(array);
//}