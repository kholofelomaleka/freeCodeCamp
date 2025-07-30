/* This code declares and assigns values to variables based on student names, 
performs various numeric calculations, and displays the results. 
Calculations include determining the sum of assignment scores and calculating the 
current grade for each student. To display the results in the required format, 
it uses Console.WriteLine(), as well character escape sequences that will help 
format the results. 
*/

/* Project overview

Develop a Student Grading application that automates the calculation of current grades 
for each student in a class. 

The parameters are:

A short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
The app needs to perform basic math operations to calculate the final grades for each student.
The app needs to output/display each student’s name and final score.
*/

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// calculate the current grade for each student
decimal sophiaGrade = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
decimal nicolasGrade = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
decimal zahirahGrade = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
decimal jeongGrade = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;

// calculate the letter grade based on the current grade
// (A: 90-100, B: 80-89, C: 70-79, D: 60-69, F: 0-59)
/*
for i in { sophiaGrade, nicolasGrade, zahirahGrade, jeongGrade }
{
   switch (i)
   {
       case var grade when grade >= 90:
           Console.WriteLine("A");
           break;
       case var grade when grade >= 80:
           Console.WriteLine("B");
           break;
       case var grade when grade >= 70:
           Console.WriteLine("C");
           break;
       case var grade when grade >= 60:
           Console.WriteLine("D");
           break;
       default:
           Console.WriteLine("F");
           break;
   }
*/

// display the results
Console.WriteLine("Student \tGrade:");
Console.WriteLine($"Sophia \t\t{sophiaGrade}% \tA");
Console.WriteLine($"Nicolas \t{nicolasGrade}% \tB");
Console.WriteLine($"Zahirah \t{zahirahGrade}% \tB");
Console.WriteLine($"Jeong \t\t{jeongGrade}% \tA");
