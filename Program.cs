
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine(ConcatenateStrings("hello ", "world"));

Console.WriteLine(GreetUser("NameUser", 14));

Console.WriteLine(InfoString("Test String"));

Console.WriteLine(FiveCharacters("qwertyasdfg"));

Console.WriteLine(ConcatenateArrayStrings(["First", "Second", "Third", "Fourth", "Fifth"]));

Console.WriteLine(ReplaceWords("Orange, Banana, Orange, Apple", "Orange", "Lime"));

string ConcatenateStrings(string str1, string str2)
{
    return str1 + str2;
}

string GreetUser(string name, int age)
{
    return $"Hello, {name}!\nYou are {age} years old.";
}

string InfoString(string str)
{
    return $"{str.Length} characters long.\n{str.ToUpper()}\n{str.ToLower()}";
}

string FiveCharacters(string str)
{
    return str.Substring(0, 5);
}

StringBuilder ConcatenateArrayStrings(string[] strs)
{
    var result = new StringBuilder();

    foreach (var str in strs)
    {
        result.Append(str + " ");
    }
    
    return result;
}

string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
{
    Regex regex = new Regex(wordToReplace);
    string result = regex.Replace(inputString, replacementWord);
    return result;
}

