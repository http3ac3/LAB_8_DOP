using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8_DOP
{
    public partial class Form1 : Form
    {
        string openText;
        string keyWord;
        int bias;
        char[] alphabet = {'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п',
                           'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        public Form1()
        {
            InitializeComponent();
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = null;
            openText = OpenTextTB.Text.ToLower();
            keyWord = KeyWordTB.Text.ToLower();
            bias = Convert.ToInt32(BiasTB.Value);

            List<char> newAlphabet = new List<char>();

            for (int i = bias - 1; i >=0; i--)
            {
                newAlphabet.Add(alphabet[31 - i]);
            }

            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!newAlphabet.Contains(keyWord[i]))
                    newAlphabet.Add(keyWord[i]);
            }

            for (int i = 0; i < alphabet.Length - bias; i++)
            {
                if (!newAlphabet.Contains(alphabet[i]))
                    newAlphabet.Add(alphabet[i]);
            }
            AnswerTB.Text += "Исходный алфавит >>";
            for (int i = 0; i < alphabet.Length; i++)
            {
                AnswerTB.Text += alphabet[i];
            }
            AnswerTB.Text += "\nНовый алфавит >>\t     ";
            for (int i = 0; i < newAlphabet.Count; i++)
            {
                AnswerTB.Text += newAlphabet[i];
            }
            
            string cipheredText = "";

            for (int i = 0; i < openText.Length; i++)
            {
                if (openText[i] == ' ')
                {
                    cipheredText += ' ';
                    continue;
                }
                int index = Array.IndexOf(alphabet, openText[i]);
                cipheredText += newAlphabet[index];
            }

            AnswerTB.Text += $"\nЗашифрованное слово >> {cipheredText}";
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = null;
            openText = OpenTextTB.Text.ToLower();
            keyWord = KeyWordTB.Text.ToLower();
            bias = Convert.ToInt32(BiasTB.Value);

            List<char> newAlphabet = new List<char>();

            for (int i = bias - 1; i >= 0; i--)
            {
                newAlphabet.Add(alphabet[31 - i]);
            }

            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!newAlphabet.Contains(keyWord[i]))
                    newAlphabet.Add(keyWord[i]);
            }

            for (int i = 0; i < alphabet.Length - bias; i++)
            {
                if (!newAlphabet.Contains(alphabet[i]))
                    newAlphabet.Add(alphabet[i]);
            }
            AnswerTB.Text += "Исходный алфавит >>";
            for (int i = 0; i < alphabet.Length; i++)
            {
                AnswerTB.Text += alphabet[i];
            }
            AnswerTB.Text += "\nНовый алфавит >>\t     ";
            for (int i = 0; i < newAlphabet.Count; i++)
            {
                AnswerTB.Text += newAlphabet[i];
            }
            
            string decipheredText = "";

            for (int i = 0; i < openText.Length; i++)
            {
                if (openText[i] == ' ')
                {
                    decipheredText += ' ';
                    continue;
                }
                int index = Array.IndexOf(newAlphabet.ToArray(), openText[i]);
                decipheredText += alphabet[index];
            }

            AnswerTB.Text += $"\nРасшифрованное слово >> {decipheredText}";
        }
    }
}
