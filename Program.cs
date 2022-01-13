using System;

namespace LinkedListPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Tutorial ");

            SingleLinkedList sn = new SingleLinkedList();
            Console.WriteLine("choose your options");
            Console.WriteLine("\n 1. to create list" +
                "\n 2. Display LinkedList" +
                "\n 3. count Node" +
                "\n 4.search Node" +
                "\n 5. RefernceToLastNode" +
                "\n 6. RefernceToSecondLastNode" +
                "\n 7. RefernceToParticularInfo" +
                "\n 8. RefernceToParticularInfoPredeccsor" +
                "\n 9. RefernceToParticularPosition" +
                "\n 10. InsertNewNodeAtBeginning" +
                "\n 11. InsertAtEnd" +
                "\n 12. InsertAfter" +
                "\n 13. InsertBefore" +
                "\n 14. InsertAtPosition" +
                "\n 15. DeleteFirstNode" +
                "\n 16. DeleteLastNode" +
                "\n 17. DeleteNode");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        sn.CreateList();
                        break;
                    }
                case 2:
                    {
                        sn.Display();
                        break;
                    }
                case 3:
                    {
                        sn.CountNode();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("enter the value you want to search");
                        int data = Convert.ToInt32(Console.ReadLine());
                        sn.SearchNode(data);
                        break;
                    }
                case 5:
                    {
                        sn.RefernceToLastNode();
                        break;

                    }
                case 6:
                    {
                        sn.RefernceToSecondLastNode();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("enter the info");
                        int x = Convert.ToInt32(Console.ReadLine());
                        sn.RefernceToParticularInfo(x);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("enter the info");
                        int x = Convert.ToInt32(Console.ReadLine());
                        sn.RefernceToParticularInfoPredeccsor(x);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("enter the position");
                        int x = Convert.ToInt32(Console.ReadLine());

                        sn.RefernceToParticularPosition(x);
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("enter the value ");

                        int x = Convert.ToInt32(Console.ReadLine());

                        sn.InsertNewNodeAtBeginning(x);
                        break;
                    }
                case 11:
                    {

                        Console.WriteLine(" enter value ");

                        int x = Convert.ToInt32(Console.ReadLine());
                        sn.InsertAtEnd(x);
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine(" enter value ");

                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter Node ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        sn.InsertAfter(x, y);
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine(" enter value ");

                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter Node ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        sn.InsertBefore(x, y);
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine(" enter position ");

                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter Node ");
                        int y = Convert.ToInt32(Console.ReadLine());


                        sn.InsertAtPosition(y, x);
                        break;
                    }
                case 15:
                    {
                        sn.DeleteFirstNode();
                        break;
                    }
                case 16:
                    {
                        sn.DeleteLastNode();
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("enter node value ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        sn.DeleteNode(x);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("enter correct optipon");
                        break;
                    }
            }
        }
    }
}
