using System;
/*
 * Build a simple C# Help System using classes
 * C# 3.0: A Beginner's Guide
 * Chapter 4 'Try This' Question
 * HelpClassDemo.cs
 */

class Help
{
    public void HelpOn(char what)
    {
        switch(what)
        {
            case '1':
                Console.WriteLine("The if:\n");
                Console.WriteLine("if(condition) statement;");
                Console.WriteLine("else statement;\n");
                break;

            case '2':
               Console.WriteLine("The switch control statement:\n");
               Console.WriteLine("switch (expression) {\n case constant: statement sequence\nbreak;\n//...\n}\n");
                break;

            case '3':
               Console.WriteLine("The for loop:\n");
               Console.WriteLine("for (initialization; condition; iteration)");
               Console.WriteLine(" statement;\n");
                break;

            case '4':
               Console.WriteLine("The while loop:\n");
               Console.WriteLine("while (condition) statement;\n");
                break;

            case '5':
               Console.WriteLine("The do-while loop:\n");
               Console.WriteLine("do {\n statement");
               Console.WriteLine("while (condition);\n");
                break;

            case '6':
               Console.WriteLine("The break:\n");
               Console.WriteLine("break; or break label;\n");
                break;

            case '7':
               Console.WriteLine("The continue:\n");
               Console.WriteLine("continue; or continue label;\n");
                break;

            case '8':
                Console.WriteLine("The goto: \n");
                Console.WriteLine("goto label;\n");
                break;
        }
    }
    public void ShowMenu()
    {
        // Display the help menu
       Console.WriteLine("Help on: \n 1. if \n 2. switch\n 3. for\n 4. while\n 5. do-while\n 6. break\n 7. continue\n 8. goto\n");
       Console.Write("Choose one (q to quit): ");
    }
    public bool isValid(int ch)
    {
        if (ch < '1' | ch > '8' & ch != 'q')
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

class HelpClassDemo
{
    static void Main()
    {

        char choice;

        Help hlpobj = new Help();

        // infinite loop
        for (;;)
        {
            do {
                hlpobj.ShowMenu();     

                do {
                    choice = (char) Console.Read();
                } while (choice == '\n' | choice == '\r');

            } while (!hlpobj.isValid(choice));

            if (choice == 'q')
            {
                break;
            }

            Console.WriteLine("\n");
            hlpobj.HelpOn(choice);
        }
    }
  }