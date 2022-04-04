namespace HelloWorld.Test;

public abstract class AbExample
{
    public abstract void M1();

    public abstract void M2();

    public void M3()
    {
        Console.WriteLine("Display M3");
    }

    public virtual string M3(string name)
    {
        return "M4 as string";
    }

    public static void M4()
    {
        Console.WriteLine("Display M4");
    }

    


}

public class Sample : AbExample
{
    public override void M1()
    {
        Console.WriteLine("Tell me you override ABExample class MI");
    }

    public override void M2()
    {
        Console.WriteLine("Tell me you override ABExample class M2");
    }

    public sealed override string M3(string name)
    {
        return ($"{0} return M4 as sealed override method string: " + name);
    }


    public static void Main(string[] arg)
    {
       Sample sample = new Sample();
       sample.M3("HEY!  ");
       sample.M3();
    }


}

public class BigSample : Sample
{

}


