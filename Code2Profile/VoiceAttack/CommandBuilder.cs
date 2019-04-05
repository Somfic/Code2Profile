using System;
using System.Collections.Generic;

namespace Code2Profile.VoiceAttack
{
    public class CommandBuilder
    {
        private readonly Command command;

        /// <summary>
        /// Create a new CommandBuilder.
        /// </summary>
        public CommandBuilder()
        {
            command = new Command();
        }

        /// <summary>
        /// Continue building a command.
        /// </summary>
        /// <param name="command">The command.</param>
        public CommandBuilder(Command command)
        {
            this.command = command;
        }

        /// <summary>
        /// Build the command.
        /// </summary>
        /// <returns></returns>
        public Command Build()
        {
            command.ID = Guid.NewGuid();
            return command;
        }
 
        /// <summary>
        /// Set the spoken phrase that triggers the command.
        /// </summary>
        /// <param name="phrase">Sentence.</param>
        /// <returns></returns>
        public CommandBuilder UsePhrase(string phrase)
        {
            command.Phrase = phrase;
            return this;
        }

        /// <summary>
        /// Whether the phrase is enabled.
        /// </summary>
        /// <param name="usePhrase"></param>
        /// <returns></returns>
        public CommandBuilder UsePhrase(bool usePhrase)
        {
            command.IsVoiced = usePhrase;
            return this;
        }

        /// <summary>
        /// Set the minimal confidence the command uses.
        /// </summary>
        /// <param name="confidence"></param>
        /// <returns></returns>
        public CommandBuilder SetConfidence(int confidence)
        {
            command.MinimalConfidence = confidence;
            return this;
        }

        /// <summary>
        /// Set whether the command is enabled.
        /// </summary>
        /// <param name="isEnabled"></param>
        /// <returns></returns>
        public CommandBuilder SetEnabled(bool isEnabled)
        {
            command.IsEnabled = isEnabled;
            return this;
        }

        /// <summary>
        /// Set whether the command will run async.
        /// </summary>
        /// <param name="isAsync"></param>
        /// <returns></returns>
        public CommandBuilder SetAsync(bool isAsync)
        {
            command.IsAsync = isAsync;
            return this;
        }

        /// <summary>
        /// Add an action to the command.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public CommandBuilder AddAction(IAction action)
        {
            command.Actions.Add(action);

            return this;
        }
    }
}
