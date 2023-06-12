using System;
using System.Windows.Forms;
using System.IO;

namespace AmitaiHaHomo
{
    public partial class Form1 : Form
    {
        private string[] wordList;

        NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();

        NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();

        public Form1()
        {
            InitializeComponent();

            oDict.DictionaryFile = "en-US.dic";
            oDict.Initialize();
            oSpell.Dictionary = oDict;

            // Load the word list file
            string wordListPath = "D:/wordlist.txt"; // Replace with the actual path to your word list file
            LoadWordList(wordListPath);
        }

        private void LoadWordList(string wordListPath)
        {
            try
            {
                wordList = File.ReadAllLines(wordListPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading word list: " + ex.Message);
                // Handle the error or show an error message to the user
                // You may want to disable the functionality that requires word validation if the word list cannot be loaded
            }
        }

        public void check(string word)
        {
            if (oSpell.TestWord(word))
            {
                MessageBox.Show("Accurate word found: " + word);
            }
        }

        private void decryptedBtn_Click(object sender, EventArgs e)
        {
            string ciphertext = decryptedText.Text.ToUpper(); // Convert input to uppercase for consistency
            string plaintext = DecryptText(ciphertext, 14); // Use a fixed key value of 14

            if (!string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Decrypted text: " + plaintext);
            }
            else
            {
                MessageBox.Show("No accurate words were found.");
            }
        }

        private string DecryptText(string ciphertext, int key)
        {
            string decrypted = string.Empty;
            foreach (char symbol in ciphertext)
            {
                if (char.IsLetter(symbol))
                {
                    int num = symbol - 'A';
                    num = (num + 26 - 13) % 26; // Perform a left shift of 14
                    decrypted += (char)('A' + num);
                }
                else
                {
                    decrypted += symbol;
                }
            }
            return decrypted;
        }




        private bool IsValidWord(string word)
        {
            // Check if the word exists in the word list and passes the spell check
            return Array.IndexOf(wordList, word.ToLower()) >= 0 && oSpell.TestWord(word);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
