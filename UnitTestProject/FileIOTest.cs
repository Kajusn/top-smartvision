using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using top_smartvision.DB;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class FileIOTest
    {
        private readonly IDB _fileIO;

        public FileIOTest()
        {
            _fileIO = new FileIO();
        }

        [TestMethod]
        public void HashingNotNull()
        {
            // Creates Enumerable string list for testing
            StringList<string> myListOfStrings = new StringList<string>();

            myListOfStrings.Add("");
            myListOfStrings.Add("vewjk");
            myListOfStrings.Add("vew324jk54hh");
            myListOfStrings.Add("111111111");
            myListOfStrings.Add("bgt511111");
            myListOfStrings.Add("1111");


            foreach (string testString in myListOfStrings)
            {
                // Runs Hashing
                var result = _fileIO.Hashing(testString);

                // Check if returns not null
                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public void HashingDoesHashing()
        {
            // Creates Enumerable string list for testing
            StringList<string> myListOfStrings = new StringList<string>();

            myListOfStrings.Add("");
            myListOfStrings.Add("vewjk");
            myListOfStrings.Add("vew324jk54hh");
            myListOfStrings.Add("111111111");
            myListOfStrings.Add("bgt511111");
            myListOfStrings.Add("1111");


            foreach (string testString in myListOfStrings)
            {
                // Runs Hashing
                var result = _fileIO.Hashing(testString);

                // Check if returns hashed string and not the same
                Assert.AreNotEqual(testString, result);
            }
        }

        [TestMethod]
        public void HashingReturnsString()
        {
            // Creates Enumerable string list for testing
            StringList<string> myListOfStrings = new StringList<string>();

            myListOfStrings.Add("");
            myListOfStrings.Add("vewjk");
            myListOfStrings.Add("vew324jk54hh");
            myListOfStrings.Add("111111111");
            myListOfStrings.Add("bgt511111");
            myListOfStrings.Add("1111");


            foreach (string testString in myListOfStrings)
            {
                // Runs Hashing
                var result = _fileIO.Hashing(testString);

                // Check if returns String type
                Assert.IsInstanceOfType(result, typeof(String));
            }
        }

        class StringList<T>: IEnumerable<T>
        {
            T[] strings = null;
            int freeIndex = 0;

            public StringList()
            {
                // For the sake of simplicity lets keep them as arrays
                // ideally it should be link list
                strings = new T[10];
            }

            public void Add(T item)
            {
                // Let us only worry about adding the item 
                strings[freeIndex] = item;
                freeIndex++;
            }

            #region IEnumerable<T> Members
            //because we need to implement both: generic and non-generic versions
            public IEnumerator<T> GetEnumerator()
            {
                foreach (T t in strings)
                {
                    // Lets check for end of list (its bad code since we used arrays)
                    if (t == null) // this wont work is T is not a nullable type
                    {
                        break;
                    }

                    // Return the current element and then on next function call 
                    // resume from next element rather than starting all over again;
                    yield return t;
                }
            }

            #endregion

            #region IEnumerable Members
            //because we need to implement both: generic and non-generic versions
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                // Lets call the generic version here
                return this.GetEnumerator();
            }

            #endregion
        }
    }
}
