public class SomeBool
{
    public static bool operator ==(SomeBool a, bool b)
    {
        return true;
    }

    public static bool operator !=(SomeBool a, bool b)
    {
        return false;
    }

    public override bool Equals(object obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SomeBool someBool = new SomeBool();
        bool result = someBool == true && someBool == false;
        Console.WriteLine(result); // True
    }
}
