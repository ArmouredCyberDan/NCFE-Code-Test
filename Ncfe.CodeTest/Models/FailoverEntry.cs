using Ncfe.CodeTest.Models.Abstractions;
using System;

namespace Ncfe.CodeTest.Models
{
    public class FailoverEntry : IFailoverEntry
    {
        public DateTime DateTime { get; set; }
    }
}
