//Coding Challenges Grade Calculator 

const string POINTS_INFO = "How much points did you gather at the test? (max 20 points) ";

int firstTest = 0;
int secondTest = 0;
int grade = 0;
int possiblePoints = 40;

Console.Clear();

Console.WriteLine("Hello and welcome to the grade calculator!");

Console.Write("Did you participate in the first written exam? [Yes/No] ");
string decision = Console.ReadLine()!;
if (decision == "Yes" || decision == "yes")
{
    Console.Write(POINTS_INFO);
    firstTest = int.Parse(Console.ReadLine()!);
}
else { possiblePoints -= 20; }
Console.Write("Did you participate in the second written exam? [Yes/No] ");
decision = Console.ReadLine()!;
if (decision == "Yes" || decision == "yes")
{
    Console.Write(POINTS_INFO);
    secondTest = int.Parse(Console.ReadLine()!);
}
else { possiblePoints -= 20; }

double percent = 100d *((secondTest + firstTest) / possiblePoints);

if (percent >= 89) { grade = 1; }
else if (percent >= 76) { grade = 2; }
else if (percent >= 63) { grade = 3; }
else if (percent >= 50) { grade = 4; }
else { grade = 5; }

Console.WriteLine($"Your grade is {grade}");


