using System.Text.RegularExpressions;

namespace Part1.classes
{

    public static class Validator
    {
        public static string[] errorList = new string[3]; //create array to store the error messages with 3 messages max
        public static void ValidateString(string S)
        {  //static method to validate String S
            if (S.Length == 0)
            { //if the string is empty 
                errorList[0] = "❎ String length is within 1-40 characters."; //reset the messages to default
                errorList[1] = "❎ String only contains uppcase letters."; //reset the message to default
            }
            else
            { //if not empty 
                if (S.Length > 0 && S.Length <= 40)
                { //valid string
                    errorList[0] = "✅ String length is within 1-40 characters."; //show this message
                }
                else
                { // if not empty and out of range, show below message
                    errorList[0] = "❎ String length is within 1-40 characters.";
                }

                bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");  // create boolean variable to check if all chars are capital
                if (!IsCapitalLetter)
                {                             //if not, show below message
                    errorList[1] = "❎ String only contains uppcase letters.";
                }
                else
                { //if yes, show below message
                    errorList[1] = "✅ String only contains uppcase letters.";
                }
            }

        } // end of validateString
    } //end of class 
} //end of namespace

