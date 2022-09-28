namespace Method_Overloading;
public class Class1
{

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static decimal Add(decimal z, decimal zz)
    {
        return z + zz;
    }


    public static string Add(int a, int b, bool c)
    {
        if (c && (a + b) != 1)
        {
            return $"{a + b} dollars";
        }
        else if (c && (a + b) == 1)
        {
            return $"{a + b} dollar";
        }
        else
        {
            return $"{a + b}";
        }
    }
}