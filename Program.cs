
int Main()
{
    const int size = 4;
    string[] input = new string[size] {"hello", "2", "world", ":-)"};
    int num = 0;
    string control = "NULL";

    while(true)
    {







        Console.WriteLine("Do you want to terminate a program ? \nY/y");
        control = Console.ReadLine();
        
        if(control == "Y" || control == "y") break;
        else Main();
    }

    return 0;
}

Main();

class Utils
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

class Solution
{

}