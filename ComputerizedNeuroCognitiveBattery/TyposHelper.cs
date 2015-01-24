using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerizedNeuroCognitiveBattery
{
    public static class TyposHelper
    {
        private static Dictionary<char, List<char>> _similarLetters;

        static TyposHelper()
        {
            _similarLetters = new Dictionary<char, List<char>>();
        
            _similarLetters['א'] = new List<char>() {'ע', 'ה'};
            _similarLetters['ב'] = new List<char>() { 'ו'};
            _similarLetters['ה'] = new List<char>() { 'ע', 'א' };
            _similarLetters['ו'] = new List<char>() { 'ב' };
            _similarLetters['ח'] = new List<char>() { 'כ' , 'ך' };
            _similarLetters['ט'] = new List<char>() { 'ת' };
            _similarLetters['כ'] = new List<char>() { 'ח' , 'ך' , 'ק'};
            _similarLetters['ך'] = new List<char>() { 'ח', 'כ', 'ק' };
            _similarLetters['מ'] = new List<char>() { 'ם' };
            _similarLetters['ם'] = new List<char>() { 'מ' };
            _similarLetters['נ'] = new List<char>() { 'ן' };
            _similarLetters['ן'] = new List<char>() { 'נ' };
            _similarLetters['ס'] = new List<char>() { 'ש' };
            _similarLetters['ע'] = new List<char>() { 'ה', 'א' };
            _similarLetters['פ'] = new List<char>() { 'ף' };
            _similarLetters['ף'] = new List<char>() { 'פ' };
            _similarLetters['צ'] = new List<char>() { 'ץ' };
            _similarLetters['ץ'] = new List<char>() { 'צ' };
            _similarLetters['ק'] = new List<char>() { 'כ' , 'ך'};
            _similarLetters['ש'] = new List<char>() { 'ס' };
            _similarLetters['ת'] = new List<char>() { 'ט' };
        }

        private static bool IsTypo(char original, char second)
        {
            return _similarLetters.ContainsKey(original) && _similarLetters[original].Contains(second);
        }

        public static bool EqualsIgnoringTypos(string original, string second)
        {
            original = original.Replace("יי", "י");
            second = second.Replace("יי", "י");

            if (original.Length == second.Length)
            {
                for (int i = 0; i < original.Length; i++)
                {
                    if (original[i] != second[i] && !IsTypo(original[i], second[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
