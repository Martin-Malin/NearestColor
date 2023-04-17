Cf. https://codingdojo.org/kata/NearestColor/

# Nearest color
## Introduction
A color is composed by an amount of red, green and blue.

In computer science, a way to represent a color is to compose between these three amount of colors.

Each amount of color have a presence from 0 (the color is absent) to 255 (full presence of color).

But, because some developers love hexadecimal, they decided to use numbers between 0 and F. So, 00 means 0 in decimal and FF means 255 in decimal.

For color composition, the first pair of digits are used for the red, the second pair for the green and last pair for the blue.

The hexadecimal representation of the colors looks like:

- FF0000 for **red**
- 00FF00 for **green**
- 0000FF for **blue**

But, for the exercice we decided to represent colors with only 3 digits, so the alias will be:

- F00 for FF0000
- 0F0 for 00FF00
- 00F for 0000FF
## Part 1: nearest color
The idea is to use a set of colors (F00, 0F0, 00F) and guess the nearest color from the set.

Example: the nearest color of F42 is F00.

## Part 2: equality
The idea is to list all the colors in equality cases, because, sometimes, more than one color is the nearest color.

Example: because yellow FF0 is composed by red F00 and green 0F0, the nearest colors are both of them.