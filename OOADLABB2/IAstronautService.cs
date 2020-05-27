using System;
using System.Collections.Generic;

namespace OOADLABB2
{
    public interface IAstronautService
    {
        IEnumerable<Astronauts> GetAstronauts();
    }
}