

namespace MethodsLibrary.Objects
{
    public class VersionControl
    {
        public static int BadVersion { set; get; }

        public static bool IsBadVersion(int version)
        {
            return version == BadVersion;
        }
    }
}
