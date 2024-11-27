using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffmanconsolecoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hellooo!";
            Console.WriteLine("Input text: " + input);

            HuffmanCoding huffman = new HuffmanCoding();
            string encode = huffman.Encode(input);

            Console.WriteLine("Danh sách kí tự kèm tần số và từ mã:");
            foreach (char c in huffman.Symbols)
            {
                Console.Write(c.ToString());
                Console.Write(" " + huffman.GetFrequency(c).ToString());
                Console.WriteLine(" " +huffman.GetCodeword(c).ToString());
            } 
            Console.WriteLine("Encode text: " +encode);
            Console.WriteLine("Decode text: " + huffman.Decode(encode));

            Console.ReadLine();
        }
    }
}
