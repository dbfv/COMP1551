using System.Text.RegularExpressions;
namespace Part1 {
	public static class Validator {
		public static bool ValidateString(string S) {
			if (S.Length < 1 || S.Length > 40) {
				return false;
			} 
			bool IsCapitalLetter = Regex.IsMatch(S, @"^[A-Z]+$");
			if (IsCapitalLetter) {
				return true;
			}
			return false;
	
		} // validateString 
	} //end of class 
} //end of namespace