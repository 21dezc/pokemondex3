using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemondex3
{
    public static class PokemonFactory
    {
        public static Pokemon GetPokemon(string name)
        {
            switch (name)
            {
                case "Pikachu": return new Pikachu();
                case "Mew": return new Mew();
                case "Alcremie": return new Alcremie();
                case "Whismur": return new Whismur();
                case "Swirlix": return new Swirlix();
                case "Sylveon": return new Sylveon();

               
                default: return null;
            }
        }
    }
}
