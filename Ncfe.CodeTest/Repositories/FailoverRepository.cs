using Ncfe.CodeTest.Models.Abstractions;
using Ncfe.CodeTest.Repositories.Abstractions;
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