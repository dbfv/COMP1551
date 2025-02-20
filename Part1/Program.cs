using System.Text.RegularExpressions;

namespace Part1 {
    internal static class Program {
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        static public void validate(string S, int N) {
            try {
                N = Convert.ToInt32(Console.ReadLine());

                if (N < -25 || N > 25) {
                    throw new Exception("out of acceptable range!");
                }

                if (S.Length == 0 || S.Length > 40) {
                    throw new Exception("String length must be in range of 1-40! ");
                }
                else {
                    bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");
                }
            }
            catch (System.FormatException e) {
                form.label5.Text($"not int! {e}"); //TODO: test on a label
            }
        }
    }
}
