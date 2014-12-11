namespace LongestSubsequenceEqualNumbersTests
{
    using System;
    using System.Collections.Generic;
    using LongestSubsequenceEqualNumbers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestSubsequenceEqualNumbersDemoTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullInputList()
        {
            LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyInputList()
        {
            List<int> sequence = new List<int>();
            LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OnlyOneNumber()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void DifferentNumbers()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(-1);
            sequence.Add(0);
            sequence.Add(5);
            sequence.Add(8);
            LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
        }

        [TestMethod]
        public void OneSequence()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(1);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 3;
            var actualCount = result.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void TwoSequencesSecondLongest()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(2);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 4;
            var actualCount = result.Count;
            int expectedNumber = 2;
            int actualNumber = result[0];

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void TwoSequencesFirstLongest()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(2);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 4;
            var actualCount = result.Count;
            int expectedNumber = 1;
            int actualNumber = result[0];

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void ThreeSequencesFirstLongest()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(3);
            sequence.Add(3);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 3;
            var actualCount = result.Count;
            int expectedNumber = 1;
            int actualNumber = result[0];

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void ThreeSequencesSecondLongest()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(3);
            sequence.Add(3);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 3;
            var actualCount = result.Count;
            int expectedNumber = 2;
            int actualNumber = result[0];

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void ThreeSequencesLastLongest()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(3);
            sequence.Add(3);
            sequence.Add(3);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 3;
            var actualCount = result.Count;
            int expectedNumber = 3;
            int actualNumber = result[0];

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void TwoEqualSequences()
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(1);
            sequence.Add(2);
            sequence.Add(2);
            sequence.Add(2);
            var result = LongestSubsequenceEqualNumbersDemo.GetLongestSubsequenceWithEqualNumbers(sequence);
            int expectedCount = 3;
            var actualCount = result.Count;
            int expectedNumber = 2;
            int actualNumber = result[0];

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedNumber, actualNumber);
        }
    }
}