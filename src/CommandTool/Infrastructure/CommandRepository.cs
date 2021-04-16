using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CommandTool.Entities;
using Newtonsoft.Json;
using System.Linq;

namespace CommandTool.Infrastructure
{
    public class CommandRepository
    {
        private const string StorageFolder = @"./storage";
        private const string CommandFilename = "commands.json";
        private readonly string _storageFilePath = $"{StorageFolder}/{CommandFilename}";
        private Dictionary<Guid, CommandSyntax> _commands = new Dictionary<Guid, CommandSyntax>();
        private bool _initialized = false;

        public async Task<CommandSyntax> StoreCommand(CommandSyntax commandSyntax)
        {
            if (!_initialized)
                await Initialize();

            commandSyntax.Key = Guid.NewGuid();
            _commands.Add(Guid.NewGuid(), commandSyntax);

            await using var sr = new StreamWriter(_storageFilePath);
            await sr.WriteAsync(JsonConvert.SerializeObject(_commands.Select(x => x.Value)));

            return commandSyntax;
        }

        public async Task<List<CommandSyntax>> GetCommands()
        {
            if (!_initialized)
                await Initialize();

            return _commands.Select(x => x.Value).ToList();
        }


        private async Task<List<CommandSyntax>> LoadCommands()
        {
            using var sr = new StreamReader(_storageFilePath);
            return JsonConvert.DeserializeObject<List<CommandSyntax>>(await sr.ReadToEndAsync());
        }

        private async Task Initialize()
        {
            if (!Directory.Exists(StorageFolder))
                Directory.CreateDirectory(StorageFolder);

            if (!File.Exists(_storageFilePath))
            {
                await using var sw = new StreamWriter(_storageFilePath);
                await sw.WriteAsync(JsonConvert.SerializeObject(new List<CommandSyntax>()));
            }

            var commands = await LoadCommands();

            _commands = commands.ToDictionary(c => c.Key);

            _initialized = true;
        }
    }
}
