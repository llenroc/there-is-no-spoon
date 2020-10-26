namespace MethodsLibrary.Methods
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;


    [TestClass]
    public class LongPressedName
    {

        public bool IsLongPressedName(string name, string typed)
        {
            if (name.Length > typed.Length) return false;
            int nameIndex = 0;
            int typedIndex = 0;
            while (typedIndex < typed.Length)
            {
                if (nameIndex < name.Length && name[nameIndex] == typed[typedIndex])
                {
                    nameIndex++;
                    typedIndex++;
                }
                else if (typedIndex > 0 && typed[typedIndex] == typed[typedIndex - 1])
                {
                    typedIndex++;
                }
                else
                {
                    return false;
                }
            }

            if (nameIndex != name.Length)
            {
                return false;
            }

            return true;
        }

        [TestMethod]
        public void IsLongPressedNameTest()
        {
            //Input: name = "alex", typed = "aaleex"
            //Output: true

            //Input: name = "saeed", typed = "ssaaedd"
            //Output: false

            //Input: name = "leelee", typed = "lleeelee"
            //Output: true

            //Input: name = "laiden", typed = "laiden"
            //Output: true

            string name = "leelee", typed = "lleeelee";

            Console.WriteLine(IsLongPressedName(name, typed));

        }
    }
}
