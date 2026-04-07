using HogwartsRegistry.Core;

var student = new Student { Name = "Hermione Granger", House = "Gryffindor" };
var wand = new WandAllocation { WandCore = "Dragon Heartstring", LengthInches = 10.75 };
var points = new HousePoints { Points = 50 };

Console.WriteLine($"Student:  {student.Name}, House: {student.House}, Id: {student.Id}");
Console.WriteLine($"Wand:     {wand.WandCore}, FK StudentId: {wand.StudentId}");
Console.WriteLine($"Points:   {points.Points}, FK StudentId: {points.StudentId}");

Console.WriteLine("\nNotice: StudentId is 0 on both children.");
Console.WriteLine("Nobody has saved the parent yet — so nobody has an Id to link to.");
Console.WriteLine("This is exactly the bug we'll spend steps 2–6 fixing properly.");