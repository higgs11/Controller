using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxControllerText
{
    class Alphabet
    {
        private int START_INDEX;
        private int LAST_INDEX;
        private int MIDDLE_INDEX;

        private int _leftIndex;
        private int _rightIndex;
        private int _currentIndex;

        //Alphabetic Ordering
        /*
        char[] Letters = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                        'K', 'L', 'M', 'N', ' ', 'O', 'P', 'Q', 'R', 'S',
                                        'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
         */

        //Morse Code Ordering
        char[] Letters = new char[] { 'H', 'S', 'V', 'I', 'F', 'U', ' ', 'E', 'L', 'R', ' ', 'A', 
                                    'P', 'W', 'J', ' ', 'B', 'D', 'X', 'N', 'C', 'K', 'Y', 
                                    'T', 'Z', 'G', 'Q', 'M', ' ', 'O', ' ' };


        public Alphabet()
        {
            START_INDEX = 0;
            LAST_INDEX = Letters.Length - 1;
            MIDDLE_INDEX = (LAST_INDEX - START_INDEX) / 2;
        }

        public void Reset()
        {
            _leftIndex = START_INDEX;
            _rightIndex = LAST_INDEX;
            _currentIndex = MIDDLE_INDEX;
        }

        public string GetLettersToLeft()
        {
            String temp = "";
            for (int i = _leftIndex; i < _currentIndex; i++)
            {
                temp += Letters[i].ToString();
            }

            return (temp);
        }

        public string GetLettersToRight()
        {
            String temp = "";
            for (int i = _currentIndex + 1; i <= _rightIndex; i++)
            {
                temp += Letters[i].ToString();
            }

            return (temp);

        }

        public char GetCurrentLetter()
        {
            return (Letters[_currentIndex]);
        }

        public char ShiftLeftHalf()
        {
            if (_rightIndex == _currentIndex)
            {
            }
            else
            {
                _rightIndex = _currentIndex - 1;
            }

            _currentIndex = (_rightIndex + _leftIndex) / 2;

            return (GetCurrentLetter());
        }

        public char ShiftRightHalf()
        {
            if (_leftIndex == _currentIndex)
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
