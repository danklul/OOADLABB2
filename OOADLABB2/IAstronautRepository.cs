using System;
using System.Collections.Generic;

namespace OOADLABB2
{
    public interface IAstronautRepository
    {
        IEnumerable<Astronauts> GetCurrentAstronauts();
    }
}