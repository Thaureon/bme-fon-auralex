# LeetCode Problem 9
## Problem
Palindrome Number
- Input: integer/int (x)
- Output: boolean/bool

## Solutions
Using  the same solution, the problem was converted to each language below.
- C#
    - FileName: CSharpSolution.cs
    - Notable differences:
        - Methods use Pascal Case.
        - length is a property in C# while it is a method in other languages.
        - Strings are treated as char arrays, so s[pos] get the character at a position.
        - var has been added to allow "dynamic" type setting.  Types are still type safe, but explicit setting is not needed.
- C++
    - FileName: CppSolution.cpp
    - Notable differences:
        - Methods use Camel Case.
        - Strings are treated as char arrays, so s[pos] get the character at a position.
        - to_string method is a method in the std namespace instead of a method on string or int classes.
        - access modifiers like public are sectional, so they only need to be set until another access modifier changes it.
- Java
    - FileName: JavaSolution.java
    - Notable differences:
        - Methods use Camel Case.
        - ToString method does not exist on string class as callable method, String.valueOf or Integer.toString should be used.
        - Strings are not accessible as char arrays like c# or C++, so charAt(pos) is needed to get character at a position.
- JavaScript
    - FileName: JavaScriptSolution.java
    - Notable differences:
        - length is a property in JavaScript while it is a method in other languages.
        - ToString method does exists, but ints can be converted with just "'' + x".
        - Strings can be accessed like a char arrays, so s[pos] get the character at a position.
        - var identifies a variable not a type as JavaScript is not type safe.
- TypeScript
    - FileName: TypeScriptSolution.java
    - Notable differences:
        - TypeScript is built on top of JavaScript, the intention was to add type safety.
        - let and var both identify variables in TypeScript/JavaScript.  The difference is scope.
        - Type is specified before setting the variable. "let s: string" sets s as a string.  One thing this does is allow compilers to more easily identify errors.
        - Methods and functions that work in javascript work in TypeScript as well.
- Python3
    - FileName: Python3Solution.java
    - Notable differences:
        - Methods use Camel Case
        - length is the method len(string), shortening from full name of length
        - Strings are treated as char arrays, so s[pos] get the character at a position.
        - Curly Brackets around sections of code is considered as a SyntaxError.
        - Semicolons to end statements are allowed, but not needed.
        - Indentation is how levels are defined.  Exiting an if or for loop does not have closing bracket, but indents return to same level as if or for
        - Colons indicate start of sections like if and for loops.
        - For loop does not have explicit (start; end; increment) style it uses syntax similar to c# foreach loop.

## Statistics
According to LeetCode Runtime Analysis.
- C#
    - Runtime - 2ms
    - Memory - 3.02 MB
- C++
    - Runtime - 7ms
    - Memory - 10.9 MB
- Java
    - Runtime - 6ms
    - Memory - 46.13 MB
- JavaScript
    - Runtime - 4ms
    - Memory - 64.48 MB
- TypeScript
    - Runtime - 7ms
    - Memory - 65.56 MB
- Python3
    - Runtime - 12ms
    - Memory - 17.36 MB
