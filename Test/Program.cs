using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

namespace Test {

    public class LengthException : Exception { public LengthException(string message) : base(message) { } }
    public class CaseException : Exception { public CaseException(string message) : base(message) { } }
    public class StringException : Exception { public StringException(string message) : base(message) { } }
    public class RangeException : Exception { public RangeException(string message) : base(message) { } }

    public static class Validator {
        public static void ValidateString(string S) {
            StringBuilder sb = new StringBuilder();
            string errorMessage = "";
            if (S.Length == 0 || S.Length > 40) {
                errorMessage += "String length must be within 1-40 characters!\n";
            }

            bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");
            if (!IsCapitalLetter) {
                errorMessage += "Only uppercase characters are acceptable!";
            }
            throw new StringException(errorMessage);
        } // end of validateString

        public static void ValidateN(int N) {
            if (N < -25 || N > 25) {
                throw new RangeException("N must be initialised with values inside the interval [-25 .. 25]");
            }
        } //end of validate N 
    } //end of class 

    public class Program {
        public static void Main(string[] args) {
            string testString = "AAAAaaaaAAAAaaaaAAAAaaaaAAAAaaaaAAAAaaaaAAAAaaaaAAAAaaaa"; //48 chars 
            try {
                Validator.ValidateString(testString);
            }
            catch (StringException ex) {
                string[] error = ex.Message.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (error.Length > 0) {
                    label10.Text = error[0].Trim() ; // Assign first sentence, adding back the period
                }

                if (error.Length > 1) {
                    label12 = error[1].Trim(); // Assign second sentence, adding back the period
                }
            }


        }

    } //end of namespace
}


