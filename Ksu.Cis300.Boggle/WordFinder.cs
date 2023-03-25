/* WordFinder.cs
 * Author: Rod Howell
 * Edited by: Samuel Allred
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.TrieLibrary;
using System.IO;
using System.Data.Common;

namespace Ksu.Cis300.Boggle
{
    /// <summary>
    /// Instances will find all words on a Boggle board.
    /// </summary>
    public class WordFinder
    {
        /// <summary>
        /// The minimum allowed length of a word.
        /// </summary>
        private const int _minimumWordLength = 4;

        /// <summary>
        /// The list of allowable words.
        /// </summary>
        private ITrie _wordList = new TrieWithNoChildren();

        /// <summary>
        /// The Boggle board contents.
        /// </summary>
        private string[,] _board;

        /// <summary>
        /// Constructs a new WordFinder for the given Boggle board and word list.
        /// </summary>
        /// <param name="board">The Boggle board.</param>
        /// <param name="fn">The name of the file containing the word list.</param>
        public WordFinder(string[,] board, string fn)
        {
            _board = board;
            using (StreamReader input = File.OpenText(fn))
            {
                while (!input.EndOfStream)
                {
                    string word = input.ReadLine();
                    if (word.Length >= _minimumWordLength)
                    {
                        _wordList = _wordList.Add(word);
                    }
                }
            }
        }

        /// <summary>
        /// finds available words on the board given the dictionary selected
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="used"></param>
        /// <param name="path"></param>
        /// <param name="completions"></param>
        /// <param name="words"></param>
        /// <returns>found words</returns>
        private ITrie FindWords(int row, int column, bool[,] used, StringBuilder path, ITrie completions, ITrie words)
        {
            ITrie foundWords = words;
            ITrie nextCompletions = completions.GetCompletions(_board[row, column]);
            
            if (nextCompletions == null)
            {
                return foundWords;
            }
            
            used[row, column] = true;
            path.Append(_board[row, column]);
            
            if (nextCompletions.Contains(""))
            {
                foundWords = foundWords.Add(path.ToString());
            }
            
            for (int i = Math.Max(0, row - 1); i <= Math.Min(UserInterface.GridSize - 1, row + 1); i++)
            {
                for (int j = Math.Max(0, column - 1); j <= Math.Min(UserInterface.GridSize - 1, column + 1); j++)
                {
                    if (!used[i, j])
                    {
                        foundWords = FindWords(i, j, used, path, nextCompletions, foundWords);
                    }
                }
            }

            path.Length -= _board[row, column].Length;
            used[row, column] = false;
            return foundWords;
        }

        /// <summary>
        /// Finds all the words on the board.
        /// </summary>
        /// <returns>A trie containing all the words on the board.</returns>
        public ITrie GetAllWords()
        {
            ITrie results = new TrieWithNoChildren();
            bool[,] used = new bool[UserInterface.GridSize, UserInterface.GridSize];
            StringBuilder prefix = new StringBuilder();

            for(int i = 0; i < UserInterface.GridSize; i++)
            {
                for(int j = 0; j < UserInterface.GridSize; j++)
                {
                    results = FindWords(i, j, used, prefix, _wordList, results);                
                }
            }
            return results;
        }
    }
}
