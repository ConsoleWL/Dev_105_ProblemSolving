Console.WriteLine(Palindrome("et"));
static int Palindrome(string text)
{
    //-1 not true or false
    //-0 false
    // 1 true

    if (text == null || text == "" || text == " ")
    {
        return -1;
    }
    else
    {
        string temp = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            temp += text[i];
        }

        if (temp == text)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}



//Console.WriteLine(Palindrome(""));

//static bool Palindrome(string word)
//{
//    string reverseWord = ReverseString(word);

//    if(reverseWord == word)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }


//}
//static string ReverseString(string text)
//{
//    if (text == null || text == "" || text == " ")
//    {
//        return "";
//    }
//    else
//    {
//        string temp = "";
//        for (int i = text.Length - 1; i >= 0; i--)
//        {
//            temp += text[i];
//        }
//        return temp;
//    }
//}





//static bool Palindrome(string word)
//{
//    return word.SequenceEqual(word.Reverse());
//}