using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CommandTool.Domain;
using CommandTool.Entities;

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
        }

        private void tbCommandSyntax_TextChanged(object sender, EventArgs e)
        {
            var regx = new Regex("(?<=\\[)(.*?)(?=\\])");

            var command = tbCommandSyntax.Text;

            var matches = regx.Matches(command);

            for (var i = 0; i < matches.Count; i++)
            {
                var controlName = $"arg{matches[i].Value}";
                if (panelArguments.Controls.ContainsKey(controlName))
                {
                    continue;
                }

                var argumentControl = new ArgumentControl
                {
                    ArgumentKey = matches[i].Value,
                    Name = controlName
                };

                argumentControl.ArgumentValueChanged += ArgumentControl_ArgumentValueChanged;

                panelArguments.Controls.Add(argumentControl);
                _commandArguments.Add(argumentControl.ArgumentKey, argumentControl);
            }
        }

        private void ArgumentControl_ArgumentValueChanged(object sender, (string argumentName, string value) args)
        {
            ParseCommand();
        }

        private void ParseCommand()
        {
            var arguments = from c in _commandArguments
                select new KeyValuePair<string, string>(c.Key, c.Value.ArgumentValue);

            var command = _commandBuilder.WithCommand(tbCommandSyntax.Text)
                .WithArguments(arguments.ToArray())
                .Build();

            tbParsedCommand.Text = command;
        }
    }
}
