using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONN.utils
{
    class MenuChoices
    {
        public static string[] Entries = { };

        public MenuChoices(string[] _entries)
        {
            Entries = _entries;
        }

        public static void SetupMenuChoices()
        {
            for (int i = 0; i < Entries.Length; i++)
            {
                Console.SetCursorPosition(DrawMenu.X + 2, DrawMenu.Y + 2 + i);
                Console.WriteLine(Entries[i]);
            }
        }
        public static void Case(string? _choice)
        {
            switch (_choice)
            {
                case "1":
                    DrawPokemonMenu();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    Program.Exit = false;
                    break;
                default:
                    break;
            }
        }

        public static void DrawPokemonMenu()
        {
            Console.WriteLine("What is the pokemon name: ");
            string pokeName = Console.ReadLine();
            Console.WriteLine("What is the pokemon type: ");
            string pokeType = Console.ReadLine();
            Console.WriteLine("What is the pokemon level: ");
            int pokeLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the pokemon strenght: ");
            int pokeStrength = int.Parse(Console.ReadLine());
            Program.pokemons.Add(new programs.AddPokemon()
            {
                Name = pokeName,
                Type = pokeType,
                Strength = pokeStrength,
                Level = pokeLevel
            }
          );
        }
    }
}
