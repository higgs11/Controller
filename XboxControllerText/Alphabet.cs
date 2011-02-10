using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxControllerText
{
    class Alphabet
    {
        /// <summary>
        /// Initial pointer locations for entire alphabet
        /// </summary>
        private int START_INDEX;
        private int LAST_INDEX;
        private int MIDDLE_INDEX;

        /// <summary>
        /// Pointers for current search selection
        /// </summary>
        private int _leftIndex;
        private int _rightIndex;
        private int _currentIndex;

        /// <summary>
        /// Letter ordering option that is currently selected.
        /// </summary>
        private eLetterOrder _currentLetterOrder;


        /// <summary>
        /// Enumeration for letter ordering options
        /// </summary>
        public enum eLetterOrder
        {
            ALPHABETICAL = 0,
            MORSE_CODE,
        }

        //Alphabetic Ordering        
        public readonly char[] LettersAlphabeticalOrder = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                        'J', 'K', 'L', 'M', 'N', ' ', 'O', 'P', 'Q', 'R', 'S',
                                        'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
         

        //Morse Code Ordering
        public readonly char[] LettersMorseCodeOrder = new char[] { 'H', 'S', 'V', 'I', 'F', 'U', ' ', 'E', 'L', 'R', ' ', 'A', 
                                    'P', 'W', 'J', ' ', 'B', 'D', 'X', 'N', 'C', 'K', 'Y', 
                                    'T', 'Z', 'G', 'Q', 'M', ' ', 'O', ' ' };
        
        //Letters currently in use
        private char[] Letters;

        /// <summary>
        /// Default Constructor.  Uses Alphabetical letter ordering.
        /// </summary>
        public Alphabet()
            : this(eLetterOrder.ALPHABETICAL)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Alphabet(eLetterOrder letterOrder)
        {
            this.SetLetterOrder(letterOrder);            
        }

        /// <summary>
        /// Reset the current pointers to include the entire alphabet.
        /// </summary>
        public void ResetSearchIndexes()
        {
            
            _leftIndex = START_INDEX;
            _rightIndex = LAST_INDEX;
            _currentIndex = MIDDLE_INDEX;
        }


        /// <summary>
        /// Set the ordering of the letters.  Either flat alphabetical ordering, or
        /// ordering that makes the code sequences per letter the same as morse code.
        /// </summary>
        /// <param name="letterOrder"></param>
        public void SetLetterOrder(eLetterOrder letterOrder)
        {
            _currentLetterOrder = letterOrder;

            switch (_currentLetterOrder)
            {
                case eLetterOrder.ALPHABETICAL:
                    Letters = LettersAlphabeticalOrder;
                    break;

                case eLetterOrder.MORSE_CODE:
                    Letters = LettersMorseCodeOrder;
                    break;

                default:
                    _currentLetterOrder = eLetterOrder.ALPHABETICAL;
                    Letters = LettersAlphabeticalOrder;
                    throw new Exception("Enumeration not defined in eLetterOrder: " + _currentLetterOrder.ToString());
                    
            }
          

            START_INDEX = 0;
            LAST_INDEX = Letters.Length - 1;
            MIDDLE_INDEX = (LAST_INDEX - START_INDEX) / 2;

            this.ResetSearchIndexes();

        }

        /// <summary>
        /// Get the new set of letters that would be selected to the left.
        /// </summary>
        /// <returns></returns>
        public string GetLettersToLeft()
        {
            String temp = "";
            for (int i = _leftIndex; i < _currentIndex; i++)
            {
                temp += Letters[i].ToString();
            }

            return (temp);
        }

        /// <summary>
        /// Get the new set of letters that would be selected to the right.
        /// </summary>
        /// <returns></returns>
        public string GetLettersToRight()
        {
            String temp = "";
            for (int i = _currentIndex + 1; i <= _rightIndex; i++)
            {
                temp += Letters[i].ToString();
            }

            return (temp);

        }

        /// <summary>
        /// Get the currently selected letter at the center of the remaining list.
        /// </summary>
        /// <returns></returns>
        public char GetCurrentLetter()
        {
            return (Letters[_currentIndex]);
        }

        /// <summary>
        /// Choose the left half of the current list.
        /// </summary>
        /// <returns></returns>
        public char ShiftLeftHalf()
        {
            //Don't let left and right pointers pass each other.
            if (_leftIndex == _rightIndex)
            {
            }
            else
            {
                _rightIndex = _currentIndex - 1;
            }

            _currentIndex = (_rightIndex + _leftIndex) / 2;

            return (GetCurrentLetter());
        }

        /// <summary>
        /// Choose the right half of the current list.
        /// </summary>
        /// <returns></returns>
        public char ShiftRightHalf()
        {
            //Don't let left and right pointers pass each other.
            if (_rightIndex == _leftIndex)
            {
            }
            else
            {
                _leftIndex = _currentIndex + 1;
            }

            _currentIndex = (_leftIndex + _rightIndex) / 2;

            return (GetCurrentLetter());
        }

    }
}
