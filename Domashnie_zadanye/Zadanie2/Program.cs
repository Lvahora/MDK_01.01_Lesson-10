using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public abstract class Translator
    {
        public abstract string GetLanguage();
    }
    class EnglishTranslator : Translator
    {
        public override string GetLanguage()
        {
            return "Я перевеодчик с английского";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EnglishTranslator englishTranslator = new EnglishTranslator();
            Console.WriteLine(englishTranslator.GetLanguage());
            Console.ReadKey();
        }
    }
}