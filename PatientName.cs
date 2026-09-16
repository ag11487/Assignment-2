using System;

class Program
{
    static void Main()
    {
        string patientName;

        Console.WriteLine("Who is being seen today?");
        patientName = Console.ReadLine();

        Console.WriteLine("Welcome: " + patientName);