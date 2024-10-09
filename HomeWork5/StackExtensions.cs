namespace HomeWork5
{
    public static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2 )
        {
            
            while(s2.Top != null)
            {
                s1.Add(s2.Pop());
            }
           
        }
    }
}
