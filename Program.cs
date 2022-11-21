
int Main()
{
    string[] input = new string[4] {"hello", "2", "world", ":-)"};
    int num = 3;
    string control = "50";
    num = Utils.StringToInt(control);
    Console.WriteLine(num);

    Utils.ShowArray(4, input);

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