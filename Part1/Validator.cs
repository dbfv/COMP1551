using System.Text.RegularExpressions;

namespace Part1 {

    public static class Validator {
        public static string[] errorList = new string[3];
        public static void ValidateString(string S, Label label) {
            if (S.Length == 0) {
                errorList[0] = "String length must be within 1-40 characters!";
                errorList[1] = "Only uppercase letters are acceptable!";
            }
            else {
                if (S.Length > 0 && S.Length <= 40) {
                    errorList[0] = "String length is within 1-40 characters.";
                }
                else {
                    errorList[0] = "String length must be within 1-40 characters!";
                }

                bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");
                if (!IsCapitalLetter) {
                    errorList[1] = "Only uppercase letters are acceptable!";
                }
                else {
                    errorList[1] = "All characters are uppercase letters!";
                }
            }

        } // end of validateString

    } //end of class 
} //end of namespace

