namespace Part1 {
    public static class Transformer {

        public static string Encode(string S, int N) {
            string result = "";
            foreach (char c in S) {
                if ((int)c + N > 90) {
                    result += (char)(c + N - 26);
                }
                else if ((int)c + N < 65) {
                    result += (char)(c + N + 26);
                }
                else {
                    result += (char)(c + N);
                }
            }
            return result;
        }

        public static Array AsciiCode(string input) {
            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++) {
                int asciiValue = (int)input[i];
                result[i] = asciiValue;
            }
            return result;
        }

        public static string Sort(string input) {
            char[] charArray = input.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }

    }//end of class
} //end of namespace

