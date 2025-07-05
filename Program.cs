string studentName = "Sophia Newton";
string course1Name = "English 101";
string course2Name = "Maths 101";
string course3Name = "Chemistry 103";
string course4Name = "Biology 102";
string course5Name = "Computer Science I";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 2;
int course5Credit = 4;

int gradeA = 5;
int gradeB = 4;
int gradeC = 3;

int course1Grade = gradeB;
int course2Grade = gradeA;
int course3Grade = gradeB;
int course4Grade = gradeC;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine($"Course \t\t\tGrade \t\tCredit Hours");
Console.WriteLine($"{course1Name} \t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name} \t\t{course2Grade} \t\t{course2Credit}");
Console.WriteLine($"{course3Name} \t\t{course3Grade} \t\t{course3Credit}");
Console.WriteLine($"{course4Name} \t\t{course4Grade} \t\t{course4Credit}");
Console.WriteLine($"{course5Name} \t{course5Grade} \t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t {leadingDigit}.{firstDigit}{secondDigit}");