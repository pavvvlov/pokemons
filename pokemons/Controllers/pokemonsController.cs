using pokemons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemons.Controllers
{
    class pokemonsController
    {
        public List<pokemon> GetPokemons()
        {
            using (Database1Entities ex = new Database1Entities())
            {
                return ex.pokemons.ToList();
            }
        }
    }
}
