﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private int[] bitArray = new int[64];
        private ulong number;

        public BitArray64(ulong number)
        {
            this.number = number;
            for (int i = 0; i < 64; i++)
            {
                this.bitArray[i] = (int)(number % 2);
                number /= 2;
            }
        }

        //Properties
        public ulong Number
        {
            get { return this.number; }
        }

        //Methods
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.bitArray[i];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;

            if ((object)bitArray == null)
            {
                return false;
            }
            if (Object.Equals(this.number, bitArray.number))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(BitArray64 firstNumber,
                                  BitArray64 secondNumber)
        {
            return BitArray64.Equals(firstNumber, secondNumber);
        }

        public static bool operator !=(BitArray64 firstNumber,
                           BitArray64 secondNumber)
        {
            return !(BitArray64.Equals(firstNumber, secondNumber));
        }

        public int this[int key]
        {
            get { return this.bitArray[key]; }
            set
            {
                if (value == 1 || value == 0)
                {
                    this.bitArray[key] = value;
                    ChangeNumber();
                }
                else
                {
                    throw new ArgumentException("Only bits: 0 and 1.");
                }
            }
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        private void ChangeNumber()
        {
            this.number = 0;
            for (int i = 0; i < 64; i++)
            {
                this.number += (ulong)(this.bitArray[i] << i); 
            }
        }
    }
}
