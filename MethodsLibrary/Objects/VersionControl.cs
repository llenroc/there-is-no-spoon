

namespace MethodsLibrary.Objects
{
    public class VersionControl
    {
        /// <summary>
        /// Set bad version number for testing
        /// </summary>
        public static int BadVersion { set; get; }

        public static bool IsBadVersion(int version)
        {
            //Simulate the bad versions
            return version >= BadVersion;
        }
    }
}
