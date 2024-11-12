using System;

namespace LList
{
    public class For_metod
    {
        private Node head;

        public void Chop_et()
        {
            Node a = head;
            while (a != null)
            {
                Console.WriteLine(a.Value + " ");
                a = a.Next;
            }

            Console.WriteLine();
        }

        public void Takrorlash(int value)
        {
            Node a = head;

            while (a != null)
            {
                if (a.Value > value)
                {
                    Node takror = new Node(a.Value);
                    takror.Next = takror;
                    a = takror.Next;
                }
                else
                {
                    a = a.Next; 
                }
            }
        }
    }
}