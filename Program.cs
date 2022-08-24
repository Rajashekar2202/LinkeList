namespace LinkedListProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkList list = new LinkList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine(" ");
            Console.WriteLine("---------------------");

            list.Search(30);
            list.Display();
        }
    }
}