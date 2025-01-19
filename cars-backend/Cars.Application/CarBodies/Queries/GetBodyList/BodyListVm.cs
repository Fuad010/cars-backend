using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Queries.GetBodyList
{
    public class BodyListVm
    {
        public IList<BodyLookupDto> Bodies { get; set; }
    }
}
