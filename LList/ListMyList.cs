using System;

namespace LList
{
    public class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    class MyLikedList
    {
        private Node head;
        
        public MyLikedList()
        {
            head = null;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node a = head;
                while (a.Next != null)
                {
                    a = a.Next;
                }

                a.Next = newNode;
            }
        }



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


        // Task_1
        public void Takrorlash(int value)
        {
            Node a = head;

            while (a != null)
            {
                if (a.Value > value)
                {
                    Node takror = new Node(a.Value);
                    takror.Next = a.Next;
                    a.Next = takror;

                    a = takror.Next;
                }
                else
                {
                    a = a.Next;
                }
            }
        }


        // Task_2   
        public void Remove(int value)
        {
            Node a = head;

            while (a != null)
            {
                if (a.Value == value)
                {
                    if (a.Next != null && a.Next.Value != value)
                    {
                        a.Next = a.Next.Next;
                    }
                }
                a = a.Next;
            }
        }
        
        //Task_3
        
        public int Kopaytma()
        {
            Node a = head;
            int product = 1;
            bool musbat = false;

            while (a != null)
            {
                if (a.Value > 0)
                {
                    product *= a.Value;
                    musbat = true;
                }
                a = a.Next;
            }

            return musbat ? product : 0;
        }
        
        //Task_4
        
        public int Birinchi_juft()
        {
            Node a = head;

            while (a != null)
            {
                if (a.Value % 2 == 0)
                {
                    return a.Value;
                }
                a = a.Next;
            }
            return 0;
        }
        
        
        public void Birinchi_Juftni_Takrorlash()
        {
            Node a = head;

            while (a != null)
            {
                if (a.Value % 2 == 0) 
                {
                    Node takrorNode = new Node(a.Value);
                    takrorNode.Next = a.Next;
                    a.Next = takrorNode;
                    break;
                }
                a = a.Next;
            }
        }
        
        
        
    }
}