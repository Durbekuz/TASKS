// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// string text = "hELLo!!! wORLd";
// int word = 0,other = 0;


// for ( int i = 0; i < text.Length; i++)
// {
//     if (char.IsAscii(text[i])) word++;

//      else
//           other++;


// }
// Console.ForegroundColor = ConsoleColor.Green;
// System.Console.WriteLine($"Words: {word},Other: {other}");
// Console.ResetColor();
//============================================


// string result = "hELLo!!! wORLd";

// bool insideWord = false;

// for (int i = 0; i < result.Length; i++)
// {
//     if (result[i] != ' ' && !insideWord)
//     {
//         wordCount++;
//         insideWord = true;
//     }
//     else if (result[i] == ' ')
//     {
//         insideWord = false;
//     }// int wordCount = 0;

// }

// Console.WriteLine("So'zlar soni: " + wordCount);

//=====================================

// string text1 = "hELLo!!! wORLd";

// int count = 0;

// for (int i = 0; i < text1.Length; i++)
// {
//     if (text1[i] >= 'A' && text1[i] <= 'Z')
//     {
//         count++;
//     }
// }

// Console.WriteLine("Katta harflar soni: " + count);

//===============================================
// string[] text1 = ["hELLO  wORLd"];
// string text2 = string.Join(" ", text1);
// char[] chars =  text2.Reverse().ToArray(); 

// Console.WriteLine(string.Join("", chars)); 

// Console.WriteLine(text2);
//=================================
// char[] letters = text2.ToArray(); 

// for (int i = 0; i < letters.Length; i++)
// {
//      Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine(letters[i]);
//      Console.ResetColor();
// } 
 //===============================

//================================

// string text1 = "hELLo!!! wORLd";
// int wordCount =0;
// string vowels = "aeiou";
// text1 =text1.ToLower();
// for ( int c=0; c<text1.Length;c++)
// {
//    if(vowels.Contains(text1[c]))
//     {
//         wordCount++;
//     } 
// }
// Console.ForegroundColor = ConsoleColor.Blue;
// Console.WriteLine("Unli harflar soni:" + wordCount);
// Console.ResetColor();



