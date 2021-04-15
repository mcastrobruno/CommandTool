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
            _builder.WithCommand("pcsp").Build();

            //act
            var stringCommand = _builder.Build();

            //assert
            stringCommand.Should().Be("pcsp");
        }

        [Fact]
        public void Should_replace_placeholder_with_one_placeholder()
        {
            //arrange
            _builder
                .WithCommand("pcsp [username]")
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
            _builder
                .WithCommand("pcsp [username]@[serveraddress]")
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
