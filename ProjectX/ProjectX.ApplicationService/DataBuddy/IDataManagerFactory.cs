﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
    public interface IDataManagerFactory
    {
        DataManager GetDataManager();
    }
}
