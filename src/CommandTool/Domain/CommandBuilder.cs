using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CommandTool.Domain
{
    public class CommandBuilder
    {
        private const char START_PLACEHOLDER = '[';
        private const char END_PLACEHOLDER = ']';

        private string _command;
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();

        public CommandBuilder WithCommand(string commandSyntax)
        {
            _command = commandSyntax;
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

            Reset();

            return command;
        }

        private void Reset()
        {
            _arguments = new Dictionary<string, string>();
            _command = "";
        }
    }
}
