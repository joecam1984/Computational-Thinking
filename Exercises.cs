namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please Enter your first number");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstInt == secondNumber)
            {
                Console.WriteLine("Your numbers are equal");
            }
            else
            {
                Console.WriteLine("Your numbers are not equal");
            }




            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please Enter a number");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            if (firstInt % 2 == 1)
            {
                Console.WriteLine("Your number is odd");
            }
            else
            {
                Console.WriteLine("Your number is even");

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please Enter a letter in the alphabet");
            string letter = Console.ReadLine();


            switch (letter)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Your letter is a vowel");
                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("Your letter is a consonant");
                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
                    break;


            }
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please Enter your first number");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstInt == secondNumber)
            {
                Console.WriteLine(firstInt + " & " + secondNumber + " are equal");
            }
            else if (firstInt > secondNumber)
            {
                Console.WriteLine(firstInt + " is larger");
            }
            else
            {
                Console.WriteLine(secondNumber + " is larger");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please enter your number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber % 3 == 0)
            {
                Console.WriteLine("Your number is divisible by 3");
                Console.WriteLine(userNumber + " divided by 3 = " + userNumber / 3);
            }
            else
            {
                Console.WriteLine("You number is not divisible by 3");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            // Enter your solution here
            Console.WriteLine("Please write out your number between zero - ten");
            string numberWord = Console.ReadLine().ToLower();
            int number;

            switch (numberWord)
            {
                case "zero":
                    number = 0;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "one":
                    number = 1;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "two":
                    number = 2;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "three":
                    number = 3;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "four":
                    number = 4;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "five":
                    number = 5;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "six":
                    number = 6;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "seven":
                    number = 7;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "eight":
                    number = 8;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "nine":
                    number = 9;
                    Console.WriteLine("Your number in digits is: " + number);
                    ; break;
                case "ten":
                    number = 10;
                    Console.WriteLine("Your number in digits is: " + number);
                    break;
                default:
                    ; break;


            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }








        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Your first name has " + firstName.Length + " characthers");
            Console.WriteLine("Please enter your last/family name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your last name has " + lastName.Length + " characthers");

            if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Your First and Last Name are the same length");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Your First Name is longer");
            }
            else Console.WriteLine("Your Last Name is Longer");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please enter your name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the name again");
            string secondName = Console.ReadLine();
            ;

            if (firstName.Equals(secondName))
            {
                Console.WriteLine("The names are a perfect match");
            }
            else
            {
                Console.WriteLine("Sorry, the names do not match. Please know that names are case sensitive");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter where you were born");
            string userPlaceOfBirth = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ", you were born in " + userPlaceOfBirth + ".");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        //LOOPS SECTION
        //For this next section, in order to get a passing grade, each of the following problems must be solved using at least one of the the loop types we learned in class.

        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // SOLUTION HERE
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            Console.WriteLine("Please enter a number between 1-20");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = userNumber; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SquareOfEvenNumbers()
        {
            // For the numbers 1-9, if a number is even print the square of that number (number multiplied by itself) and if it is odd, just print the number

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // SOLUTION HERE
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();
            int userNumber;
            Console.WriteLine("Please enter a number between 1-9");
            userNumber = Convert.ToInt32(Console.ReadLine());

            while (userNumber > 9 || userNumber < 0);
            
            {
                

                if (userNumber % 2 == 0)
                {
                    Console.WriteLine(userNumber * userNumber);
                }
                else if (userNumber % 2 == 1)
                {
                    Console.WriteLine(userNumber);
                }
                else if (userNumber > 9 || userNumber < 0)
                {
                    Console.WriteLine("You have to enter a number between 1-9");
                }
            } 
                
                
                
                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");
            Console.WriteLine("Press Enter if you want to play");
            Console.ReadLine();


            // This reads the user's input and converts it to an integer.
            // We'll assume that users can only input integers.
            // SOLUTION HERE

            int userInput;

            do
            {
                Console.WriteLine("Your number must have something specific to win. Enter your number");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput % 3 == 0)
                {
                    Console.WriteLine("Correct, You Won");
                }
                else
                {
                    Console.WriteLine("Your number failed to meet requirements. Try Again!!");
                }


            }  while (userInput % 3 != 0);




            Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
        }

    }
}
