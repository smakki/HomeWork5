namespace HomeWork5
{
    internal class StackIsEmptyException:Exception
    {
        public StackIsEmptyException():base() { }

        public StackIsEmptyException(string message):base(message) { }
    }
}
