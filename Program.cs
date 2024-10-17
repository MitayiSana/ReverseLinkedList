using System.ComponentModel;

namespace ReverseLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            var delete = list.Reverse();
            foreach(int i in delete)
            {
                Console.WriteLine(i);
            }
        }
            
    }
}
