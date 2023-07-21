Console.WriteLine(Compresser("ssbbbbfffa"));
static string Compresser(string text)
{
    string temp = text[0].ToString();

    int counter = 1;

    for (int i = 1; i < text.Length; i++)
    {
        if (text[i] == temp[^1])
        {
            counter++;
        }
        else
        {

            temp += counter;
            counter = 1;
            if (i != text.Length)
            {
                temp += text[i];
            }
        }
    }

    temp += counter;

    return temp;
}


//Console.WriteLine(Compressor("assbbb"));
//static string Compressor(string text)
//{
//    string temp = text[0].ToString();

//    int counter = 1;


//    return temp;

//}


//Console.WriteLine(Compresser("ssbggpaaaa"));
//static string Compresser(string text)
//{
//	string temp = "";

//	int counter = 1;
//	for (int i = 0; i < text.Length - 1; i++)
//	{

//		if (text[i].ToString() == text[i + 1].ToString())
//		{

//			if (text[i] == (text.Length - 1))
//			{
//				temp += text[i].ToString();
//			}
//			else
//			{
//				counter++;
//			}

//		}
//		else
//		{
//			temp += text[i].ToString() + counter;
//			counter = 1;
//		}
//	}

//	return temp;
//}

//string text = "bbbssssccclld";
//char temp;
//foreach (char letter in text)
//{
//    temp = letter;

//    if(letter == temp)

//}















































//static string StringComperession(string str)
//{
//	int counter = 1;
//    //string tempStr = "";
//	char[] charArray = str.ToCharArray();
//	char[] charArrayTemp = new char[charArray.Length];

//	for (int i = 0; i < charArray.Length; i++)
//	{
//		if (charArray[i] == charArray[i + 1])
//		{
//			charArrayTemp[i] += charArray[i];
//			counter++;
//		}
//	}
//}