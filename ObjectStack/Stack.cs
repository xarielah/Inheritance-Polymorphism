namespace Inheritance_Polymorphism.ObjectStack;
public class Stack
{
    private List<object> _list = new List<object>();

    /// <summary>
    /// Pushes an object onto the top of the Stack.
    /// </summary>
    /// <param name="obj">object</param>
    /// <exception cref="InvalidOperationException">Cannot push null object to stack.</exception>
    public void Push(object obj)
    {
        if (obj == null)
            throw new InvalidOperationException("Cannot push null object to stack.");
        _list.Add(obj);
    }

    /// <summary>
    /// Removes and returns the object at the top of the Stack.
    /// </summary>
    /// <returns>object</returns>
    /// <exception cref="InvalidOperationException">Cannot pop from an empty list.</exception>
    public object Pop()
    {
        // Checks if the List<T> is empty.
        if (_list.Count == 0)
            throw new InvalidOperationException("Cannot pop from an empty list.");
        // Gets the last index of the List<T>.
        var lastIndex = _list.Count - 1;
        // Gets the element at the specified index of the List<T>.
        var obj = _list[lastIndex];
        // Removes an element at the specified index of the List<T>.
        _list.RemoveAt(lastIndex);
        // Returns the element at the specified index of the List<T>.
        return obj!;
    }

    /// <summary>
    /// Clears the Stack.
    /// </summary>
    public void Clear()
    {
        _list.Clear();
    }
}
