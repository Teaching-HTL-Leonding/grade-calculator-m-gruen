//Coding Challenges Grade Calculator 

const string POINTS_INFO = "How much points did you gather at the test? (max 20 points) ";

int firstTest = 0;
int secondTest = 0;
int homework = 0;
int grade = 0;
int possiblePoints = 60;

Console.Clear();

Console.WriteLine("Hello and welcome to the grade calculator!");

Console.Write("Did you participate in the first written exam? [Yes/No] "); //First test
string decision = Console.ReadLine()!;
if (decision == "Yes" || decision == "yes")
{
    Console.Write(POINTS_INFO);
    firstTest = int.Parse(Console.ReadLine()!);
}
else { possiblePoints -= 20; } //If she or he didn't participate the max points reduce

Console.Write("Did you participate in the second written exam? [Yes/No] "); //Second test
decision = Console.ReadLine()!;
if (decision == "Yes" || decision == "yes")
{
    Console.Write(POINTS_INFO);
    secondTest = int.Parse(Console.ReadLine()!);
}
else { possiblePoints -= 20; } //If she or he didn't participate the max points reduce

Console.Write("How much points did you get from homework? (max 20 points) "); //Homework
homework = int.Parse(Console.ReadLine()!);

double percent = 100d *(secondTest + firstTest + homework) / possiblePoints; //calculate the grade

if (percent >= 89) { grade = 1; }
else if (percent >= 76) { grade = 2; }
else if (percent >= 63) { grade = 3; }
else if (percent >= 50) { grade = 4; }
else { grade = 5; }

Console.WriteLine($"Your grade is {grade}"); //print the grade


