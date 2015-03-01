/* Write a program that encodes and decodes a string 
 * using given encryption key (cipher).
 * The key consists of a sequence of characters.
 * The encoding/decoding is done by performing XOR (exclusive or) 
 * operation over the first letter of the string with 
 * the first of the key, the second – with the second, etc. 
 * When the last key character is reached, the next is the first.
 */

using System;
using System.Collections.Generic;
class EncodeDecode
{
    static void XOREncode(char[] notEncoded, char[] key, List<char> encoded)
    {
        for (int i = 0; i < notEncoded.Length; )
        {
            for (int j = 0; j < key.Length && i < notEncoded.Length; j++)
            {
                encoded.Add((char)(notEncoded[i] ^ key[j]));
                Console.Write("'{0}' ^ '{1}' = ", notEncoded[i], key[j]);
                Console.WriteLine("\\u{0}", ((int)encoded[i]).ToString("X4"));
                i++;
            }
        }
    }
    static void XORDecode(List<char> encoded, char[] key)
    {
        List<char> decoded = new List<char>();
        for (int i = 0; i < encoded.Count; )
        {
            for (int j = 0; j < key.Length && i < encoded.Count; j++)
            {
                decoded.Add((char)(encoded[i] ^ key[j]));
                Console.Write("\\u{0}", ((int)encoded[i]).ToString("X4"));
                Console.WriteLine(" ^ '{0}' = '{1}'", key[j], decoded[i]);
                i++;
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter a string to ENCODE: ");
        char[] notEncoded = Console.ReadLine().ToCharArray();
        Console.Write("Enter an encryption key: ");
        char[] key = Console.ReadLine().ToCharArray();

        List<char> encoded = new List<char>();

        Console.WriteLine("\nEncoded (unicode representation): ");
        XOREncode(notEncoded, key, encoded);
        Console.WriteLine("\nDecoded: ");
        XORDecode(encoded, key);

        Console.WriteLine();
    }
}