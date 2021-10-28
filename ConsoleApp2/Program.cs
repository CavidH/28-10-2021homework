using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversSentence("Hello World!"));
        }
        static string ReversSentence(string Sentence)
        {
            int Flag = 0;
            string ResultSentence = string.Empty;
            for (int i = 0; i < Sentence.Length; i++)
            {

                if (Sentence[i] == '.' || Sentence[i] == ',' || Sentence[i] == ' ' || Sentence[i] == '?' || Sentence[i] == '!' || Sentence[i] == ':')
                {
                    ResultSentence += ReverseWord(Sentence, i - 1, Flag) + Sentence[i];
                    // ResultSentence +=Sentence[i];
                    Flag = i + 1;
                }
            }
            return ResultSentence;
        }
        static string ReverseWord(string Word, int i, int Flag)
        {
            string Result = string.Empty;
            while (i >= Flag)
            {
                Result += Word[i];
                i--;
            }

            return Result;
        }
    }
}

