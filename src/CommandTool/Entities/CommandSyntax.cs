using System;
using System.Collections.Generic;
using System.Text;

namespace CommandTool.Entities
{
    public class CommandSyntax
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Syntax { get; set; }
        public string[] Arguments { get; set; }
    }
}
