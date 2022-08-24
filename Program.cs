namespace LinkedListProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkList list = new LinkList();
            list.Append(56);
            list.Append(70);
            list.Display();
            list.Insert(30, 56);
            list.Display();
            list.DeleteFirst();
            list.Display();
        }
    }
}