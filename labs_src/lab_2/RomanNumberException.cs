﻿using System;

namespace lab_2.ex
{
    public class RomanNumberException : Exception
    {
        public short Value { get; }
        public RomanNumberException(string message): base(message)
        {

        }        
    }
}
