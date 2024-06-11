Implement a simple calculator with fluent syntax
var FluentCalculator = /* Some magic */;
FluentCalculator should be separated in two, the Values and the Operations, one can call the other, but cannot call one of his own.
A Value can call an Operation, but cannot call a value
FluentCalculator.one.plus FluentCalculator.one.one // error or "undefined", it's up to you.
An Operation can call a Value, but cannot call a operation
FluentCalculator.one.plus.two // this should have a value of 3 FluentCalculator.one.plus.plus // error or "undefined", it's up to you
Pairs of Value and Operation should be stackable to infinity
FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four // Should be -1
A Value should resolve to a primitive integer
FluentCalculator.one.plus.ten - 10 // Should be 1
Rules:
* Values in FluentCalculator should go from zero to ten.
* Supported Operations are plus, minus, times, dividedBy
* Rules mentioned above
* FluentCalculator should be stackable to infinity
* A Value can only call an Operation
* An Operation can only call a Value
* A Value should be resolvable to a primitive integer, if needed as such