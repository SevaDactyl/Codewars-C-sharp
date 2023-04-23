/*
DESCRIPTION:
Note: This kata is inspired by Convert a Number to a String!. Try that one too.

Description
We need a function that can transform a string into a number. What ways of achieving this do you know?

Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.

Examples
"1234" --> 1234
"605"  --> 605
"1405" --> 1405
"-7" --> -7
*/

using System;

public class Kata
{
    public static int StringToNumber(String str)
    {
        //TODO: Convert str into a number
        return Convert.ToInt32(str);
    }
}

/*
Tasks are the property of Codewars (https://www.codewars.com/) and users of this resource.

All solution code in this repository is the personal property of Vsevolod Rukavishnikov

Copyright (C) 2023 Vsevolod Rukavishnikov

This file is part of the SevaDactyl/Codewars-C-sharp (https://github.com/SevaDactyl/Codewars-C-sharp)

License is GNU General Public License v3.0 (https://github.com/SevaDactyl/Codewars-C-sharp/blob/main/LICENSE)

You should have received a copy of the GNU General Public License v3.0 along with this code. If not, see http://www.gnu.org/licenses/
*/