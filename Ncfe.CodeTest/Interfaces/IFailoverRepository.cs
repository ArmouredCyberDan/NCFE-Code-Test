﻿using System.Collections.Generic;

namespace Ncfe.CodeTest.Interfaces
{
    public interface IFailoverRepository
    {
        List<IFailoverEntry> GetFailOverEntries();
    }
}