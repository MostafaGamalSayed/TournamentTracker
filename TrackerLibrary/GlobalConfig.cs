using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    class GlobalConfig
    {

        /// <summary>
        /// Holds all types of data connections
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; }


        /// <summary>
        /// It creates the different type of data connections
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFiles"></param>
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Craete sql connection
                
            }

            if (textFiles)
            {
                // TODO - Create text files connection
            }
        }
    }
}
