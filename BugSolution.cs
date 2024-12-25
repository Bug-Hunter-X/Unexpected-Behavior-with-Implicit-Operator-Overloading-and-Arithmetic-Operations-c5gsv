public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.MyProperty + b.MyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; 
        int value1 = obj1;  
        Console.WriteLine(value1); 

        MyClass obj2 = new MyClass(10);
        MyClass value2 = obj2 + 5; 
        Console.WriteLine(value2.MyProperty); 
        MyClass obj3 = new MyClass(7);
        MyClass value3 = obj2 + obj3;
        Console.WriteLine(value3.MyProperty);
    }
}