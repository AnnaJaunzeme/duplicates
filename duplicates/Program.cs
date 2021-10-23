using System;

namespace duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] usersArray = new int[a];
            int i, j, count = 0;
           
            Console.WriteLine("Enter elements in the array: ");
              for (i = 0; i < a; i++)
                
            {
               usersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n \n Thank You!");
            for (i = 0; i < a ; i++)
            {
              for (j = i + 1; j < a; j++)
                {
                    
                    if (usersArray[i] == usersArray[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count > 0)
            {
             Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            }
            else
            {
                Console.WriteLine("\n There is not any duplicates in your Array! ");
            }
                                Console.ReadLine();
        }
    }
}
