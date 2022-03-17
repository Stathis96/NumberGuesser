// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Text;
using System;

 void FizzBuzz()
{
    for  (int n = 0 ;n<101;n++)
    {
        
        if (n % 5 == 0 && n % 3 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (n % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (n % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(n);
        }
    }

}
FizzBuzz();
/*
while (true)
{
    Console.WriteLine("Gimme a number to check fizzbuzz");
    string x = Console.ReadLine();
    FizzBuzz(Int32.Parse(x));
    Console.WriteLine("Keep playing? Y/N");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}
*/
/*
static long TotalAllEvenNumbers(int[] intArray)
{
    return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
}
int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14 };
Console.WriteLine(TotalAllEvenNumbers(integers));
*/
/*
string str1 = "i athinoula einai to mwro mou ";


Console.WriteLine(ReverseAllWords(str1.ToCharArray()));
static char[] ReverseAllWords(char[] in_text)
{
    int lindex = 0;
    int rindex = in_text.Length - 1;
    Console.WriteLine("rindex is" + rindex);
    if (rindex > 1)
    {
        //Reverse Complete String
        in_text = ReverseString(in_text, 0, rindex);

        //Reversing each word of given phrase
        for (rindex = 0; rindex < in_text.Length; rindex++)
        {
            if (rindex == in_text.Length || in_text[rindex] == ' ')
            {
                Console.WriteLine("mpika sto if mou me times gia rindex ->" + rindex +"intext length  ->"+ in_text.Length);
                in_text = ReverseString(in_text, lindex, rindex - 1);
                lindex = rindex + 1;
            }
        }
    }
    return in_text;
}

static char[] ReverseString(char[] intext, int lindex, int rindex)
{
    char tempc;
    while (lindex < rindex)
    {
        tempc = intext[lindex];
        intext[lindex++] = intext[rindex];
        intext[rindex--] = tempc;
    }
    return intext;
}
*/

/*
string name = "skato";
char[] charArray = name.ToCharArray();
Console.WriteLine(ReverseString(charArray, 0, charArray.Length -1));
*/
string name = null;  
string myname = name ?? "Laxmi";  
Console.WriteLine(myname);

static int givenarray(int[] n)
{
    return n.Where(i => i % 2 == 0).Sum(i => i);
}
int[] array = { 2, 3, 4, 6 };
//Console.WriteLine(givenarray(array));

int xy = 111;
object ox = xy; // boxing 

ox = 999;
xy = (int)ox; // unboxing


//REVERSE ORDER OF GIVEN WORDS
/*
string line = "Display the pattern like pyramid using the alphabet.";
Console.WriteLine("\nOriginal String: " + line);
string result = "";
List<string> wordsList = new List<string>();
string[] words = line.Split(" ");
for (int i = words.Length - 1; i >= 0; i--)
{
    result += words[i] + " ";
}
wordsList.Add(result);
foreach (String s in wordsList)
{

    Console.WriteLine("\nReverse String: " + s);
}
*/

//FIND SUM OF ALL EVEN NUMBERS IN AN ARRAY
static long TotalAllEvenNumbers(int[] intArray)
{
    return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
}
int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14 };
Console.WriteLine(TotalAllEvenNumbers(integers));
/*
String a = "TechBeamers";
String b = "TECHBEAMERS";
int c;
c = b.CompareTo(a);
Console.WriteLine(c);
*/

/*
Derived d = new Derived();
int xyz = 10;
d.Func(xyz);
public class Base
{
    public virtual void Func(int x)
    {
        Console.WriteLine("Base.Func(int)");
    }
}
public class Derived : Base
{
    public override void Func(int x)
    {
        Console.WriteLine("Derived.Func(int)");
    }
    public void Func(object o)
    {
        Console.WriteLine("Derived.Func(object)");
    }
}
*/