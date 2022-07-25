using Stack.Operations;

class demo : Stack_operations
{
    public static void Main(String[] args)
    {
       
        int item;
        demo d = new demo();

        while (true)
        {
            Console.WriteLine("1. Push \n 2.Pop\n 3.Show Items\n 4.Top Element\n 5.Exit");
            Console.Write("Enter the Above Operations:");
            
            var input = Convert.ToInt32(Console.ReadLine());
            if(input== 5)
            {
                break;
            }
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter An Element:");
                    item = Convert.ToInt32(Console.ReadLine());
                     d.Push(item);
                     break;

                case 2:
                    d.Pop();
                     break;

                case 3:
                   d.Display();
                   break;

                case 4:
                    d.Peek();
                   break;

                default:
                        Console.WriteLine("Please Select Valid Option");
                     break;
             }
        }
    }
}