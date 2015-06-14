/*
 Problem 3. Typeof variables
 Try typeof on all variables you created.
*/

var int = 5,
    float = Math.PI,
    bool = true,
    nullVar = null,
    nan = NaN,
    undefined = undefined,
    str = 'Hello, JS!',
    arr = ["Apple", "Banana", "Orange"],
    obj = {a: "foo", b: "bar", c: 42},
    regEx = /\w+/;

console.log(typeof(int) + '\n' + typeof(float) + '\n' + typeof(bool) + '\n' + typeof(nullVar) + '\n' + typeof(nan) + '\n' + typeof(undefined) + '\n' + typeof(str) + '\n' + typeof(arr) + '\n' + typeof(obj) + '\n' + typeof(regEx));