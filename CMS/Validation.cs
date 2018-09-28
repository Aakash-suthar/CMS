

namespace CMS
{
    
    public class Validation
    {
        static string[] b = { "@", "gmail.com" };
        public static bool CheckGmail(string s) {
            if (s.Length <= 11 || s.Contains(b[0]) == false || s.Contains(b[1]) == false)
            {
                return false;
            }
            else return true;
        }
    }
}
