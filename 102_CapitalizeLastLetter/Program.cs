Console.WriteLine(LastLetterCapital("i like problem solving"));
static string LastLetterCapital(string text)
{
    string result = "";

    if (text != "" || text != null)
    {
        string[] textArray = text.Split(' ');
        for (int i = 0; i < textArray.Length; i++)
        {
            string temp;
            temp = textArray[i];
            string word = "";

            if (temp.Length == 1)
            {
                word = temp.ToUpper();
            }
            else
            {
                for (int j = 0; j < temp.Length - 1; j++)
                {
                    word += temp[j];

                }
                word += temp[^1..].ToUpper();
            }

            textArray[i] = word;
        }

        foreach (var item in textArray)
        {
            result += item + " ";
        }

        return result;
    }
    else
    {
        return result;
    }
}




//Console.WriteLine(LastLetterCapital("i like problem solving"));
//static string LastLetterCapital(string text)
//{
//    string[] textArray = text.Split(' ');
//    for (int i = 0; i < textArray.Length; i++)
//    {
//        string temp = "";
//        temp = textArray[i];
//        temp = temp.Substring(0, temp.Length - 1) + temp.Substring(temp.Length - 1).ToUpper();

//        textArray[i] = temp;
//    }
//    var result = string.Join(" ", textArray);

//    return result;
//}



//var result = string.Join(" ", textArray);
//Console.WriteLine(result);

//var s = "of mice";
//var sa = s.Split(' ');
//for (var i = 0; i < sa.Length; i++)
//    sa[i] = sa[i].Substring(0, 1).ToUpper() + sa[i].Substring(1);
//var sout = string.Join(" ", sa);
//Console.WriteLine(sout);




//string text = "hello world";

//Console.WriteLine(text);

//string reversText = ReverseString(text);

//Console.WriteLine(reversText);

//string firsttoUpper = CapitalizedFirsttLetter(reversText);

//Console.WriteLine(firsttoUpper);

//string finalResult = ReverseString(firsttoUpper);

//Console.WriteLine(finalResult);

//Console.WriteLine();

////string result = UltimateStringReverse(text);

////Console.WriteLine(result);

//static string CapitalizedFirsttLetter(string text)
//{
//    string newText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

//    return newText;
//}

//static string ReverseString(string textToReverse)
//{
//    char[] array = textToReverse.ToCharArray();
//    Array.Reverse(array);
//    return new string(array);
//}

////static string UltimateStringReverse(string text)
////{
////    string temp = ReverseString(text);
////    temp = CapitalizedFirsttLetter(temp);
////    temp = ReverseString(temp);
////    return temp;
////}
///




//string demo = "Nikita";
//string newDemo = demo.Substring(demo.Length - 1);
//Console.WriteLine(newDemo);
