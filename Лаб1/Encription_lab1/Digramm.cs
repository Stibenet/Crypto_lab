using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encription_lab1
{
    class Digramm
    {
        List<string> array = new List<string>();
        string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string digrammKey = "";
        string text = "";
        string key = "";
        string shifr = "";
        int count = 0;
        int temp;

        public string Encrypt(string inputText, string inputKey)
        {
            try
            {
                //перевод в нижний регистр
                text = inputKey.ToLower();
                key = inputKey.ToLower();

                if (inputText.Length % 2 != 0) throw new ArgumentException("В тексте должно быть четное число символов");

                if (IsNumberContains(inputText) == true) throw new ArgumentException("Текст не должен содержать числа и знаки препинания");

                //если ключ не содержится в алфавите, то добавляем его
                for (int i = 0; i < alph.Length; i++)
                {
                    if (!key.Contains(text))
                    {
                        key += alph[i];
                    }
                }

                //ключ содержит 8 символов
                for (int i = 0; i < key.Length; i += 8)
                {
                    array.Add(key.Substring(i, 8));
                }

                for (int k = 0; k < text.Length; k += 2)
                {

                    if (StrNum(text[k]) == StrNum(text[k + 1]))
                    {
                        string str2 = array[temp];

                        count = str2.IndexOf(text[k]);
                        if (count == 7)
                            shifr += str2[0];
                        else shifr += str2[count + 1];

                        count = str2.IndexOf(text[k + 1]);
                        if (count == 7)
                            shifr += str2[0];
                        else shifr += str2[count + 1];

                    }
                    else if (StbNum(text[k]) == StbNum(text[k + 1]))
                    {
                        count = 0;
                        foreach (string f in array)
                        {
                            if (f[temp] == text[k])
                            {
                                if (count == 3)
                                    shifr += array[0][temp];
                                else shifr += array[count + 1][temp];
                            }
                            if (f[temp] == text[k + 1])
                            {
                                if (count == 3)
                                    shifr += array[0][temp];
                                else shifr += array[count + 1][temp];

                            }
                            count++;
                        }
                    }
                    else
                    {
                        shifr += array[StrNum(text[k])][StbNum(text[k + 1])];
                        shifr += array[StrNum(text[k + 1])][StbNum(text[k])];

                    }                   
                }
                
            }catch (Exception exp)
            {
                Console.WriteLine("Ошибка выполнения шифрования биграммами");
            }
            return shifr;
        }



        private int StrNum(char t)
        {
            int count = 0;
            foreach (string z in array)
            {
                if (z.IndexOf(t) != -1)
                {
                    temp = count;
                    return count;
                }
                count++;
            }
            return 1;
        }

        private int StbNum(char p)
        {
            int x;
            foreach (string z in array)
            {
                x = z.IndexOf(p);
                if (x != -1)
                {
                    temp = x;
                    return x;
                }
            }
            return 0;
        }


        static bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c) && Char.IsPunctuation(c))
                    return true;
            return false;
        }
    }
}
