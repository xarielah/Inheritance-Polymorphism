using Inheritance_Polymorphism.ObjectStack;

namespace Inheritance_Polymorphism;

public class Program
{
    public static void Main()
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        // Throws an InvalidOperationException.
        Console.WriteLine(stack.Pop());
    }
}

