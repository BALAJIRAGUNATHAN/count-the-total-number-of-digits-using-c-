//C# program to count the total number of 
//digits in the alpha-numeric string.

using System;

class Demo
{
    public static void Main()
    {
        string str="";
        int count=0;

        Console.Write("Enter the string: ");
        str = Console.ReadLine();
 
        for (int i=0; i<str.Length; i++)
        {
            if ((str[i] >= '0') && (str[i] <= '9'))
            {
                count++;
            }
        }
        Console.WriteLine("Number of Digits in the string: "+ count);
    }
}
