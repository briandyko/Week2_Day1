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

            //int[] numbers = new int[4];
            //numbers [0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number");
            //numbers[3] = int.Parse(Console.ReadLine());

            //numbers[0] = 30;

            //string[] daysOfWeek = new string[7];
            //daysOfWeek[0] = "Monday";
            //daysOfWeek[1] = "Tuesday";
            //daysOfWeek[2] = "Wednesday";
            //daysOfWeek[3] = "Thursday";
            //daysOfWeek[4] = "Friday";
            //daysOfWeek[5] = "Saturday";
            //daysOfWeek[6] = "Sunday";



            //int[] studentAges = new int[4];
            //studentAges[0] = 33;
            //studentAges[1] = 77;
            //studentAges[2] = 30;
            //studentAges[3] = 23;

            //Console.WriteLine(daysOfWeek.Length);

            //string[] lastName = { "d", "y", "k", "o" };
            //Console.WriteLine(lastName.Length);

            //string[] bandNames = new string[4];
            //bandNames[0] = "The Beatles";
            //bandNames[1] = "Ween";
            //bandNames[2] = "A Tribe Called Quest";
            //bandNames[3] = "The Magnetic Fields";
            //Console.WriteLine(bandNames[2]);

            //string[] exampleStringArray = { "This", "is", "an", "array", "of", "words", "because", "I", "like", "words." };

            ////Console.WriteLine("This is the last index " + (exampleStringArray.Length - 1));

            //Console.WriteLine(exampleStringArray[exampleStringArray.Length - 1]);

            //int index = exampleStringArray.Length;
            //index = index - 2;

            //Console.WriteLine(exampleStringArray[index]);



            //char[] birthMonths = { 'O', 'J', 'O', 'M' };
            //Console.WriteLine(Array.IndexOf(birthMonths, 'J'));

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            ////Console.WriteLine(Array.LastIndexOf(numbers, 4));

            ////Array.Reverse(numbers);
            ////Console.WriteLine(numbers[0]);

            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length - 1]);

            string[] firstNames = { "Bob", "Sue", "Lily", "Derrick", "Clara" };
            Console.WriteLine(Array.IndexOf(firstNames, "Lily"));

            int[] luckyNumbers = { 5, 4, 2, 7, 8, 4, 2, 7, 4, 5, 8 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 5));

            char[] alphaBets = { 'a', 'c', 'd', 'i', 'u', 'o' };
            Console.WriteLine(alphaBets[0]);
            Array.Reverse(alphaBets);
            Console.WriteLine(alphaBets[0]);

            string[] moreNames = { "Bob", "Clarence", "Lala", "Leslie", "Brian", "Phil" };
            Array.Sort(moreNames);
            Console.WriteLine(moreNames[0] + " " + moreNames[moreNames.Length - 1]);

            int[] favNumbers = { 1, 6, 8, 2, 5, 11, 65, 89, 32, 12 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0] + " " + favNumbers[favNumbers.Length - 1]);










        }
    }
}
