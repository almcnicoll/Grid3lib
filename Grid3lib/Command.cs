using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    /// <summary>
    /// Represents a command that can be attached to a cell or Page
    /// </summary>
    public class Command
    {
        public string Action { get; set; }
        public List<CommandParameter> Parameters { get; set; } = new List<CommandParameter>();

        public Command()
        {

        }

        /// <summary>
        /// Creates a new Command object from the GridCommand import class
        /// </summary>
        /// <param name="importCommand">The source import class object</param>
        public Command(ImportClasses.GridCommand importCommand)
        {
            this.Action = importCommand.ID;
            foreach (ImportClasses.GridCommandParameter param in importCommand.Parameter)
            {
                if (param.data == null)
                {
                    Parameters.Add(new CommandParameter(param.Key, param.Value));
                }
                else
                {
                    Parameters.Add(new CommandParameter(param.Key, param.Value, param.data));
                }
            }
        }

        /// <summary>
        /// Creates a new Command object from the GridCellContentCommand import class
        /// </summary>
        /// <param name="importCommand">The source import class object</param>
        public Command(ImportClasses.GridCellContentCommand importCommand)
        {
            this.Action = importCommand.ID;
            foreach (ImportClasses.GridCellContentCommandsCommandParameter param in importCommand.Parameter)
            {
                if (param.data == null)
                {
                    Parameters.Add(new CommandParameter(param.Key, param.Value));
                }
                else
                {
                    Parameters.Add(new CommandParameter(param.Key, param.Value, param.data));
                }
            }
        }
    }
}
