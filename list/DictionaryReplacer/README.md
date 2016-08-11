## Dictionary replacer Kata

This kata is about making a simple string replacer.

Create a method that takes a string and a dictionary, and replaces every key in the dictionary pre and suffixed with a dollar sign, with the corresponding value from the Dictionary.

### Suggested test cases

Tests

input :

    "", dict empty,

output:

    ""

input :

    "$temp$", dict ["temp", "temporary"],

output:

    "temporary"

input :

    "$temp$ here comes the name $name$",
    dict ["temp", "temporary"] ["name", "John Doe"],

output :

     "temporary here comes the name John Doe"


