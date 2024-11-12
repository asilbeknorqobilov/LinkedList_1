using System;

namespace LList
{
    internal class Program
    {
        public static void Main()
        {
            MyLikedList myList = new MyLikedList();
            myList.AddLast(-1);
            myList.AddLast(-5);
            myList.AddLast(4);
            myList.AddLast(10);
            myList.AddLast(13);
            myList.AddLast(12);
            myList.AddLast(4);
            myList.AddLast(10);
    

            Console.WriteLine("Asl ro'yxat");
            myList.Chop_et();

            Console.WriteLine("\nNatija");
            //Task_1
            
            // Console.WriteLine("Maxsus sonni kiriting");
            //  int maxsusson = Convert.ToInt32(Console.ReadLine());
            //  myList.Takrorlash(maxsusson);
            //  myList.Chop_et();
            
            //Task_2
            
            // int maxsusson = Convert.ToInt32(Console.ReadLine());
            // myList.Remove(maxsusson);
            // myList.Chop_et();

            
            //Task_3
            // Console.WriteLine(myList.Kopaytma());
            
            
            //Task_4
            myList.Birinchi_Juftni_Takrorlash();
            myList.Chop_et();
        }
    }
}