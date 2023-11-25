# Context-Free-language-accept-string
This code receives a context-free grammar, simplifies it and converts it to chomsky normal form. Then, receives a string to check whether grammar produces it or not.

input :
  In the first line, program receives an integer named 'n' which determines number of 
the grammar variables. In the next 'n' lines, program receives grammar variables and productions and in the last line, program receives a string to check whether it is produced by grammar or not.

output
program prints "Accepted" in console if grammar produces string. Else, prints "Rejected".

## Example 1
**input**\
3\
\<S\> \-\> a\<S\>b \| a\<A\> \| b\<B\>\
\<A\> \-\> a\<A\> \| #\
\<B\> \-\> b\<B\> \| #\
aaab

**output**\
Accepted\

## Example 2
