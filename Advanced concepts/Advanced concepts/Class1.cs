using System;
public class Class1
{
    public static void Main()
    {
        MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
        int val = intGenericClass.genericMethod(200);       
    }
}
public class MyGenericClass<T>
{
    private T genericMemberVariable;
    public MyGenericClass(T value)
    {
        genericMemberVariable = value;
    }
    public T genericMethod(T genericParameter)
    {
        Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
        Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
        Console.ReadLine();
        return genericMemberVariable;
    }
    public T genericProperty { get; set; }
}