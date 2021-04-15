using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CommandTool.Controls;
using CommandTool.Domain;
using CommandTool.Entities;
using CommandTool.Infrastructure;

namespace CommandTool
{
    public partial class Main : Form
    {
        private readonly CommandBuilder _commandBuilder;
        private readonly CommandRepository _repository;
        private Dictionary<string, ArgumentControl> _commandArguments = new Dictionary<string, ArgumentControl>();

        private CommandSyntax _command = new CommandSyntax();


        public Main()
        {
            InitializeComponent();
            _commandBuilder = new CommandBuilder();
            _repository = new CommandRepository();
        }

        private void btnEvaluate_Click(object sender, System.EventArgs e)
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

                panelArguments.Controls.Add(argumentControl);
                _commandArguments.Add(argumentControl.ArgumentKey, argumentControl);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var arguments = from c in _commandArguments
                            select new KeyValuePair<string, string>(c.Key, c.Value.ArgumentValue);

            var command = _commandBuilder.WithCommand(tbCommandSyntax.Text)
                .WithArguments(arguments.ToArray())
                .Build();

            tbParsedCommand.Text = command;
        }

        private async void btnSaveSyntax_Click(object sender, EventArgs e)
        {
            if (tbCommandName.Text == string.Empty)
            {
                MessageBox.Show(@"Please enter a name for the command.");
                return;
            }

            await _repository.StoreCommand(new CommandSyntax
            {
                Name = tbCommandName.Text,
                Syntax = tbCommandSyntax.Text,
                Arguments = _commandArguments.Select(c => c.Key).ToArray()
            });
        }
    }
}
