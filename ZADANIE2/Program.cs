namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnglishTranslator translator = new EnglishTranslator();
            translator.GetLanguage();
        }
    }

    public abstract class Translator
    {
        public abstract void GetLanguage();
        
    }

    public class EnglishTranslator : Translator
    {
        public override void GetLanguage()
        {
            Console.WriteLine("Я переводчик с английского языка");
        }
    }
}