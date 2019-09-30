using System;
using System.Collections.Generic;
using System.Text;

namespace masterclass
{
    class Arrays
    {
        public void DoSomething()
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 is {0}", grades[0]);
            // boring
            Console.ReadLine();

            // another initialization  :
            int[] gradesofMathStudentsA = { 20, 13, 112, 8, 8 };

            // another way of initialializing 
            int[] gradesOfMathStudents = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("lengh of this B thing {0}", gradesofMathStudentsA);

        }
        // 2D Array
        public void DoForeach()
        {
            int[] nums = new int[20];

            // fill in
            for(int i = 0; i<10; i++)
            {
                nums[i] = i;
            }

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine(" current value is {0} at position {1}", k, counter++);

            }
        }
        public void Multidimensional()
        {
            // 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine("the value of seven is {0}", array2D[2, 0]);


            string[,] array2DString = new string[3, 2]
            {
                { "one","two"},
                {"three","four" },
                {"five","six" }
            };
            array2DString[1, 1] = "chiken";
            int dimensions = array2DString.Rank;

            Console.WriteLine("The dimensions is {0}", dimensions);
        }
    }
}
