using System.Collections.Generic;

namespace OOADLABB2
{
    public class AstronautServices : IAstronautService
    {
        public IEnumerable<Astronauts> GetAstronauts()
        {
            AstronautRepository astronautRepository = new AstronautRepository();
            return astronautRepository.GetCurrentAstronauts();
        }
    }
}