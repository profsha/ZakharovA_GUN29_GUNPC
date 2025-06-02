namespace NetologyCSharp;

public class Node
{
    public string Value { get; set; }
    
    public Node? Next { get; set; }
    
    public Node? Previous { get; set; }

    public Node First
    {
        get
        {
            var first = this;
            while (first.Previous != null)
            {
                first = first.Previous;
            }

            return first;
        }
    }

    public Node Last
    {
        get
        {
            var last = this;
            while (last.Next != null)
            {
                last = last.Next;
            }
            return last;
        }
    }

    public Node Append(Node value)
    {
        var last = Last;
        last.Next = value;
        value.Previous = last;
        return value;
    }

    public Node Prepend(Node value)
    {
        var first = First;
        value.Next = first;
        first.Previous = value;
        return value;
    }

    public Node(string value)
    {
        Value = value;
    }
}