using System;

namespace Hangman.Models
{
    public class HangmanGame
    {
        private string _secretWord;
        private int _wrongGuess;
        private string _userGuess;
        private string _hiddenWord;
        public static string[] wordArray = new string[] {"apple", "bee", "cinnamon"};
        public HangmanGame(string newSecretWord)
        {
            _secretWord = newSecretWord;
            _wrongGuess = 0;
            _hiddenWord = new String('_', newSecretWord.Length);

        }

        public string GetUserGuess()
        {
            return _userGuess;
        }

        public void SetUserGuess(string newUserGuess)
        {
            _userGuess = newUserGuess;
        }

        public string GetSecretWord()
        {
            return _secretWord;
        }

        public int GetWrongGuess()
        {
            return _wrongGuess;
        }
        public void SetWrongGuess(int newWrongGuess)
        {
            _wrongGuess = newWrongGuess;
        }

        // public Hangman randomHangman()
        // {
        //     return Hangman newHangman = new Hangman(Hangman.WordArray[rand.Next(0,3)]);
        // }

        public string GetHiddenWord()
        {
            return _hiddenWord;
        }

        public void SetHiddenWord(string newHiddenWord)
        {
            _hiddenWord = newHiddenWord;
        }
        public static string[] GetWordArray()
        {
            return wordArray;
        }
    }

}
