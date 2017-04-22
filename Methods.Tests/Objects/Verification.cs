using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Objects
{
    /// <summary>
    ///     Class to govern verifications throughout the methods.
    /// </summary>
    public class Verification
    {
        /// <summary>
        ///     Method to check that two strings are equal.
        /// </summary>
        /// <param name="expected">Expected value.</param>
        /// <param name="actual">Actual value.</param>
        /// <param name="message">Message to display on failure.</param>
        /// <param name="ignoreCase">Whether or not to ignore case in comparisons.  True is to ignore, false is not to ignore.</param>
        public static void AssertEqual(string expected, string actual, string message, bool ignoreCase)
        {
            if (expected == null)
            {
                expected = "";
            }

            if (actual == null)
            {
                actual = "";
            }
            expected = expected.Trim();
            actual = actual.Trim();
            try
            {
                Assert.AreEqual(expected, actual, ignoreCase, message);
            }
            catch
            {
                Assert.AreEqual(expected, actual, ignoreCase, message);
            }
        }

        /// <summary>
        ///     Method to check that two strings are equal.
        /// </summary>
        /// <param name="expected">Expected value.</param>
        /// <param name="actual">Actual value.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertEqual(string expected, string actual, string message)
        {
            AssertEqual(expected, actual, message, true);
        }

        /// <summary>
        ///     Method to check that two strings are not equal.
        /// </summary>
        /// <param name="one">First value for comparison.</param>
        /// <param name="two">Second value for comparison.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertNotEqual(string one, string two, string message)
        {
            if (one == null)
            {
                one = "";
            }

            if (two == null)
            {
                two = "";
            }
            one = one.Trim();
            two = two.Trim();
            try
            {
                Assert.AreNotEqual(one, two, message);
            }
            catch
            {
                Assert.AreNotEqual(one, two, message);
            }
        }

        /// <summary>
        ///     Asserts two values are not equal
        /// </summary>
        /// <typeparam name="T">Type of the objects to be compared</typeparam>
        /// <param name="expected">The value to be compared against.</param>
        /// <param name="actual">The value to compare.</param>
        /// <param name="message">Message to show on failure</param>
        public static void AssertNotEqual<T>(T expected, T actual, string message)
        {
            if (expected is IEquatable<T> && (typeof (T).Assembly.GetName().Name != "mscorlib"))
            {
                try
                {
                    AssertFalse(((IEquatable<T>) actual).Equals(expected), message);
                }
                catch
                {
                    Assert.Fail("Types " + typeof (T).Name + " are not equal. " + message);
                }
            }
            else
            {
                try
                {
                    Assert.AreNotEqual(expected, actual, message);
                }
                catch
                {
                    Assert.AreNotEqual(expected, actual, message);
                }
            }
        }

        /// <summary>
        ///     Method to check that a value is false.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertFalse(bool value, string message)
        {
            try
            {
                Assert.IsFalse(value, message);
            }
            catch
            {
                Assert.IsFalse(value, message);
            }
        }

        /// <summary>
        ///     Method to check that two objects of generic type are equal.
        /// </summary>
        /// <typeparam name="T">Type of objects.</typeparam>
        /// <param name="expected">Expected value.</param>
        /// <param name="actual">Actual value.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertEqual<T>(T expected, T actual, string message)
        {
            try
            {
                Assert.AreEqual(expected, actual, message);
            }
            catch
            {
                Assert.AreEqual(expected, actual, message);
            }
        }

        /// <summary>
        ///     Method to check that an object is not null.
        /// </summary>
        /// <param name="value">Object to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertNotNull(object value, string message)
        {
            try
            {
                Assert.IsNotNull(value, message);
            }
            catch
            {
                Assert.IsNotNull(value, message);
            }
        }

        /// <summary>
        ///     Method to check that an object is null.
        /// </summary>
        /// <param name="value">Object to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertNull(object value, string message)
        {
            try
            {
                Assert.IsNull(value, message);
            }
            catch
            {
                Assert.IsNull(value, message);
            }
        }

        /// <summary>
        ///     Method to check that a value is true.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertTrue(bool value, string message)
        {
            try
            {
                Assert.IsTrue(value, message);
            }
            catch
            {
                Assert.IsTrue(value, message);
            }
        }

        /// <summary>
        ///     Message to check that the text in one string is contained in another.
        /// </summary>
        /// <param name="container">String where all text should reside.</param>
        /// <param name="textToMatch">Text to match.</param>
        /// <param name="message">Message to display on failure.</param>
        /// <param name="ignoreCase">Whether or not to ignore case and check. true = ignore, false = not to ignore.</param>
        public static void AssertNotContains(string container, string textToMatch, string message,
                                             bool ignoreCase = false)
        {
            message = message + " Actual Text: " + container + " Text to match: " + textToMatch;

            if (ignoreCase)
            {
            }

            else
            {
                try
                {
                    Assert.IsFalse(container.Contains(textToMatch), message);
                }
                catch
                {
                    Assert.Fail("<" + container + "> does not contain <" + textToMatch + ">. " + message);
                }
            }
        }

        /// <summary>
        ///     Message to check that the text in one string is contained in another.
        /// </summary>
        /// <param name="container">String where all text should reside.</param>
        /// <param name="textToMatch">Text to match.</param>
        /// <param name="message">Message to display on failure.</param>
        /// <param name="ignoreCase">Whether or not to ignore case and check. true = ignore, false = not to ignore.</param>
        public static void AssertContains(string container, string textToMatch, string message,
                                          bool ignoreCase = false)
        {
            string chkContainer = container;
            string chkMatch = textToMatch;
            if (ignoreCase)
            {
                chkContainer = chkContainer.ToLower();
                chkMatch = chkMatch.ToLower();
            }

            else
            {
                try
                {
                    Assert.IsTrue(chkContainer.Contains(chkMatch), message);
                }
                catch
                {
                    Assert.Fail("<" + container + "> does not contain <" + textToMatch + ">. " + message);
                }
            }
        }

        /// <summary>
        ///     Asserts one value is greater than or equal to another value
        /// </summary>
        /// <typeparam name="T">Must implement IComparable</typeparam>
        /// <param name="actual">Value you are comparing. Left side of operator.</param>
        /// <param name="compareValue">Value you are comparing against. Right side of operator.</param>
        /// <param name="message">Message you'd like to log on failure</param>
        public static void AssertGE<T>(T actual, T compareValue, string message) where T : IComparable
        {
            AssertCompare(actual, compareValue, message, ">=");
        }

        /// <summary>
        ///     Asserts one value is greater than another value
        /// </summary>
        /// <typeparam name="T">Must implement IComparable</typeparam>
        /// <param name="actual">Value you are comparing. Left side of operator.</param>
        /// <param name="compareValue">Value you are comparing against. Right side of operator.</param>
        /// <param name="message">Message you'd like to log on failure</param>
        public static void AssertG<T>(T actual, T compareValue, string message) where T : IComparable
        {
            AssertCompare(actual, compareValue, message, ">");
        }

        /// <summary>
        ///     Asserts one value is less than or equal to another value
        /// </summary>
        /// <typeparam name="T">Must implement IComparable</typeparam>
        /// <param name="actual">Value you are comparing. Left side of operator.</param>
        /// <param name="compareValue">Value you are comparing against. Right side of operator.</param>
        /// <param name="message">Message you'd like to log on failure</param>
        public static void AssertLE<T>(T actual, T compareValue, string message) where T : IComparable
        {
            AssertCompare(actual, compareValue, message, "<=");
        }

        /// <summary>
        ///     Asserts one value is less than another value
        /// </summary>
        /// <typeparam name="T">Must implement IComparable</typeparam>
        /// <param name="actual">Value you are comparing. Left side of operator.</param>
        /// <param name="compareValue">Value you are comparing against. Right side of operator.</param>
        /// <param name="message">Message you'd like to log on failure</param>
        public static void AssertL<T>(T actual, T compareValue, string message) where T : IComparable
        {
            AssertCompare(actual, compareValue, message, "<");
        }

        private static void AssertCompare<T>(T actual, T compareValue, string message, string op) where T : IComparable
        {
            int comp = actual.CompareTo(compareValue);
            switch (op)
            {
                case "<":
                    if (comp < 0)
                    {
                        return;
                    }
                    break;
                case "<=":
                    if (comp <= 0)
                    {
                        return;
                    }
                    break;
                case ">=":
                    if (comp >= 0)
                    {
                        return;
                    }
                    break;
                case ">":
                    if (comp > 0)
                    {
                        return;
                    }
                    break;
            }

            Assert.Fail("Expected: " + op + " " + compareValue + " Actual: " + actual + ". " + message);
        }

        /// <summary>
        ///     Forces the test to fail
        /// </summary>
        /// <param name="message">Message to output</param>
        public static void AssertFail(string message)
        {
            Assert.Fail(message);
        }
    }
}