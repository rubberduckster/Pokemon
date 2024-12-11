using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POKEMONN.programs;

namespace POKEMONN.utils
{
    class FileHandler
    {
        public static string? FileName { get; set; }

        public FileHandler(string? _filename)
        {
            FileName = _filename;
        }

        /// <summary>
        /// This method check if the file exists, if the file doesn't exist
        /// then it will be created
        /// </summary>
        public static void CreateFile()
        {
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }
        }

        public static string? WriteToFile(List<AddPokemon> _pokemons)
        {
            try
            {
                string[] pokemonNames = _pokemons.Select(p => p.Name + "," + p.Type + "," + p.Level + "," + p.Strength).ToArray();
                File.WriteAllLines(FileName, pokemonNames);
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static void ReadFromFile()
        {
            string[] pokemonNames = File.ReadAllLines(FileName);
            List<AddPokemon> pokemons = [];
            for (int i = 0; i < pokemonNames.Length; i++)
            {
                string pokemonName = pokemonNames[i];
                string[] Values = pokemonName.Split(',');
                string PokemonName = Values[0];
                string PokemonType = Values[1];
                int PokeLevel = int.Parse(Values[2]);
                int PokeStrength = int.Parse(Values[3]);
                pokemons.Add(new AddPokemon()
                {
                    Name = pokemonName,
                    Type = PokemonType,
                    Level = PokeLevel,
                    Strength = PokeStrength
                });
            }
            Program.pokemons = pokemons;
        }
    }
}
