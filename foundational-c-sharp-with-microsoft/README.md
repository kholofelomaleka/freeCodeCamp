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
3. Perform Basic String Formatting in C#
4. Perform Basic Operations on Numbers in C#
5. Guided Project - Calculate and Print Student Grades
6. Guided Project - Calculate Final GPA
7. Trophy - Write Your First Code Using C#
