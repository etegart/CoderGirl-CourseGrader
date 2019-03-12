using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".


            int[] testScores = new int[5];
            testScores[0] = 48;
            testScores[1] = 55;
            testScores[2] = 90;
            testScores[3] = 95;
            testScores[4] = 95;


            GradeTestScores(testScores);
            Console.WriteLine(GradeTestScores(testScores));
            Console.ReadLine();

        }


        public static string GradeTestScores(int[] inputArray)
        {


            int sum = 0;
            string pass = "pass";
            string fail = "fail";
            
            
            foreach (var score in inputArray)
            {
                sum = sum + score;
            }

            float average = sum / inputArray.Length;

            foreach (var number in inputArray)
            {
                if (average >= 70)
                {
                    if (number < 50)
                    {
                        return fail;
                    }
                }
            }
            
            if (average >= 70)
            {
                return pass;
            }

            else if (average < 70)
            {
                return fail;
            }

            else if (inputArray.Length ==0)
            {
                return fail;
            }

                   
                    
            
                    
                 

        }
    }
}


