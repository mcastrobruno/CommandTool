using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CommandTool.Domain;

namespace CommandTool.Controls
{
    public partial class CommandControl : UserControl
    {
        private readonly CommandBuilder _commandBuilder;
        public Guid Key { get; set; }
        public string CommandName
        {
            get => tbCommandName.Text;

            set => tbCommandName.Text = value;
        }

        public string Syntax
        {
            get => tbCommandSyntax.Text;
            set => tbCommandSyntax.Text = value;
        }
        public string[] Arguments { get; set; }

        private readonly Dictionary<string, ArgumentControl> _commandArguments = new Dictionary<string, ArgumentControl>();

        public CommandControl()
        {
            InitializeComponent();
            _commandBuilder = new CommandBuilder();
            argumentGrid.ArgumentsUpdated += ArgumentGrid_ArgumentsUpdated;
        }

        private void ArgumentGrid_ArgumentsUpdated(object sender, EventArgs e)
        {
            var arguments = from c in _commandArguments
                select new KeyValuePair<string, string>(c.Key, c.Value.ArgumentValue);

            var command = _commandBuilder.WithCommand(tbCommandSyntax.Text)
                .WithArguments(arguments.ToArray())
                .Build();

            tbParsedCommand.Text = command;
        }

        private void tbCommandSyntax_TextChanged(object sender, EventArgs e)
        {
            var regx = new Regex("(?<=\\[)(.*?)(?=\\])");

            var command = tbCommandSyntax.Text;

            var matches = regx.Matches(command);

            var removedArguments = _commandArguments.Keys.Where(k => matches.Count(m => m.Value == k) == 0);

            foreach (var argument in removedArguments)
            {
                argumentGrid.RemoveArgument(argument);
            }


            for (var i = 0; i < matches.Count; i++)
            {
                argumentGrid.AddArgument(matches[i].Value);
            }
        }
    }
}
