//code
using System;
namespace CalculatingGrades
{

    class GradeCalculator
    {
        private int[] marks; // Array to store subject marks

        // Constructor to initialize the array with user-inputted marks
        public GradeCalculator(int[] marks)
        {
            this.marks = marks; // Assign input marks to class variable
        }

        // Function to calculate the average marks of all subjects
        public double CalculateAverage()
        {
            int sum = 0; // Variable to store sum of all marks
            foreach (int mark in marks) // Loop through each mark
            {
                sum += mark; // Add mark to sum
            }
            return sum / (double)marks.Length; // Calculate and return average
        }

        // Function to determine the grade based on the average marks
        public char FindGrade(double average)
        {
            if (average >= 80) return 'A'; // Grade A for average 80 or above
            else if (average >= 70) return 'B'; // Grade B for 70-79
            else if (average >= 60) return 'C'; // Grade C for 60-69
            else if (average >= 50) return 'D'; // Grade D for 50-59
            else return 'F'; // Grade F for below 50
        }

        // Function to return remarks using a switch statement
        public string GetRemarks(char grade)
        {
            switch (grade)
            {
                case 'A':
                    return "Excellent! Your grade is A.";
                case 'B':
                    return "Good! Your grade is B.";
                case 'C':
                    return "Satisfactory. Your grade is C.";
                case 'D':
                    return "Pass. Your grade is D.";
                case 'F':
                    return "Fail. Your grade is F.";
                default:
                    return "Invalid grade."; // Just in case of unexpected input
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                string[] subjects = { "Mathematics", "Physics", "Chemistry", "Computer Science" }; // Subject names
                int[] marks = new int[4]; // Array to store marks for each subject

                Console.WriteLine("Enter marks for the following subjects (out of 100):");

                // Using a loop to get marks for each subject
                for (int i = 0; i < subjects.Length; i++)
                {
                    Console.Write($"{subjects[i]}: "); // Ask user for marks
                    marks[i] = GetValidMarks(); // Store validated marks
                }

                // Creating an object of GradeCalculator class and passing marks
                GradeCalculator student = new GradeCalculator(marks);

                // Calculating average marks
                double averageMarks = student.CalculateAverage();

                // Determining grade based on average
                char grade = student.FindGrade(averageMarks);

                // Displaying results to the user
                Console.WriteLine($"\nAverage Marks: {averageMarks:F2}"); // Show average with 2 decimal places
                Console.WriteLine($"Grade: {grade}"); // Show assigned grade
                Console.WriteLine(student.GetRemarks(grade)); // Display remarks based on grade
            }
            catch (Exception ex) // Catch unexpected errors
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}"); // Show error message
            }

            Console.WriteLine("\nProgram finished."); // Indicate program has ended
        }

        // Function to validate user input marks
        static int GetValidMarks()
        {
            int marks; // Variable to store user input

            // Keep asking until a valid input is entered
            while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
            {
                Console.Write("Invalid input! Can you please enter a number between 0 and 100: "); // Prompt for valid input
            }
            return marks; // Return the valid marks
        }
    }
}
//Pseudocode
///START
///DECLARE SUBJECTS AS ARRAY OF STRINGS ["Mathematics", "Physics", "Chemistry", "Computer Science"]
///DECLARE MARKS AS ARRAY OF INTEGERS [4]
///DECLARE AVERAGE AS FLOAT
///DECLARE GRADE AS CHARACTER
///DECLARE REMARK AS STRING
///PRINT "Enter marks for the following subjects (out of 100):"
///AVERAGE = (MATH + PHYSICS + CHEMISTRY + COMPUTER_SCIENCE) / 4  
///IF AVERAGE >= 80 THEN
///GRADE = 'A'  
///ELSE IF AVERAGE >= 70 THEN
///GRADE = 'B'  
///ELSE IF AVERAGE >= 60 THEN
///GRADE = 'C'  
///ELSE IF AVERAGE >= 50 THEN
///GRADE = 'D'  
///ELSE 
///GRADE = 'F'  
///END IF
///SWITCH (GRADE)
///CASE 'A': REMARK = "Excellent
///CASE 'B': REMARK = "Good!"  
///CASE 'C': REMARK = "Satisfactory."  
///CASE 'D': REMARK = "Pass."  .
///CASE 'F': REMARK = "Fail."  
///END SWITCH
///PRINT "Average Marks: " + AVERAGE  
///PRINT "Grade: " + GRADE  
///PRINT "Remarks: " + REMARK  
///END
///FUNCTION GET_VALID_MARK() RETURNS INTEGER
///DO
///INPUT MARK 
///IF MARK < 0 OR MARK > 100 THEN
///PRINT "Invalid! Enter a number between 0 and 100."  
///END IF
///WHILE MARK < 0 OR MARK > 100  
///RETURN MARK  
///END FUNCTION
