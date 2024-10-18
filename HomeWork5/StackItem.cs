namespace HomeWork5
{
    public partial class Stack
    {
        class StackItem
        {
            
            internal StackItem? prev;
            internal string value;
            public StackItem(StackItem? prev, string value) 
            {
                
                this.value = value;
                this.prev = prev;
            }
        }

    }
}
