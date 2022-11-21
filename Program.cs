﻿
int Main()
{
    const int size = 4;
    string[] input = new string[size] {"hello", "2", "world", ":-)"};
    int num = 0, foo = 0, bar = 0;
    string control = "NULL";

    while(true)
    {
        Console.WriteLine("Program is running.");
        Utils.ShowArray(size, input);
        
        Console.WriteLine("Enter size of a new array.\nThe size must be less or equal 3.");
        control = Console.ReadLine();
        num = Utils.StringToInt(control);
        if(num > 3 || num <= 0) Main();

        Solution sol = new Solution(input);
        
        while(num != 0)
        {
            Utils.ShowArray(size, input);
            Console.WriteLine("Enter the number of the position in the array for a new array.");
            control = Console.ReadLine();
            foo = Utils.StringToInt(control);
            
            if(foo >= size || foo < 0) Main();
            
            sol.Construct(foo, bar);
            num--;
            bar++;
        }

        Console.WriteLine($"New array is: ");
        sol.Out(bar);

        Console.WriteLine("Do you want to terminate a program ? \nY/y");
        control = Console.ReadLine();

        if(control == "Y" || control == "y") break;
        else Main();
    }

    return 0;
}

Main();

class Utils
#region 
{
    static public int StringToInt(string foo)
    {
        return System.Int32.Parse(foo);
    }

    static public void ShowArray(int size, string[] str)
    {
        for(int foo = 0; foo < size; foo++)
            Console.WriteLine($"content: {str[foo]} - position: {foo}");
    }
}
#endregion

class Solution
#region 
{
    public string[] input = {"NULL"};
    public string[] output = {"NULL"};

    public Solution(string[] IN)
    {
        input = IN;
    }

    public void Construct(int foo, int bar)
    {
        Array.Resize(ref output, output.Length + 1);
        output[bar] = input[foo];
    }

    public void Out(int size)
    {
        Utils.ShowArray(size, output);
    }
}
#endregion