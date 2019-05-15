using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.models;

namespace TrackerLibrary.DataAccess
{
    interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
