# Unexpected Behavior with Implicit Operator Overloading and Arithmetic Operations in C#

This example demonstrates a potential issue when using implicit operator overloading in C# with arithmetic operations.  Implicit conversions between a custom class and an integer are defined, but performing arithmetic directly on the custom class object can result in unexpected behavior or compiler errors if not properly handled. The solution provides a better approach to handling such scenarios.

## Bug
The `Bug.cs` file contains the code exhibiting the unexpected behavior.  The implicit operator overloads work correctly for simple assignments, but adding an integer to a `MyClass` object doesn't automatically leverage the implicit conversion to `int` before performing addition. 

## Solution
The `BugSolution.cs` file provides a solution that addresses this issue.