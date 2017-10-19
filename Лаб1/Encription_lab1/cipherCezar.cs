using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encription_lab1
{
    class cipherCezar
    {
        //Шифр Цезаря
        public string Encryption(string text)
        {
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (text[i] == alph[j]) res.Append(alph[(j + 10) % alph.Length]);

            return res.ToString();
        }

        public string Decryption(string crypt)
        {
            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (crypt[i] == alph[j]) res.Append(alph[(j - 10 + alph.Length) % alph.Length]);

            return res.ToString();
        }
    }
}
