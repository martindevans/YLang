using System;
using Pegasus.Common;

using Result = Yolol.Grammar.Parser.Result<YGrammar.Program, Yolol.Grammar.Parser.ParseError>;

namespace YParser
{
    public static class Parser
    {
        public static Result ParseProgram(string program)
        {
            try
            {
                var p = new YParser();
                return new Result(p.Parse(program));
            }
            catch (FormatException e)
            {
                var c = (Cursor)e.Data["cursor"];
                return new Result(new Yolol.Grammar.Parser.ParseError(c, e.Message));
            }
        }
    }
}
