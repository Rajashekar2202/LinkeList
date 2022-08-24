namespace LinkedListProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkList list = new LinkList();
            
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}