/* UserInterface.cs
 * Author: Samuel Allred
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ksu.Cis300.TrieLibrary;

namespace Ksu.Cis300.Boggle
{
    /// <summary>
    /// A user interface for a program that finds all words in a randomly-generated Boggle Deluxe board.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The length and width of the grid.
        /// </summary>
        public const int GridSize = 4;

        /// <summary>
        /// The current board contents.
        /// </summary>
        private string[,] _board = new string[GridSize, GridSize];

        /// <summary>
        /// The word finder.
        /// </summary>
        private WordFinder _wordFinder;

        /// <summary>
        /// The random number generator.
        /// </summary>
        private Random _randomNumbers = new Random();

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            GenerateNewBoard();
        }

        /// <summary>
        /// Generates a new game board.
        /// </summary>
        private void GenerateNewBoard()
        {
            uxBoard.Controls.Clear();
            for (int i = 0; i < GridSize; i++)
            {
                FlowLayoutPanel row = new FlowLayoutPanel();
                row.AutoSize = true;
                row.FlowDirection = FlowDirection.LeftToRight;
                row.WrapContents = false;
                uxBoard.Controls.Add(row);

                for (int j = 0; j < GridSize; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.MaxLength = 1;
                    textBox.CharacterCasing = CharacterCasing.Upper; // optional - force uppercase

                    // Prompt the user to enter a character
                    Form prompt = new Form();//
                    prompt.Width = 200;
                    prompt.Height = 150;
                    prompt.Text = "Game Pigeon: Word Hunt Solver";
                    Label promptLabel = new Label() { Left = 50, Top = 20, Text = "Enter a character for the cell " + j};
                    TextBox promptTextBox = new TextBox() { Left = 50, Top = 50, Width = 100 };
                    Button confirmation = new Button() { Text = "Ok", Left = 50, Top = 80, Width = 50, DialogResult = DialogResult.OK };
                    confirmation.Click += (sender, e) => { prompt.Close(); };
                    prompt.Controls.Add(promptLabel);
                    prompt.Controls.Add(promptTextBox);
                    prompt.Controls.Add(confirmation);
                    prompt.AcceptButton = confirmation;

                    if (prompt.ShowDialog() == DialogResult.OK)
                    {
                        textBox.Text = promptTextBox.Text;
                        _board[i, j] = textBox.Text;
                    }
                    else
                    {
                        // Exit the application if user cancels
                        Application.Exit();
                    }//
                    
                    row.Controls.Add(textBox);                    
                }
            }
        }

        /// <summary>
        /// Obtains the file of allowable words from the user when the form loads.
        /// </summary>
        /// <param name="e">Information about the Load event.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            uxOpenDialog.ShowDialog();
            try
            {
                _wordFinder = new WordFinder(_board, uxOpenDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
        }

        private TextBox[,] CreateTextBoxArray(string[,] letters)
        {
            int size = letters.GetLength(0);
            TextBox[,] textBoxArray = new TextBox[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = letters[i, j];
                    textBoxArray[i, j] = textBox;
                }
            }
            return textBoxArray;
        }

        /// <summary>
        /// Handles a Click event on the New Board button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewBoard_Click(object sender, EventArgs e)
        {
            GenerateNewBoard();
        }

        private void uxFindWords_Click(object sender, EventArgs e)
        {
            uxWordsFound.Items.Clear();
            uxWordsFound.BeginUpdate();
            ITrie results = _wordFinder.GetAllWords();
            results.AddAll(new StringBuilder(), uxWordsFound.Items);
            uxWordsFound.EndUpdate();
        }
    }
}
