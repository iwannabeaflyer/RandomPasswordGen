using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        Random random = new Random();
        const int PASSWORDMINLENGTH = 8;
        const int MAXMININCLUDELENGTH = 5;
        const string CHARS = "0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*?-_=+";
        private int passwordLength;
        private int includeLength = 0;
        private bool HasUppercase = false;
        private bool HasNumbers = false;
        private bool HasSymbols = false;
        private bool RandomizeIncluded = false;
        private string password = String.Empty;

        public PasswordGenerator()
        {
            InitializeComponent();
            LengthComboBox.SelectedIndex = 0;
        }

        private void GeneratePassword(object sender, EventArgs e)
        {
            UpdateValues();
            int start = 0;
            int end = 49;
            if (!HasNumbers) start = 10;
            if (!HasSymbols) end = 36;

            for (int i = 0; i < passwordLength; i++)
            {
                password += RandomizeLetterToChar(CHARS.ElementAt(GetRandomNumber(start, end)));
            }

            if (includeLength > 0)
            {
                string input = InputTextBox.Text;
                string output = String.Empty;

                if (RandomizeIncluded)
                {
                    for (int i = 0; i < includeLength; i++)
                    {
                        output += RandomizeLetterToChar(input[i]);
                    }
                }
                else
                {
                    output = input;
                }

                password = password.Insert(GetRandomNumber(0, password.Length), output);
            }
            OutputTextBox.Text = password;
        }

        private void UpdateValues()
        {
            includeLength = InputTextBox.Text.Length;
            passwordLength = LengthComboBox.SelectedIndex + PASSWORDMINLENGTH - includeLength;
            password = String.Empty;
            HasSymbols = SymbolsCheckBox.Checked;
            HasNumbers = NumbersCheckBox.Checked;
            HasUppercase = UppercaseCheckBox.Checked;
            RandomizeIncluded = IncludeBox.Checked;
        }

        private char RandomizeLetterToChar(char c)
        {
            c = RandomUpperOrLower(c);

            if (GetRandomBool()) return c;

            switch (c)
            {
                case 'a':
                    c = '@';
                    break;
                case 'e':
                    c = '3';
                    break;
                case 'i':
                    c = '!';
                    break;
                case 'o':
                    c = '0';
                    break;
                default:
                    break;
            }
            return c;
        }
        
        private int GetRandomNumber(int lower, int upper)
        {
            return random.Next(lower, upper);
        }

        private bool GetRandomBool()
        {
            return GetRandomNumber(0,2) == 1 ? true : false;
        }

        private char RandomUpperOrLower(char c)
        {
            if (!HasUppercase) return Char.ToLower(c);

            c = GetRandomBool() ? Char.ToUpper(c) : Char.ToLower(c);
            return c;
        }

        private void CopyClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputTextBox.Text);
            MessageBox.Show("Created password copied to clipboard.");
        }

        private void LengthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputTextBox.MaxLength = LengthComboBox.SelectedIndex + MAXMININCLUDELENGTH;
            int newlength = InputTextBox.MaxLength;
            string str = InputTextBox.Text.Substring(0, Math.Min(newlength, InputTextBox.Text.Length));

            if (InputTextBox.TextLength > 0)
            {
                InputTextBox.Text = str;
            }
            InputTextBox.Update();
        }
    }
}