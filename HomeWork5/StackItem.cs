namespace HomeWork5
{
    public partial class Stack
    {
        internal class StackItem
        {
            internal Stack stack;
            internal StackItem? prev;
            internal string value;
            public StackItem(Stack stack,string value) 
            {
                this.stack = stack;
                this.value = value;
                this.prev = stack.head;
            }
        }

    }
}
