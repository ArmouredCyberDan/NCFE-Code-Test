using Ncfe.CodeTest.Interfaces;
using System.Collections.Generic;

namespace Ncfe.CodeTest.Repositories
{
    public class FailoverRepository : IFailoverRepository
    {
        public List<IFailoverEntry> GetFailOverEntries()
        {
            // return all from fail entries from database
            return new List<IFailoverEntry>();
        }
    }
}