int currentAssignments = 5;

// Define the grades array with the student names and their scores for each assignment
string[][] grades = new string[4][];
grades[0] = new string[] { "Sophia", "93", "87", "98", "95", "100" };
grades[1] = new string[] { "Nicolas", "80", "83", "82", "88", "85" };
grades[2] = new string[] { "Zahirah", "84", "96", "73", "85", "79" };
grades[3] = new string[] { "Jeong", "90", "92", "98", "100", "97" };

// Calculate the overall grade and letter grade for each student
double[] overallGrades = new double[4];
char[] letterGrades = new char[4];
for (int i = 0; i < grades.Length; i++) {
    // Add up the scores for each assignment
    double totalScore = 0;
    for (int j = 1; j < grades[i].Length; j++) {
        totalScore += Double.Parse(grades[i][j]);
    }
    // Calculate the overall grade by dividing the total score by the number of assignments
    overallGrades[i] = totalScore / currentAssignments;
    // Determine the letter grade based on the overall grade using a switch statement
    switch ((int) Math.Floor(overallGrades[i] / 10)) {
        case 10:
        case 9:
            letterGrades[i] = 'A';
            break;
        case 8:
            letterGrades[i] = 'B';
            break;
        case 7:
            letterGrades[i] = 'C';
            break;
        case 6:
            letterGrades[i] = 'D';
            break;
        default:
            letterGrades[i] = 'F';
            break;
    }
}

// Display the overall grade and letter grade for each student
Console.WriteLine("Student\t\tGrade");
for (int i = 0; i < grades.Length; i++) {
    // Display the student's name, overall grade, and letter grade in a table format
    Console.WriteLine(grades[i][0] + "\t\t" + overallGrades[i].ToString("F1") + "\t\t" + letterGrades[i]);
}
