using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace NewParticleArray
{
    public static class GlobalVariable
    {
        public static readonly IList<string> Pages = new ReadOnlyCollection<string>(new List<string> { "Home", "About", "Projects", "Contact" });
    }
}