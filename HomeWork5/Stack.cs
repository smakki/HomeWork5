namespace HomeWork5
{
    public partial class Stack
    {
        private StackItem? head;
        private int _size;
        public Stack(){ }
        public Stack(params string[] args)
        {
            foreach (var item in args)
            {
                Add(item);
               
            }
        }

        public int Size => _size;
        public string? Top => head?.value;

        public void Add(string item)
        {
            head = new StackItem(head, item);
            _size++;
        }

        public string Pop()
        {
            if (head == null)
            {
                throw new StackIsEmptyException("Stack is empty");
            }
            var value = head.value;
            head = head.prev;
            _size--;
            return value;
        }

        public static Stack Concat(params Stack[] args)
        {
            var newStack = new Stack();
            foreach (var item in args) 
            {
               newStack.Merge(item);
            }
            return newStack;
        }
    }
}
