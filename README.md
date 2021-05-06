The program you are given defines a metals dictionary, where names are used as keys and their price for 1 gram as values. It takes the name and the price of 5th metal as input.
Add the 5th pair to the dictionary and write code to output the message about the most expensive metal in the dictionary.

Sample Input
Rhodium
225

Sample Output
The most expensive: Rhodium


Hint
The given int[] prices = metals.Values.ToArray() line creates an array with values of the dictionary. You should sort its elements, and the last element will be the largest.
Then you should find a way to output the key that has that max value in the dictionary.


The Keys property gets an indexed collection containing only the keys contained in the dictionary.
