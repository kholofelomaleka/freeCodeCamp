FOUNDATIONAL C# WITH MICROSOFT CERTIFICATION

DAY 1: THE BASICS

1. Write Your First C# Code

Introduction
- C# programming language is used build many types of applications: 
    -- Business applications to capture, analyze, and process data
    -- Dynamic web applications that can be accessed from a web browser
    -- Games, both 2D and 3D
    -- Financial and scientific applications
    -- Cloud-based applications
    -- Mobile applications
- These apps are made up of lines of code that work together to achieve a task.
- The best way to learn code is to write code.
- This Module:
    -- Write first lines of C# code.
        Console.WriteLine("Hello World!");
        // Console.WriteLine("Hello!") - "//" Adds a comment.
        /* Console.WriteLine("Hello!") */ - "/* */ Adds multiple line comment.
    -- Use two different techniques to print a message as output.
        Console.WriteLine -- Adds a line feed similar to pressing Enter to create a new line. 
        Console.Write -- Prints the message on the same line
    -- Diagnose errors when code is incorrect.
        e.g. console.WriteLine("Hello World!");
        Output - (1,1): error CS0103: The name 'console' does not exist in the current context
        - (1,1) - indicates the line and column where the error occurred.
        - error CS0103 - error code, which indicates syntax (CASE SENSITIVE) error.
    -- Identify different C# syntax elements like operators, classes, and methods.
        - Programming Language: Lets you write instructions that a computer can carry out... The instructions are called source code.
        - Compilation: A program called a compiler converts source code into a format the computers central processing unit (CPU) can execute... The CPU understands instructions that are expressed by turing tiny switches on or off... Compilers bridge the gap between C# code and computer-understandable set of instructions.
        - Syntax: Rules for writing C# code... they define keywords and operators of C#, and how they are put together to form programs.
        - How Code Works: Console.WriteLine("Hello");
            -- Literal String - When a phrase surrounded by double quotes.
            -- Class - The "Console" part... Classes own methods... A class represents an object.
            -- . (period) - The dot Member Access Operator, how to navigate from class to one of its methods.
            -- Methods - Live inside a class... Has parenthesys after it known as method invocation operator, and has one job... some methods need input parameters, while others don't.
            -- ; (semi colon) - End of statement operator... tells the compiler the end of a command.
        - Common mistakes new programmers make:
            -- Entering lower-case letters instead of capitalizing C in Console, or the letters W or L in WriteLine.
            -- Entering a comma instead of a period between Console and WriteLine.
            -- Forgetting to use double-quotation marks, or using single-quotation marks to surround the phrase Hello World!
            -- Forgetting a semi-colon at the end of the command.

2. Store and Retrieve Data Using Literal and Variable Values in C#

- Literal Values
-- Data can be hard-coded, that is constant data that doesn't change throughout the execution of the prpogram... e.g. "success" message...
-- Hard-coded values can also be called Constant, or Literal value.
-- Literal Value
    - A value that is constant and never changes.
    - Using Character Literals:
	-- To get a single alphanumeric character printed, use "char literal" by surrounding one alphanumeric char in single quotes... e.g.:
	    - $ Console.WriteLine('a');
	    - If more than one alphanumeric value is entered, C# throws the following error:
		- error CS1012: Too many characters in character literal
    - Using Integer Literals:
	-- To display numeric whole numbers (no fractions) values, use INT Literals... e.g. 
	    - $ Console.WriteLine(123);
    - Using Floating-Point Literals:
	-- Float-point numbers contain a decimal... C# supports 3 data types to represent decimal numbers:
	    - float - ~6-9 digits
	    - double - ~15-17 digits, and 
	    - decimal - 28-29 digits
	-- e.g. 1) To create a float literal, append the letter F after the number... this is called a literal suffix. (can be lower or upper case), e.g.:
	    - Console.WriteLine(0.25F);
	-- e.g. 2) To create a double literal, just enter a decimal... the compiler defaults to a double when a decimal number is entered without a literal suffix, e.g.:
	    - Console.WriteLine(2.625);
	-- e.g. 3) To create a literal decimal, append the letter M after the number... e.g.:
	    - Console.WriteLine(12.39816m);
    - Using BOOLEAN Literals
	-- To print out a value representing either TRUE or FALSE, use a bool literal, which represents the idea of truth and falsehood... e.g.:
	    - Console.WriteLine(true);
	    - Console.WriteLine(false);	
    
    - Recap
	-- There are many data types, including:
	    - strings - For words, phrases, or any alphanumeric data for presentation, not calculation
	    - char - For a single alphanumeric character
	    - int - For a whole number
	    - decimal - For a number with a fractional component
	    - bool - For a true/false value

- Declaring Variables
-- When working with data that is not hard-coded.
-- A VARIABLE is a container for storing a type of value, that is not constant (changes) throughout the execution of the program... 
-- Variables can be assigned, read, and changed... They are stored for later use in the program.
-- A VARIABLE is a human-friendly label that the compiler assigns to a memory address.
-- To store, change, or retrieve values from the memory address, a variable can be used.

    - Declare A Variable
	-- To declare a variable, specify the type of variable and give it a name... e.g.:
	    - $ string firstName;
    - Variable Naming Rules & Conventions:
	-- Naming Rules:
	    - Variable names can contain alphanumeric and the underscore character... (Special chars like # (number/pound symbol) or $ are NOT allowed)
	    - Must begin with alphabetical letter or an underscore, not a number.
	    - Case Sensitive
	    - Must not be C# keywords like string or decimal.
	-- Conventions
	    - Use camel case, e.g. firstName
	    - Names must be descriptive and meaningful to the program
	    - Use one or more ENTIRE words
	    - Should NOT include the data type of the variable... e.g. string strName
    - Recap
	-- Variables are temporary values you store in the computer's memory.
	-- Before using a variable, declare it.
	-- To declare a variable, first select a data type for the kind of data to store, then give the variable a name that follows the rules.
	-- Assign (set) a value to a variable before retrieving (get) a value from a variable.
	-- Initialize a variable by assigning a value to the variable at the point of declaration.
	-- Assignment happens from right to left.
	-- Use a single equals character as the assignment operator.
	-- To retrieve the value from the variable, merely use the variable's name.

    - Declare implicitly typed local variables
	-- Implicitly typed local variable is created by using the var keyword followed by a variable initialization... e.g.:
	    - $ var message = "Hello World!";
	-- The var keyword tells the C# compiler that the data type is implied by the assigned value... The variable acts the same as if the actual data type has been used to declare it... The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context.


3. Perform Basic String Formatting in C#

- Combine strings using character escape sequences
    -- Exercise - Format literal strings in C#
	- Character Escape Sequence - An instruction to the runtime to insert a special character that will affect the output of the string... In C#, the backslash "\" follwed by the character being escaped is used... e.g. \n adds a new line and \t adds a tab.

    -- Exercise - Combine strings using string concatenation
	- Concatination is used to combine two or more string values into a new string value.
	    -- e.g. $ string message = greeting + " " + firstName + "!";
	- Avoiding intermediate variables - Don't declare unnecessary variables.

    -- Exercise - Combine strings using string interpolation
	- Used to combine many literal strings and variables into a single formatted message by using a "template" and one or more "interpolation expressions"
	- Interpolation Expression - indicated by an opening and closing curly brace symbol { }... this becomes a "template when its prefixed with the $ character.
	    -- e.g. $ string message = $"{greeting} {firstName}!";

    -- Combining Verbatim Literals and String Interpolation
	- Used when there's a need to use VERBATIM literals... this is prefixed with @ symbol and the $ symbol together...
	    -- e.g. $ Console.WriteLine($@"C:\Output\{projectName}\Data");
    -- Recap
	- String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
	- Combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.


4. Perform Basic Operations on Numbers in C#
- Perform addition with implicit data conversion
    -- Add two numeric values - Use "addition operator (+)"... The reuse of one symbol for multiple purposes is sometimes called "overloading the operatior".  When the + is surrounded by two numeric operands, the compiler parsres the code as numeric and adds the values. e.g.:
	- $ int firstNumber = 12;
	  $ int secondNumber = 7;
	  $ Console.WriteLine(firstNumber + secondNumber);
    -- Mix data types to force implicit type conversions - When using the + symbol with both a string and int, the compiler understands that it is concatination... It temporarily converts the int into a string... e.g.:
	- $ string firstName = "Bob";
	  $ int widgetsSold = 7;
	  $ Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
    -- Advanced case of adding numbers and concatenating strings - The compiler will still temporarily treat everything as a string and concatinate it together.
	- $ Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
    -- Add parentheses to clarify your intention to the compiler - The parentheses "()" become another overloaded operater, and forms "the order of operations" operator... The inner most parentheses get resolved first resulting in the addition of numeric operands... once resolved, it concatinates the rest... e.g.:
	- $ Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
    -- Add code to cast results of integer division - To divide two intiger variables without concatinating the result? Use CASTING, it instructs the compiler to temporarily treat a value as if it were different... e.g.:
	- $ int first = 7; int second = 5;
	  $ decimal quotient = (decimal)first / (decimal)second;
    -- Write code to determine the remainder after integer division - The modulus operator % gives teh remainder of int division.
	- $ Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

    -- Order of operations:
	- () symbols can be used as the order of operations operators. However, this isn't the only way the order of operations is determined.
	- In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:
	  1.) Parentheses (whatever is inside the parenthesis is performed first)
	  2.) Exponents
	  3.) Multiplication and Division (from left to right)
	  4.) Addition and Subtraction (from left to right)
    -- Recap
	- Use operators like +, -, /, and * to perform basic mathematical operations.
	- The division of two int values will result in the truncation of any values after the decimal point. To retain values after the decimal point, cast the divisor or dividend (or both) from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
	- Perform a cast operation to temporarily treat a value as if it were a different data type.
	- Use the % operator to capture the remainder after division.
	- The order of operations will follow the rules of the acronym PEMDAS.

    -- Increment and decrement values
	- (see exercises)

5. Guided Project - Calculate and Print Student Grades
6. Guided Project - Calculate Final GPA
7. Trophy - Write Your First Code Using C#
