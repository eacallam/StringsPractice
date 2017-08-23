using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Elizabeth";
            string lastName = "Callam";
            //the default string value is null, which cannot print (the below will not work)
            //string fullName;
            //can do the following
            string noName = "";
            //combining variables
            string fullName = firstName + " " + lastName;
            string.Concat(firstName, " ", lastName);

            Console.WriteLine(firstName.Length);
            Console.WriteLine(lastName.Length);
            //to access the E, you type:
            Console.WriteLine(firstName[0]);
            //another way of accessing a char (you can use a variable)
            Console.WriteLine(firstName[firstName.Length - 1]);
            //can't go beyond the number of total characters (beginning at indexed 0); the following produces an error:
            //Console.WriteLine(lastName[6]);

            //can check if strings are equal
            Console.WriteLine(fullName);

            Console.WriteLine(firstName.Equals(lastName));
            //(same as)
            Console.WriteLine(firstName == lastName);

            //using quotes, tabs, new lines, and sound in a string: escape special characters
            Console.WriteLine("My favorite book is\a\n\t \"The Notebook\"");

            //STRING METHODS
            //The ToUpper and ToLower methods of a string change their case to upper-case (ToUpper) or to lower-case (ToLower).
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(firstName.ToLower());

            //Replace
            string myStr = "We Can Code IT";
            Console.WriteLine(myStr);
            string replace = myStr.Replace("We", "I").ToUpper();
            Console.WriteLine(replace);

            //Substring 
            string example = "OneTwoThree";
            string sub = example.Substring(3, 8);
            Console.WriteLine(sub);

            //Remove
            string index = "Fothergill";
            string result = index.Remove(3);
            Console.WriteLine(result);

            //Case sensitive: indexof finds the first occurence and lastindexof finds the last occurence
            Console.WriteLine(fullName.IndexOf("e"));
            Console.WriteLine(fullName.LastIndexOf("e"));

            //Trim

            //ToString

            //If the first name is longer than the last name, print "First is longer."
            //If the first name and last name are the same length, print "Samsis!"
            //Otherwise, print "Last must be longer!"

            //Console.WriteLine("Please tell me your first name.");
            //string userFirstName = Console.ReadLine();
            //Console.WriteLine("Please tell me your last name.");
            //string userLastName = Console.ReadLine();

            //if (userFirstName.Length > userLastName.Length)
            //Console.WriteLine("First is longer.");

            //else if (userFirstName.Length == userLastName.Length)
            //Console.WriteLine("Samsis!");

            //else
            //Console.WriteLine("Last must be longer!");

            //Using the escape sequences for tab, backslash, new line, and bell sound, print result using one CW
            //Console.WriteLine("This is a tab\t.");
            //Console.WriteLine("This is a backspace \\.");
            //Console.WriteLine("And this is a bell sound\a .");

            //Comparing strings for equality 
            Console.WriteLine("Please tell me your first name.");
            string someonesName = Console.ReadLine();
            Console.WriteLine("Please tell me your friend's first name.");
            string anotherName = Console.ReadLine();

            if (someonesName == anotherName)
                Console.WriteLine("The names are the same.");
            else
                Console.WriteLine("The names are different.");

            if (someonesName.Equals(anotherName))
                Console.WriteLine("The names are the same.");
            else
                Console.WriteLine("The names are different.");

            //Concatenation
            Console.WriteLine("Please tell me your first name.");
            string userFirst = Console.ReadLine();
            Console.WriteLine("Please tell me your last name.");
            string userLast = Console.ReadLine();

            Console.WriteLine(userFirst + " " + userLast);
            Console.WriteLine(string.Concat(userFirst, " ", userLast));

            //String Method Practice
            Console.WriteLine("Guess the type of pet!!!");
            string correctAnswer = "cat";
            string yourAnswer = Console.ReadLine();

            if (correctAnswer.Equals(yourAnswer,
                StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("That's correct!");
            else
                Console.WriteLine("NOPE.");
        }
    }
}
