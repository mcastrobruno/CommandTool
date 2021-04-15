using System.Collections.Generic;
using CommandTool.Domain;
using FluentAssertions;
using Xunit;

namespace CommandTool.Test
{
    public class ComandBuilderTests
    {
        private readonly CommandBuilder _builder;

        public ComandBuilderTests()
        {
            _builder = new CommandBuilder();
        }

        [Fact]
        public void Should_parse_command_with_no_placeholders_and_arguments()
        {
            //arrange
            var command = new Command();
            command.AddStatement("pcsp");

            _builder.WithCommand(command).Build();

            //act
            var stringCommand = _builder.Build();

            //assert
            stringCommand.Should().Be("pcsp");
        }

        [Fact]
        public void Should_replace_placeholder_with_one_placeholder()
        {
            //arrange
            var command = new Command();
            command.AddStatement("pcsp [username]");

            _builder
                .WithCommand(command)
                .WithArguments(new KeyValuePair<string, string>("username", "testuser"))
                .Build();

            //act
            var stringCommand = _builder.Build();

            //assert
            stringCommand.Should().Be("pcsp testuser");
        }

        [Fact]
        public void Should_replace_placeholder_with_more_than_one_placeholders()
        {
            //arrange
            var command = new Command();
            command.AddStatement("pcsp [username]@[serveraddress]");

            _builder
                .WithCommand(command)
                .WithArguments(
                    new KeyValuePair<string, string>("username", "testuser"),
                    new KeyValuePair<string, string>("serveraddress", "localhost"))
                .Build();

            //act
            var stringCommand = _builder.Build();

            //assert
            stringCommand.Should().Be("pcsp testuser@localhost");
        }
    }
}
