## Reverse Polish Notation Kata

In reverse Polish notation the operators follow their operands; for instance, to add 3 and 4, one would write “3 4 +” rather than “3 + 4”. If there are multiple operations, the operator is given immediately after its second operand; so the expression written “3 – 4 + 5” in conventional notation would be written “3 4 – 5 +” in RPN: 4 is first subtracted from 3, then 5 added to it. An advantage of RPN is that it obviates the need for parentheses that are required by infix. While “3 – 4 * 5” can also be written “3 – (4 * 5)”, that means something quite different from “(3 – 4) * 5”. In postfix, the former could be written “3 4 5 * -“, which unambiguously means “3 (4 5 *) -” which reduces to “3 20 -“; the latter could be written “3 4 – 5 *” (or 5 3 4 – *, if keeping similar formatting), which unambiguously means “(3 4 -) 5 *”.

### Goal

The goal of this kata is to create a program that performs calculations using reverse Polish notation.

#### References

* [Wikipedia](http://en.wikipedia.org/wiki/Reverse_Polish_notation)
* [technologyconversations.com](https://technologyconversations.com/2014/03/28/java-8-tutorial-through-katas-reverse-polish-notation-medium/)