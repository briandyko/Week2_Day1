using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] favNumbers = { 61, 22, 3, 44, 105, 36 };

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine(favNumbers[0]);
            //Console.WriteLine(studentNames[3]);

            //first Do It!

            //string[] vacationSpots = { "Paris", "London", "Hawaii", "China", "Vienna", "Alaska", "Italy", "Germany", "Japan", "Australia" };
            //Console.WriteLine(vacationSpots[0] + " " + vacationSpots[9]);

            //int[] kidAges = { 10, 14, 3 };
            //Console.WriteLine(kidAges[0]);
            //Console.WriteLine(kidAges[1]);
            //Console.WriteLine(kidAges[2]);

            //float[] studentGPAs = { 1.2f, 2.3f, 2.6f, 1.7f, 3.5f, 3.1f, 2.2f, 2.7f };
            //Console.WriteLine(studentGPAs[0]);
            //Console.WriteLine(studentGPAs[1]);
            //Console.WriteLine(studentGPAs[2]);
            //Console.WriteLine(studentGPAs[3]);
            //Console.WriteLine(studentGPAs[4]);
            //Console.WriteLine(studentGPAs[5]);
            //Console.WriteLine(studentGPAs[6]);
            //Console.WriteLine(studentGPAs[7]);
            

            //char[] firstLetter = { 'd', 'k', 'b', 'l' };
            //Console.WriteLine(firstLetter[0] + " " + firstLetter[1] + " " + firstLetter[2] + " " + firstLetter[3]);

            int[] numbers = new int[4];
            numbers [0] = 43;
            numbers[1] = 12;
            Console.WriteLine("Please enter a number");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            numbers[3] = int.Parse(Console.ReadLine());

            numbers[0] = 30;
    
            Console.WriteLine(numbers[3]);



        }
    }
}
