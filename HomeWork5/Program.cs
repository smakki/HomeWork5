namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            var deleted = s.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            try
            {
                s.Pop();
            }
            catch (StackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine();


            //Additional task 1
            Console.WriteLine("Additional task 1");
            var s1 = new Stack("a", "b", "c");
            s1.Merge(new Stack("1", "2", "3"));
            Console.WriteLine($"size = {s1.Size}, Top = '{s1.Top}'");
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний


            Console.WriteLine();

            //Additional task 2
            Console.WriteLine("Additional task 2");
            var s3 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            Console.WriteLine($"size = {s3.Size}, Top = '{s3.Top}'");
            // в стеке s теперь элементы - "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний        }
        }
    }
}
