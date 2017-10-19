using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encription_lab1
{
    public class cipherDigramm
    {
        string keyword = "";
        string lattice = "";
        string inputText = "";
        string ResText;
        string Pust = "";
        char[,] resh = new char[10, 16];
        string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "abcdefghijklmnopqrstuvwxyz" +
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя " +
            "!@\"#№$;%^:&?*()-_+={}[]\\/<>.,~`" +
            "0123456789";

        public void getTextAndKey(string key, string text)
        {
            inputText = text;
            keyword = key;
        }

        //проверка на повторки
        bool ChekKey()
        {
            for (int i = 1; i <= keyword.Length; i++)
            {
                for (int j = 1; j <= keyword.Length; j++)
                {
                    if ((keyword[i] == keyword[j]) && (i != j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //создание решетки
        public void CreateLattice()
        {
            lattice = keyword;
            for (int i = 1; i <= keyword.Length; i++)
            {
                for (int j = 1; j <= alph.Length; j++)
                {
                    if (keyword[i] == alph[j])
                    {
                        alph = alph.Remove(j, 1);
                    }
                }
            }
            lattice += alph; //строка с решеткой

            string str = "";
            int num = 1;

            for (int i = 0; i < 10; i++)
            {
                str = " ";
                for (int j = 0; j < 16; j++)
                {
                    str += lattice[num];
                    if (j != 16)
                    {
                        str += " ";
                        num++;
                    }
                }
            }

            //заполнение массива букв решетки
            num = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    resh[i, j] = lattice[num];
                    num++;
                }
            }
        }

        //выбор символа пустышки
        void ChoosePust()
        {
            int k = 0;
            int m = 1000;
            for (int i = 1; i <= lattice.Length; i++)
            {
                for (int j = 1; j <= inputText.Length; j++)
                    if (lattice[i] == inputText[j])
                        k++;

                if (k < m)
                {
                    m = k;
                    k = 0;
                    Pust = Convert.ToString(lattice[i]);
                }
            }
        }

        void EditText()
        {
            ChoosePust();    //выбор пустышки

            //вставка пустышки в повторяющиеся биграммы
            for (int i = 1; i < inputText.Length; i++)
                if (inputText[i] == inputText[i + 1])
                    inputText = inputText.Insert(i + 1, Pust);

            //проверка на четность текста, если нет, то добавляется пустышка в конец
            int Len = inputText.Length;
            if (Len % 2 != 0)
                inputText += Pust;
        }

        #region Шифрование
        public string Encode()
        {
            //Индексы букв в столбце
            int ind_x1 = 0;
            int ind_y1 = 0;
            int ind_x2 = 0;
            int ind_y2 = 0;
            ResText = "";

            int k = 1;
            while (k < inputText.Length)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (inputText[k] == resh[i, j])
                        {
                            ind_x1 = i;
                            ind_y1 = j;
                        } 

                        if (inputText[k + 1] == resh[i, j])
                        {
                            ind_x2 = i;
                            ind_y2 = j;
                        }
                    }
                }
                //буквы в одной строке
                if (ind_x1 == ind_x2)
                {
                    if (ind_y1 == 15)
                    {
                        ResText += resh[ind_x1, 0];
                        ResText += resh[ind_x2, ind_y2 + 1];
                    }
                    else
                    if (ind_y2 == 15)
                    {
                        ResText += resh[ind_x1, ind_y1 + 1];
                        ResText += resh[ind_x2, 0];
                    }
                    else
                    {
                        ResText += resh[ind_x1, ind_y1 + 1];
                        ResText += resh[ind_x2, ind_y2 + 1];
                    }
                }

                //буквы в одном столбце
                if (ind_y1 == ind_y2)
                {
                    if (ind_x1 == 9)
                    {
                        ResText += resh[0, ind_y1];
                        ResText += resh[ind_x2 + 1, ind_y2];
                    }
                    else
                    if (ind_x2 == 9)
                    {
                        ResText += resh[ind_x1 + 1, ind_y1];
                        ResText += resh[0, ind_y2];
                    }
                    else
                    {
                        ResText += resh[ind_x1 + 1, ind_y1];
                        ResText += resh[ind_x2 + 1, ind_y2];
                    }
                }

                //буквы в разных строках и столбцах
                if ((ind_x1 != ind_x2) && (ind_y1 != ind_y2))
                {
                    ResText += resh[ind_x1, ind_y2];
                    ResText += resh[ind_x2, ind_y1];
                }

                k = k + 2;
            }
            return ResText;
        }
        #endregion

        #region Расшифровка
        public string Decode()
        {
            ResText = "";
            // индексы букв в стобцах
            int ind_x1 = 0;
            int ind_y1 = 0;
            int ind_x2 = 0;
            int ind_y2 = 0;

            int k = 1;
            while (k < inputText.Length - 2)
            {
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 16; j++)
                    {
                        if (inputText[k] == resh[i,j])
                        {
                            ind_x1 = i;
                            ind_y1 = j;
                        }

                        if (inputText[k + 1] == resh[i,j])
                        {
                            ind_x2 = i;
                            ind_y2 = j;
                        }
                    }

                //буквы в одной строке
                if (ind_x1 == ind_x2)
                {
                    if (ind_y1 == 0)
                    {
                        ResText += resh[ind_x1, 15];
                        ResText += resh[ind_x2, ind_y2 - 1];
                    }
                    else
                    if (ind_y2 == 0)
                    {
                        ResText += resh[ind_x1, ind_y1 - 1];
                        ResText += resh[ind_x2, 15];
                    }
                    else
                    {
                        ResText += resh[ind_x1, ind_y1 - 1];
                        ResText += resh[ind_x2, ind_y2 - 1];
                    }
                }

                //буквы в одном столбце
                if (ind_y1 == ind_y2)
                {
                    if (ind_x1 == 0)
                    {
                        ResText += resh[9, ind_y1];
                        ResText += resh[ind_x2 - 1, ind_y2];
                    }
                    else
                    if (ind_x2 == 0)
                    {
                        ResText += resh[ind_x1 - 1, ind_y1];
                        ResText += resh[9, ind_y2];
                    }
                    else
                    {
                        ResText += resh[ind_x1 - 1, ind_y1];
                        ResText += resh[ind_x2 - 1, ind_y2];
                    }
                }

                //буквы в разных строках и столбцах
                if ((ind_x1 != ind_x2) && (ind_y1 != ind_y2))
                {
                    ResText += resh[ind_x1, ind_y2];
                    ResText += resh[ind_x2, ind_y1];
                }

                k = k + 2;
            }
            return ResText;
        }
#endregion
    }
}

