﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPWithForms;

namespace UnitTestProject1
{
    public class NotSoRandom : IRandom
    {
        private int[] _numbers;
        private int currentNumber;
        public NotSoRandom(int[] numbers)
        {
            _numbers = numbers;
            currentNumber = 0;
        }
        public int Next(int lowerBound, int upperBoud)
        {
            if ( currentNumber >= _numbers.Length )
            {
                currentNumber = 0;
            }
            return _numbers[currentNumber];
        }
    }
}
