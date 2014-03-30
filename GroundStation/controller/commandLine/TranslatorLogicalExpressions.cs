using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using log4net;

namespace controller
{
    public static class TranslatorLogicalExpressions
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TranslatorLogicalExpressions));
        private static List<Double> con = new List<double>();
        private static List<String> ops = new List<String>();

        public static bool expressionValue(String exp)
        {
            try
            {
                con.Clear();
                ops.Clear();
                parse(exp);
                return calc();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }

            return false;
        }

        private static void parse(String input)
        {
            string pattern = @"((\d+,\d+)|(\d+))";
            // Get CONST
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            {
                log.Debug("CONST: " + match.Value + "  " + match.Groups[1].Value + "  " + match.Index);
                con.Add(Double.Parse(match.Value));
            }

            pattern = @"((\<=)|(\>=)|=|\<|\>)";
            // Get Operations
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            {
                log.Debug("OP: " + match.Value + "  " + match.Groups[1].Value + "  " + match.Index);
                ops.Add(match.Value);
            }
        }

        private static bool calc()
        {
            bool res = true;

            if (ops.Count == 0 || con.Count == 0) throw new Exception("Unexpected expression!");

            for (int i = 0; i < ops.Count; i++)
            {
                switch (ops[i])
                {
                    case "<": res = res && (con[i] < con[i + 1]); break;
                    case ">": res = res && (con[i] > con[i + 1]); break;
                    case "<=": res = res && (con[i] <= con[i + 1]); break;
                    case ">=": res = res && (con[i] >= con[i + 1]); break;
                    case "=": res = res && (con[i] == con[i + 1]); break;
                    default: throw new Exception("Unexpected logic operation : " + ops[i]);
                }
            }
            log.Debug("Logic result: " + res);
            return res;
        }
    }
}
