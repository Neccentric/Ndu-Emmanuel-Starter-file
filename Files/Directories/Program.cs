﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Directories

const string classFile = "TextDir";

// TODO: Create a Directory if it doesn't already exist
if (!Directory.Exists(classFile)) {
    Directory.CreateDirectory(classFile);
}
else {
    Directory.Delete(classFile);
}

// TODO: Get the path for the current directory
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory is {curpath}");

// TODO: Just like with files, you can retrieve info about a directory
DirectoryInfo di = new DirectoryInfo(curpath);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTimeUtc}");
Console.WriteLine("--------------");

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in thedirs) {
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

// Console.WriteLine("Just files:");

// Console.WriteLine("---------------");

// Console.WriteLine("All directory contents:");
