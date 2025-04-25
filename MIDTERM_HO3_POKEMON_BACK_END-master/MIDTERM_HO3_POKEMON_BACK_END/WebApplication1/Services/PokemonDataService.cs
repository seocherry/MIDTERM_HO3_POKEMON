using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PokemonDataService
    {
        private readonly List<Pokemon> _pokemons;

        public PokemonDataService()
        {
            _pokemons = GeneratePokemonData();
        }

        public List<Pokemon> GetAllPokemons() => _pokemons;

        public Pokemon GetPokemonById(int id) => _pokemons.FirstOrDefault(p => p.Id == id);

        public List<Pokemon> GetPokemonsByGeneration(int generation) =>
            _pokemons.Where(p => p.Generation == generation).ToList();

        public List<Pokemon> GetPaginatedPokemons(int page, int pageSize) =>
            _pokemons.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        private List<Pokemon> GeneratePokemonData()
        {
            return new List<Pokemon>
            {
                new Pokemon {
                    Id = 1, Name = "Bulbasaur", Types = new List<string> { "Grass", "Poison" },
                    Generation = 1, NextEvolutionId = 2, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/bulbasaur.jpg",
                    Height = 7, Weight = 69
                },
                new Pokemon {
                    Id = 2, Name = "Ivysaur", Types = new List<string> { "Grass", "Poison" },
                    Generation = 1, NextEvolutionId = 3, BaseEvolutionId = 1,
                    ImageUrl = "https://img.pokemondb.net/artwork/ivysaur.jpg",
                    Height = 10, Weight = 130
                },
                new Pokemon {
                    Id = 3, Name = "Charmander", Types = new List<string> { "Fire" },
                    Generation = 1, NextEvolutionId = 5, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/charmander.jpg",
                    Height = 6, Weight = 85
                },
                new Pokemon {
                    Id = 4, Name = "Charmeleon", Types = new List<string> { "Fire" },
                    Generation = 1, NextEvolutionId = 6, BaseEvolutionId = 4,
                    ImageUrl = "https://img.pokemondb.net/artwork/charmeleon.jpg",
                    Height = 11, Weight = 190
                },
                new Pokemon {
                    Id = 5, Name = "Charizard", Types = new List<string> { "Fire", "Flying" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 4,
                    ImageUrl = "https://img.pokemondb.net/artwork/charizard.jpg",
                    Height = 17, Weight = 905
                },
                new Pokemon {
                    Id = 6, Name = "Blastoise", Types = new List<string> { "Water" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 7,
                    ImageUrl = "https://img.pokemondb.net/artwork/blastoise.jpg",
                    Height = 16, Weight = 855
                },
                new Pokemon {
                    Id = 7, Name = "Caterpie", Types = new List<string> { "Bug" },
                    Generation = 2, NextEvolutionId = 153, BaseEvolutionId = null,
                    ImageUrl = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/010.png",
                    Height = 300, Weight = 3000
                },
                new Pokemon {
                    Id = 8, Name = "Butterfree", Types = new List<string> { "Bug", "Flying" },
                    Generation = 2, NextEvolutionId = 154, BaseEvolutionId = 152,
                    ImageUrl = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/012.png",
                    Height = 110, Weight = 3200
                },
                new Pokemon {
                    Id = 9, Name = "Bayleef", Types = new List<string> { "Grass" },
                    Generation = 2, NextEvolutionId = 154, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/bayleef.jpg",
                    Height = 120, Weight = 1580
                },
                new Pokemon {
                    Id = 10, Name = "Kakuna", Types = new List<string> { "Bug", "Poison" },
                    Generation = 2, NextEvolutionId = null, BaseEvolutionId = 14,
                    ImageUrl = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/014.png",
                    Height = 60, Weight = 1000
                },
                 new Pokemon {
                    Id = 11, Name = "Beedrill", Types = new List<string> { "Bug", "Poison" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 15,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/beedrill.avif",
                    Height = 100, Weight = 2900
                 },
                new Pokemon {
                    Id = 12, Name = "Fearow", Types = new List<string> { "Flying", "Normal" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 22,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/fearow.avif",
                    Height = 120, Weight = 3200
                },
                new Pokemon {
                    Id = 13, Name = "Ekans", Types = new List<string> { "Poison"},
                    Generation = 1, NextEvolutionId = 24, BaseEvolutionId = 23,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/ekans.avif",
                    Height = 20, Weight = 690
                },
                new Pokemon {
                    Id = 14, Name = "Arbok", Types = new List<string> { "Poison"},
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 24,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/arbok.avif",
                    Height = 350, Weight = 6500
                },
                new Pokemon {
                    Id = 15, Name = "Geodude", Types = new List<string> { "Rock", "Ground" },
                    Generation = 1, NextEvolutionId = 75, BaseEvolutionId = 74,
                    ImageUrl = "https://img.pokemondb.net/artwork/geodude.jpg",
                    Height = 40, Weight = 2000
                },
                new Pokemon {
                    Id = 16, Name = "Graveler", Types = new List<string> { "Rock", "Ground" },
                    Generation = 1, NextEvolutionId = 76, BaseEvolutionId = 75,
                    ImageUrl = "https://img.pokemondb.net/artwork/graveler.jpg",
                    Height = 10, Weight = 1050
                },
                new Pokemon {
                    Id = 17, Name = "Golem", Types = new List<string> { "Rock", "Ground" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 7,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/golem.avif",
                    Height = 140, Weight = 30000
                },
                new Pokemon {
                    Id = 18, Name = "Abra", Types = new List<string> { "Psychic" },
                    Generation = 1, NextEvolutionId = 64, BaseEvolutionId = 63,
                    ImageUrl = "https://img.pokemondb.net/artwork/abra.jpg",
                    Height = 90, Weight = 1950
                },
                new Pokemon {
                    Id = 19, Name = "Kadabra", Types = new List<string> { "Psychic" },
                    Generation = 1, NextEvolutionId = 65, BaseEvolutionId = 64,
                    ImageUrl = "https://img.pokemondb.net/artwork/kadabra.jpg",
                    Height = 130, Weight = 5650
                },
                new Pokemon {
                    Id = 20, Name = "Alakazam", Types = new List<string> { "Psychic" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 65,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/alakazam.avif",
                    Height = 150, Weight = 4800
                },
                new Pokemon {
                    Id = 21, Name = "Cyndaquil", Types = new List<string> { "Fire" },
                    Generation = 2, NextEvolutionId = 156, BaseEvolutionId = 155,
                    ImageUrl = "https://img.pokemondb.net/artwork/cyndaquil.jpg",
                    Height = 50, Weight = 790
                },
                new Pokemon {
                    Id = 22, Name = "Quilava", Types = new List<string> { "Fire" },
                    Generation = 2, NextEvolutionId = 157, BaseEvolutionId = 156,
                    ImageUrl = "https://img.pokemondb.net/artwork/quilava.jpg",
                    Height = 90, Weight = 1900
                },
        
                new Pokemon {
                    Id = 23, Name = "Clefairy", Types = new List<string> { "Fairy" },
                    Generation = 1, NextEvolutionId = 36, BaseEvolutionId = 35,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/clefairy.avif",
                    Height = 60, Weight = 750
                },
                new Pokemon {
                    Id = 24, Name = "Clefable", Types = new List<string> { "Fairy" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 36,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/clefable.avif",
                    Height = 130, Weight = 4000
                },
                new Pokemon {
                    Id = 25, Name = "Croconaw", Types = new List<string> { "Water" },
                    Generation = 2, NextEvolutionId = 160, BaseEvolutionId = 159,
                    ImageUrl = "https://img.pokemondb.net/artwork/croconaw.jpg",
                    Height = 110, Weight = 2500
                },
                new Pokemon {
                    Id = 26, Name = "Feraligatr", Types = new List<string> { "Water" },
                    Generation = 2, NextEvolutionId = null, BaseEvolutionId = 160,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/feraligatr.avif",
                    Height = 110, Weight = 2500
                },
                new Pokemon {
                    Id = 27, Name = "Igglybuff", Types = new List<string> { "Fairy", "Normal" },
                    Generation = 1, NextEvolutionId = 40, BaseEvolutionId = 39,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/igglybuff.avif",
                    Height = 30, Weight = 100
                },
                new Pokemon {
                    Id = 28, Name = "Jigglypuff", Types = new List<string> { "Fairy", "Normal" },
                    Generation = 1, NextEvolutionId = 40, BaseEvolutionId = 39,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/jigglypuff.avif",
                    Height = 50, Weight = 550
                },
                new Pokemon {
                    Id = 29, Name = "Wigllytiff", Types = new List<string> { "Normal", "Fairy" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 40,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/wigglytuff.avif",
                    Height = 10, Weight = 1200
                },
                new Pokemon {
                    Id = 30, Name = "Bellossom", Types = new List<string> { "Grass" },
                    Generation = 2, NextEvolutionId = 160, BaseEvolutionId = 158,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/bellossom.avif",
                    Height = 104, Weight = 12
                },
                new Pokemon {
                    Id = 31, Name = "Vileplume", Types = new List<string> { "Grass", "Poison" },
                    Generation = 1, NextEvolutionId = 160, BaseEvolutionId = 158,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/vileplume.avif",
                    Height = 12, Weight = 18
                },
                new Pokemon {
                    Id = 32, Name = "Exeggutor", Types = new List<string> { "Grass", "Psychic" },
                    Generation = 1, NextEvolutionId = 160, BaseEvolutionId = 158,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/vileplume.avif",
                    Height = 607, Weight = 264
                },
                new Pokemon {
                    Id = 33, Name = "Diglett", Types = new List<string> { "Ground"},
                    Generation = 1, NextEvolutionId = 51, BaseEvolutionId = 50,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/diglett.avif",
                    Height = 20, Weight = 80
                },
                new Pokemon {
                    Id = 34, Name = "Dugtrio", Types = new List<string> {"Ground"},
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 51,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/dugtrio.avif",
                    Height = 70, Weight = 3330
                },
                new Pokemon {
                    Id = 35, Name = "Growlithe", Types = new List<string> {"Fire"},
                    Generation = 1, NextEvolutionId = 59, BaseEvolutionId = 58,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/growlithe.avif",
                    Height = 70, Weight = 1900
                },
                 new Pokemon {
                    Id = 36, Name = "Arcanine", Types = new List<string> {"Fire"},
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 59,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/arcanine.avif",
                    Height = 190, Weight = 15500
                },
                 new Pokemon {
                    Id = 37, Name = "Doduo", Types = new List<string> { "Flying" },
                    Generation = 1, NextEvolutionId = 85, BaseEvolutionId = 84,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/doduo.avif",
                    Height = 140, Weight = 3920
                },
                 new Pokemon {
                    Id = 38, Name = "Dodrio", Types = new List<string> { "Flying" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 85,
                    ImageUrl = "https://img.pokemondb.net/artwork/avif/dodrio.avif",
                    Height = 170, Weight = 8500
                },
                new Pokemon {
                        Id = 39, Name = "Seel", Types = new List<string> { "Water" },
                        Generation = 1, NextEvolutionId = 87, BaseEvolutionId = 86,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/seel.avif",
                        Height = 110, Weight = 900
                },
                new Pokemon {
                        Id = 40, Name = "Dewgong", Types = new List<string> { "Water" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 87,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/dewgong.avif",
                        Height = 170, Weight = 1200
                },
                new Pokemon {
                        Id = 41, Name = "Grimer", Types = new List<string> { "Poison" },
                        Generation = 1, NextEvolutionId = 89, BaseEvolutionId = 88,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/grimer.avif",
                        Height = 90, Weight = 3000
                },
                new Pokemon {
                        Id = 42, Name = "Muk", Types = new List<string> { "Poison" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 89,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/muk.avif",
                        Height = 130, Weight = 3000
                },
                new Pokemon {
                        Id = 43, Name = "Shellder", Types = new List<string> { "Water" },
                        Generation = 1, NextEvolutionId = 91, BaseEvolutionId = 90,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/shellder.avif",
                        Height = 40, Weight = 40
                },
                new Pokemon {
                        Id = 44, Name = "Cloyster", Types = new List<string> { "Water", "Ice" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 91,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/cloyster.avif",
                        Height = 150, Weight = 1325
                },
                new Pokemon {
                        Id = 45, Name = "Gastly", Types = new List<string> { "Ghost", "Poison" },
                        Generation = 1, NextEvolutionId = 93, BaseEvolutionId = 92,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/gastly.avif",
                        Height = 10, Weight = 1
                },
                new Pokemon {
                        Id = 46, Name = "Haunter", Types = new List<string> { "Ghost", "Poison" },
                        Generation = 1, NextEvolutionId = 94, BaseEvolutionId = 93,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/haunter.avif",
                        Height = 160, Weight = 1
                },
                new Pokemon {
                        Id = 47, Name = "Gengar", Types = new List<string> { "Ghost", "Poison" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 94,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/gengar.avif",
                        Height = 150, Weight = 405
                },
                new Pokemon {
                        Id = 48, Name = "Onix", Types = new List<string> { "Rock", "Ground" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 95,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/onix.avif",
                        Height = 880, Weight = 2100
                },
                new Pokemon {
                        Id = 49, Name = "Drowzee", Types = new List<string> { "Psychic" },
                        Generation = 1, NextEvolutionId = 97, BaseEvolutionId = 96,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/drowzee.avif",
                        Height = 100, Weight = 320
                },
                new Pokemon {
                        Id = 50, Name = "Hypno", Types = new List<string> { "Psychic" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 97,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/hypno.avif",
                        Height = 160, Weight = 750
                },
                new Pokemon {
                        Id = 51, Name = "Krabby", Types = new List<string> { "Water" },
                        Generation = 1, NextEvolutionId = 99, BaseEvolutionId = 98,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/krabby.avif",
                        Height = 40, Weight = 65
                },
                new Pokemon {
                        Id = 52, Name = "Kingler", Types = new List<string> { "Water" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 99,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/kingler.avif",
                        Height = 130, Weight = 600
                },
                new Pokemon {
                        Id = 53, Name = "Voltorb", Types = new List<string> { "Electric" },
                        Generation = 1, NextEvolutionId = 101, BaseEvolutionId = 100,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/voltorb.avif",
                        Height = 50, Weight = 100
                },
                new Pokemon {
                        Id = 54, Name = "Electrode", Types = new List<string> { "Electric" },
                        Generation = 1, NextEvolutionId = null, BaseEvolutionId = 101,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/electrode.avif",
                        Height = 120, Weight = 666
                },
                new Pokemon {
                        Id = 55, Name = "Exeggcute", Types = new List<string> { "Grass", "Psychic" },
                        Generation = 1, NextEvolutionId = 103, BaseEvolutionId = 102,
                        ImageUrl = "https://img.pokemondb.net/artwork/avif/exeggcute.avif",
                        Height = 40, Weight = 250
                },
            };
        }
    }
}
