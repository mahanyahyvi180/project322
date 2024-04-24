using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp177
{
    class Program
    {
        static void main()
        {
            var generator = new Random();
            var data = new int[15];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(10, 100);
            }

            Array.Sort(data);
            DisplayElements(data, 0, data.Length - 1);

            Console.Write("\nplease enter an integer value(-1 to quit)");
            int searchInt = int.Parse(Console.ReadLine());

            while (searchInt != -1)
            {
                int position = BinarySearch(data, searchInt);

                if (position != -1)
                {
                    Console.WriteLine($"The integer {searchInt} was found in" + $"position {position}.\n");
                }
                else
                {
                    Console.WriteLine($"The integer {searchInt} was found in");
                }
                Console.Write("please enter an integer value(-1 to quit)");
                 searchInt = int.Parse(Console.ReadLine());
            }
        }
        public static int BinarySearch(int[] values, int searchElement)
        {
            var low = 0;
            var high = values.Length - 1;
            var middle = (low + high + 1) / 2;

            do
            {
                DisplayElements(values, low + high);

                Console.WriteLine("-- ".PadLeft((middle + 1) * 3));

                if (searchElement == values[middle])
                {
                    return middle;
                }
                else if (searchElement < values[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
                middle = (low + high + 1) / 2;
            } while (low <= high);
            return -1;
            }
        public static void DisplayElements(int[] values, int low, int high)
        {
            Console.WriteLine(string.Empty.PadLeft(low * 3));

            for (var i = low; i <= high; i++)
            {
                Console.WriteLine($"{values[i]}");
            }
            Console.WriteLine();
        }
                
        }
        }
        
        
       
        
            
        
        
        
        
        
        
               
            
        
        
        
    

