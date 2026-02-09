namespace Lista
{
    internal class Program
    {
        static void Main()
        {
           //Create a new list of integers
           List<int> lista = new List<int>();

            //Add elements in the end of the list
            lista.Add(11);
            lista.Add(22);
            lista.Add(3);
            lista.Add(8);
            lista.Add(55);

            lista.Reverse();

            int index = 1;
            //Display the elements in the list
            Console.WriteLine("Elements in the list (with foreach):");
            foreach (int elem in lista)
            {
                Console.WriteLine($"A(z) {index} elem a listában: " + elem);
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("Elements in the list (with for) backwards:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"A(z) {i+1} elem a listában: " + lista.ElementAt(i));
            }

            Console.WriteLine();
            Console.WriteLine("Elements in the list (with for) backwards:");
            for (int i = lista.Count-1; i > 0; i--)
            {
                Console.WriteLine($"A(z) {i + 1} elem a listában: " + lista.ElementAt(i));
            }

            Console.Write("Element 2 is presnt in the list?: " + lista.Contains(2));

            lista.Sort();
            lista.Reverse();
            index = 0;
            Console.WriteLine();
            foreach (int elem in lista)
            {
                Console.WriteLine($"A(z) {index} elem a listában: " + elem);
                index++;
            }

        }
    }
}
