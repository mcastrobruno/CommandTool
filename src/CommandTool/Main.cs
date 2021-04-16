using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandTool.Controls;
using CommandTool.Domain;
using CommandTool.Entities;
using CommandTool.Infrastructure;

namespace CommandTool
{
    public partial class Main : Form
    {
        
        private readonly CommandRepository _repository;
        

        private CommandSyntax _command = new CommandSyntax();

        public Main()
        {
            InitializeComponent();
            
            _repository = new CommandRepository();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var commands = await _repository.GetCommands();
            lboxCommands.DataSource = commands;
            lboxCommands.DisplayMember = nameof(CommandSyntax.Name);
            lboxCommands.ValueMember = nameof(CommandSyntax.Key);
        }

        private async void btnSaveCommand_Click(object sender, EventArgs e)
        {
            if (commandControl1.CommandName == string.Empty)
            {
                MessageBox.Show(@"Please enter a name for the command.");
                return;
            }

            await _repository.StoreCommand(new CommandSyntax
            {
                Name = commandControl1.CommandName,
                Syntax = commandControl1.Syntax,
                Arguments = commandControl1.Arguments
            });

            await LoadData();
        }
    }
}
