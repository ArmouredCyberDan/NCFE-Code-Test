using Ncfe.CodeTest.Models.Abstractions;
using System.Collections.Generic;

namespace Ncfe.CodeTest.Repositories.Abstractions
{
    public interface IFailoverRepository
    {
        List<IFailoverEntry> GetFailOverEntries();
    }
}