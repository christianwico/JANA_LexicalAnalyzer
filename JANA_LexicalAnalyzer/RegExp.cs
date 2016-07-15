namespace JANA_LexicalAnalyzer
{
    public class RegExp
    {
        // REGULAR DEFINITION
        public string space = "\\s";
        public string paren = "\\(";
        public string hyphen = "\\-";
        public string semic = "\\;";
        public string newline = "\\n";
        public string zero = "0";
        public string und = "_";
        public string colon = ":";
        public string lowalpha = "[a-z]";
        public string upalpha = "[A-Z]";
        public string digit = "[1-9]";
        public string ASCII = ".";
        public string otherSY1 = "\\+";
        public string otherSY2 = "\\-|>";
        public string relop = "=|!";
        public string delRW_1 = ";|\\s";
        public string delRW_2 = ":|\\s|\\n";
        public string delRW_3 = "\\{|\\s|\\n";
        public string delRW_4 = "\\(|\\s";
        public string delSY_1 = "\\s|[1-9]";
        public string delSY_2 = "\\s|[A-Z]|[a-z]";
        public string delSY_3 = "\\s|[A-Z]|[a-z]|[1-9]";
        public string delSY_4 = "\\s|.";
        public string delSY_5 = ";|\\n";
        public string delSY_6 = "\\s|[A-Z]|[a-z]|[1-9]|.";
        public string delSY_7 = "\\s|[A-Z]|[a-z]|[1-9]|.|;|\\n";
        public string delSY_8 = "\\n|";
        public string delSY_9 = "\\s|.|;|\\n|";
        public string delSY_10 = "\\s|.|;";
        public string delSY_11 = ":|\\s|\\n||\"";
        public string delid = ";|\\s|=|\\[|\\s";
        public string delit = ";|\\s|\\.";
        public string delch = ";|\\s|'";
        public string delstr = ";|\\s|\"";

        // REGULAR EXPRESSION - IDENTIFIERS
        public string id = "[A-Z]|[a-z]([A-Z]|[a-z]|[1-9]|[0]|_|){9}";
        public string comment = "///#(.|)*//#/";

        // REGULAR EXPRESSION - DATA VALUES
        public string intType = "(~|)[1-9]([1-9]|0|){9}";
        public string floatType = "(~|)[1-9]([1-9]|0|){9}\\.[1-9]([1-9]|0|){4}";
        public string charType = "'(.|)'";
        public string stringType = "\"(.|)+";
    }
}
