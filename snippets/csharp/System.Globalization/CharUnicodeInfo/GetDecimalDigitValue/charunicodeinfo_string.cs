﻿// The following code example shows the values returned by each method for different types of characters.

// <snippet1>
using System;
using System.Globalization;

public class SamplesCharUnicodeInfo  {

   public static void Main()  {

      // The String to get information for.
      String s = "a9\u0393\u00B2\u00BC\u0BEF\u0BF0\u2788";
      Console.WriteLine( "String: {0}", s );

      // Print the values for each of the characters in the string.
      Console.WriteLine( "index c  Num   Dig   Dec   UnicodeCategory" );
      for ( int i = 0; i < s.Length; i++ )  {
         Console.Write( "{0,-5} {1,-3}", i, s[i] );
         Console.Write( " {0,-5}", CharUnicodeInfo.GetNumericValue( s, i ) );
         Console.Write( " {0,-5}", CharUnicodeInfo.GetDigitValue( s, i ) );
         Console.Write( " {0,-5}", CharUnicodeInfo.GetDecimalDigitValue( s, i ) );
         Console.WriteLine( "{0}", CharUnicodeInfo.GetUnicodeCategory( s, i ) );
      }
   }
}


/*
This code produces the following output.  Some characters might not display at the console.

String: a9Γ²¼௯௰➈
index c  Num   Dig   Dec   UnicodeCategory
0     a   -1    -1    -1   LowercaseLetter
1     9   9     9     9    DecimalDigitNumber
2     Γ   -1    -1    -1   UppercaseLetter
3     ²   2     2     -1   OtherNumber
4     ¼   0.25  -1    -1   OtherNumber
5     ௯   9     9     9    DecimalDigitNumber
6     ௰   10    -1    -1   OtherNumber
7     ➈   9     9     -1   OtherNumber

*/

// </snippet1>
