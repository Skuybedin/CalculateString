using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStringConsole
{
    internal interface ICalculate
    {
        string InputValue { get; set; }
        string GetLanguage();
        int CalcWordCount();
        int CalcVowelCount();
    }

    public class CalculateString : ICalculate
    {
        public string InputValue { get; set; }
        private static readonly string VowelsRu = "аоэеиыуёюя";
        private static readonly string VowelsEn = "aeiouy";
        private static readonly string RusLang = "йцукенгшщзхъфывапролджэячсмитьбюё";
        private static readonly string EngLang = "qwertyuiopasdfghjklzxcvbnm";

        public CalculateString(string InputValue)
        {
            if (InputValue == null || InputValue == string.Empty) throw new ArgumentNullException("input can not be empty or null");
            else this.InputValue = InputValue.Trim();

        }

        public string GetLanguage()
        {
            foreach (var letter in InputValue.ToLower())
            {
                if (EngLang.Contains(letter)) return "English";
                else if (RusLang.Contains(letter)) return "Русский";
            }

            return new Exception("Sorry, we support only Russian and English languages").Message;
        }

        public int CalcWordCount()
        {
            List<string> wordList = InputValue.Split(' ').ToList();
            int count = 0;
            foreach (var item in wordList)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (RusLang.Contains(item[i].ToString().ToLower()) || EngLang.Contains(item[i].ToString().ToLower()))
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        public int CalcVowelCount()
        {
            int count = 0;

            if (GetLanguage() == "English")
            {
                foreach (var letter in InputValue.ToLower())
                {
                    if (VowelsEn.Contains(letter)) count++;
                }
            }
            else if (GetLanguage() == "Русский")
            {
                foreach (var letter in InputValue.ToLower())
                {
                    if (VowelsRu.Contains(letter)) count++;
                }
            }

            return count;
        }
    }
}
