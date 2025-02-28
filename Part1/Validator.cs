using System.Text.RegularExpressions;

namespace Part1 {

    public class LengthException : Exception { public LengthException(string message) : base(message) { } }
    public class CaseException : Exception { public CaseException(string message) : base(message) { } }
    public class RangeException : Exception { public RangeException(string message) : base(message) { } }
    public class StringException : Exception { public StringException(string message) : base(message) { } }
    //public static class Validator {
    //    public static void ValidateString(string S) {
    //        if (S.Length == 0 || S.Length > 40) {
    //            throw new LengthException("String length must be within 1-40 characters.");
    //        }

    //        bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");
    //        if (!IsCapitalLetter) {
    //            throw new CaseException("Only uppercase characters are acceptable!");
    //        }
    //    } // end of validateString

    //    public static void ValidateN(int N) {
    //        if (N < -25 || N > 25) {
    //            throw new RangeException("N must be initialised with values inside the interval [-25 .. 25]");
    //        }
    //    } //end of validate N 
    //} //end of class 
    public static class Validator {
        public static string[] errorList = new string[2];
        public static void ValidateString(string S, Label label) {
            if (S.Length == 0) {
                errorList[0] = "❌";
                errorList[1] = "❌";
            }
            else {
                if (S.Length > 0 && S.Length <= 40) {
                    errorList[0] = "✅";
                }
                else {
                    errorList[0] = "❌";
                }

                bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");
                if (!IsCapitalLetter) {
                    errorList[1] = "❌";
                }
                else {
                    errorList[1] = "✅";
                }
            }

        } // end of validateString

        public static void ValidateN(int N) {
            if (N < -25 || N > 25) {
                throw new RangeException("N must be initialised with values inside the interval [-25 .. 25]");
            }
        } //end of validate N 
    } //end of class 
} //end of namespace