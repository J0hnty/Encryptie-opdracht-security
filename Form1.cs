using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_Sec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Encrypt(string text, int shift)
        {
            // Seperats the letters and puts it in an array
            char[] buffer = text.ToCharArray();
            // Loops though the userInput and applies the encryption
            for (int i = 0; i < buffer.Length; i++)
            {
                // For every letter/char in the array we are going to apply the shift
                char letter = buffer[i];
                // The shift is the amount of places the letter is going to shift up
                letter = (char)(letter + shift);
                // In the end it replaces the old value in the array
                buffer[i] = letter;
            }
            // Makes a new String to present back on the GUI as Result
            return new string(buffer);
        }

        private string Decrypt(string text, int shift)
        {
            // Seperats the letters and puts it in an array
            char[] buffer = text.ToCharArray();
            // Loops though the userInput and applies the decryption
            for (int i = 0; i < buffer.Length; i++)
            {
                // For every letter/char in the array we are going to apply the shift
                char letter = buffer[i];
                // The shift is the amount of places the letter is going to shift down
                letter = (char)(letter - shift);
                // In the end it replaces the old value in the array
                buffer[i] = letter;
            }
            // Makes a new String to present back on the GUI as Result
            return new string(buffer);
        }


        private void Submit_Button_Click(object sender, EventArgs e)
        {
            // Look at the input fields and Encrypt or Decrypt the values in the fields and show it on the GUI somewhere.
            string userInput = Input_textBox.Text;
            // Looks for the mode that is selected in the GUI
            string mode = combo_Box_Mode.SelectedItem?.ToString();
            // Is later filled with the encrypted or decrypted string
            string result = "";

            if (mode == "Encrypt")
            {
                // Sending the input and the shift to encryption function
                result = Encrypt(userInput, 3);
            }
            else if (mode == "Decrypt")
            {
                // Sending the input and the shift to decryption function
                result = Decrypt(userInput, 3);
            }
            // Here we set the output string to the other input field so you can copy it out if needed
            Output_textBox.Text = result;
        }


    }
}
