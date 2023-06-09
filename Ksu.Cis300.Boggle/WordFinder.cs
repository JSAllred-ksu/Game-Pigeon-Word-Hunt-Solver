﻿/* WordFinder.cs
 * Author: Rod Howell
 * Edited by: Samuel Allred

In the `WordFinder` class:

1. Change the `_board` field to a 4x4 array.
2. In the `WordFinder` constructor, remove the `_board` parameter and its use, since the board is now passed as user input in `UserInterface`.
3. Update the `FindWords` method to use `UserInterface.GridSize` instead of `_board.GetLength(0)`.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.TrieLibrary;
using System.IO;
using System.Data.Common;
using System.Windows.Forms;

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
        private string[,] _board = new string[UserInterface.GridSize, UserInterface.GridSize];

        /// <summary>
        /// Constructs a new WordFinder for the given word list.
        /// </summary>
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

            for (int i = 0; i < UserInterface.GridSize; i++)
            {
                for (int j = 0; j < UserInterface.GridSize; j++)
                {
                    results = FindWords(i, j, used, prefix, _wordList, results);
                }
            }
            return results;
        }
    }
}