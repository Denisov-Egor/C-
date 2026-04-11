using System.Text.RegularExpressions;

string input = "12345";
Regex regex = new Regex("\b\d+\b");

bool isMatch = regex.IsMatch(input);
Console.WriteLine(isMatch); 
