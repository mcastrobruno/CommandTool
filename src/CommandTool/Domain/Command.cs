using System.Collections.Generic;

namespace CommandTool.Domain
{
    public class Command
    {
        private List<string> _statements = new List<string>();

        public void AddStatement(string statement)
        {
            _statements.Add(statement);
        }

        public override string ToString()
        {
            return string.Join(" ", _statements);
        }
    }
}
