using CommandTool.Domain;
using FluentAssertions;
using Xunit;

namespace CommandTool.Test
{
    public class CommandTests
    {
        [Fact]
        public void To_String_Should_return_empty_string_if_not_statement_is_provided()
        {
            //arrange
            var command = new Command();
            
            //act
            var stringCommand = command.ToString();

            //assert
            stringCommand.Should().Be(string.Empty);
        }

        [Fact]
        public void To_String_Should_return_command_string_With_One_Statement()
        {
            //arrange
            var command = new Command();
            command.AddStatement("pscp");

            //act
            var stringCommand = command.ToString();

            //assert
            stringCommand.Should().Be("pscp");
        }

        [Fact]
        public void To_String_Should_return_command_string_With_Two_Statements()
        {
            //arrange
            var command = new Command();
            command.AddStatement("pscp");
            command.AddStatement("tx:unit1@localhost");

            //act
            var stringCommand = command.ToString();

            //assert
            stringCommand.Should().Be("pscp tx:unit1@localhost");
        }
    }
}
