namespace Part1 {
    public static class Transformer {

        public static string Encode(string S, int N) { //Encode method
            string result = "";   //empty string of result
            foreach (char c in S) {  //loop thru each char of the input string
                if ((int)c + N > 90) {  //represent the chars in int type, if exceed 90 (Z) -> reduct 1 cycle
                    result += (char)(c + N - 26);
                }
                else if ((int)c + N < 65) { //if lesser than 65 (A) -> move forward 1 cycle
                    result += (char)(c + N + 26);
                }
                else {
                    result += (char)(c + N); //if not out of range then execute normally
                }
            }
            return result; //return result which contains transformed string
        }

        public static Array AsciiCode(string input) { //this turns ASCII to int, utilizing above technique
            int[] result = new int[input.Length]; //empty list to contain result, type is int 
            for (int i = 0; i < input.Length; i++) { //use for loop and not foreach so that result[i] can be used later on to assign value to array.
                int asciiValue = (int)input[i]; //assign ascii value to int form of int
                result[i] = asciiValue; //assign value to array
            }
            return result; //return result array of int
        }

        public static string Sort(string input) { //this method sort the input or any given string
            char[] charArray = input.ToCharArray(); //create an array and assign it to the array of all chars from input string
            Array.Sort(charArray); //use built-ni function to sort the array
            return new string(charArray); //return the array in form of string
        }
    }//end of class
} //end of namespace

