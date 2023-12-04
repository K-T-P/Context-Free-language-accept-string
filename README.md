# Context-Free-language-accept-string
This implementatin receives a context-free grammar, simplifies it using removal of nullable variables and unit-productions and converts it to chomsky normal form. Then, receives a string and use CYK algorithm to check whether grammar produces given string or not.

**input** :
  In the first line, program receives an integer named 'n' which determines number of 
the grammar variables. In the next 'n' lines, program receives grammar variables and productions and in the last line, program receives a string to check whether it is produced by grammar or not.

**output** :
program prints "Accepted" in console if grammar produces string. Else, prints "Rejected".

## Example 1
**input**\
3\
\<S\> \-\> a\<S\>b \| a\<A\> \| b\<B\>\
\<A\> \-\> a\<A\> \| #\
\<B\> \-\> b\<B\> \| #\
aaab

**output**\
Accepted

## Example 2
**input**\
\<S\> \-\> \<S\>a \| \<S\>b \| a\<A\> \| \<B\>b \
\<A\> \-\> ab\<A\> \| \<B\>ca \| # \
\<B\> \-\> b\<B\> \| \<C\>f \
\<C\> \-\> a\<C\> \| # \
abbfcaba

**output**\
Rejected
