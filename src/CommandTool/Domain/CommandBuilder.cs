using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CommandTool.Domain
{
    public class CommandBuilder
    {
        private const char START_PLACEHOLDER = '[';
        private const char END_PLACEHOLDER = ']';

        private Command _command;
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();

        public CommandBuilder WithCommand(Command command)
        {
            _command = command;
            return this;
        }

        public CommandBuilder WithArguments(params KeyValuePair<string, string>[] arguments)
        {
            foreach (var (key, value) in arguments)
            {
                _arguments.Add(key, value);
            }

            return this;
        }

        public string Build()
        {
            var command = _command.ToString();

            if (_arguments.Count <= 0) 
                return command;

            foreach (var (key, value) in _arguments)
            {
                command = command.Replace($"{START_PLACEHOLDER}{key}{END_PLACEHOLDER}", value);
            }

            return command;
        }
    }
}
