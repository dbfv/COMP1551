using System.Text.RegularExpressions;

namespace Part1 {

    public static class Validator {

        public static string[] errorList = new string[3]; //create array to store the error messages with 3 messages max
        public static void ValidateString(string S, Label label) {  //static method to validate String S

            if (S.Length == 0) { //if the string is empty 
                errorList[0] = "String length must be within 1-40 characters!"; //reset to the default messages 
                errorList[1] = "Only uppercase letters are acceptable!"; //reset to the default message 
            }
            else { //if not empty 
                if (S.Length > 0 && S.Length <= 40) { //valid string
                    errorList[0] = "String length is within 1-40 characters."; //show this message
                }
                else { // if not empty and out of range, show below message
                    errorList[0] = "String length must be within 1-40 characters!";
                }

                bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");  // create boolean variable to check if all chars are uppercase letters
                if (!IsCapitalLetter) {                             //if not, show below message
                    errorList[1] = "Only uppercase letters are acceptable!";
                }
                else { //if yes, show below message
                    errorList[1] = "All characters are uppercase letters!";
                }
            }
        } // end of validateString
    } //end of class 
} //end of namespace

