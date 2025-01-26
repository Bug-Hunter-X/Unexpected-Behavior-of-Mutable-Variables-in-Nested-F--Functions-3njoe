# Unexpected Mutable Variable Behavior in F#

This repository demonstrates a subtle bug related to the behavior of mutable variables in F# when accessed within nested functions. The issue arises from how F# handles closures and variable scoping, leading to unexpected results when modifying mutable variables from an outer scope within an inner function.

The `bug.fs` file contains the code exhibiting the problem.  The `bugSolution.fs` file shows a corrected version using appropriate techniques to resolve the issue.

## Bug Description

The original code attempts to swap two mutable variables using a nested function.  While a similar approach works correctly when the variables are passed as arguments to the swapping function, the behavior is unexpected when the inner function accesses mutable variables directly from the outer scope.

## Solution

The solution demonstrates the correct way to handle this situation by either passing the variables as arguments or using techniques to ensure proper mutable variable handling within nested scopes. 