using System;
using System.Collections.Generic;

namespace Textbook_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Technical
            // 1 = Programmer
            // 2 = Databse
            // 3 = Object Oriented Design
            // 4 = Problem solving
            // Publishing
            // 1 = Editor
            // 2 = Reviewer
            // 3 = Mentor
            // 4 = Printer

            People john = new People("Keostafic", "John");
            People peter = new People("Nullfi", "Peter");
            People jake = new People("Entlosa", "Jake");
            People antonio = new People("Leoaram", "Antonio");
            People jacky = new People("Rustic", "Jacky");

            new TechnicalExpertise(john, "Programmer", "1");
            new TechnicalExpertise(john, "Database", "2");
            new PublishingExpertise(john, "Reviewer", "2");
            john.PrintExpert();

            new TechnicalExpertise(peter, "Programmer", "1");
            new PublishingExpertise(peter, "Editor", "1");
            new PublishingExpertise(peter, "Reviewer", "2");
            peter.PrintExpert();

            new TechnicalExpertise(jake, "Object Oriented Design", "3");
            new TechnicalExpertise(jake, "Problem Solving", "4");
            new PublishingExpertise(jake, "Reviewer", "2");
            new PublishingExpertise(jake, "Printer", "4");
            jake.PrintExpert();

            new TechnicalExpertise(antonio, "Database", "2");
            new PublishingExpertise(antonio, "Reviewer", "2");
            new PublishingExpertise(antonio, "Mentor", "3");
            new PublishingExpertise(antonio, "Printer", "4");
            antonio.PrintExpert();

            new TechnicalExpertise(jacky, "Programmer", "1");
            new PublishingExpertise(jacky, "Reviewer", "2");
            jacky.PrintExpert();

            Textbook pro102 = new Textbook("1", "Programming 102, An Extensive Look At C#. (2015)", "Pending Approval");
            pro102.PrintTextbook();
            jacky.PrintPeople();
            peter.PrintPeople();
            antonio.PrintPeople();
            Console.WriteLine();

            Textbook OODCD = new Textbook("3", "Object Oriented Design Complete Edition (2016)", "Finished Publishing");
            OODCD.PrintTextbook();
            jake.PrintPeople();
            peter.PrintPeople();
            antonio.PrintPeople();
            Console.WriteLine();

        }
    }
}
