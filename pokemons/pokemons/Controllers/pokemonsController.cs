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
            {
                var pokemonsToUpdate = ex.pokemons.Where(p => p.Id == id).FirstOrDefault();
                if (pokemonsToUpdate != null)
                {
                    pokemonsToUpdate.Id = s.id;
                    pokemonsToUpdate.Name = s.Name;
                    pokemonsToUpdate.Age = s.Age;
                    ex.SaveChanges();
                }
            }
        }
    }
}
