// See https://aka.ms/new-console-template for more information


int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(num => num % 2 == 0);
Console.WriteLine("Even numbers:");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

int[] grades = { 90, 91, 95, 97, 92 };
double averageGrade = grades.Average();
Console.WriteLine("Average grade:" + averageGrade);


var sortedGrades = grades.OrderBy(grade => grade);
Console.WriteLine("Sorted grades:");
foreach (var grade in sortedGrades)
{
    Console.WriteLine(grade);
}


/////bonus
string[] cars = { "mercedes", "mercedes", "ferrari", "bmw", "toyota", "lexus" };
var groupedCars = cars.GroupBy(car => car);
Console.WriteLine("Grouped cars:");
foreach (var group in groupedCars)
{
    Console.WriteLine($"{group.Key}: {group.Count()} mention");
}



///////functions 

Console.Write("Enter your name: ");
string userName = Console.ReadLine();

GreetUser(userName);
    
     void GreetUser(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}


Console.WriteLine("Enter the mesurments of the box:");

Console.Write("Length: ");
double length = Convert.ToDouble(Console.ReadLine());

Console.Write("Width: ");
double width = Convert.ToDouble(Console.ReadLine());

Console.Write("Height: ");
double height = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("volume is "+ height*width*length);

