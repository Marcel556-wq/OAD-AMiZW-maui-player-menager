/*************************************************************************
 * nazwa klasy:
 * EditPlayerCommand
 *
 * opis:
 * Klasa reprezentuje polecenie edycji gracza.
 * Przechowuje Id gracza, nową nazwę oraz nowy poziom.
 *
 * pola / właściwości:
 * Id, int, identyfikator gracza do edycji
 * Name, string, nowa nazwa gracza
 * Level, int, nowy poziom gracza
 *
 * autor:
 * Marcel Szyca
 *************************************************************************/

namespace MauiApp3.Commands
{
    public class EditPlayerCommand
    {
        public int Id { get; }
        public string Name { get; }
        public int Level { get; }

        /*************************************************************************
         * nazwa funkcji:
         * EditPlayerCommand
         *
         * parametry wejściowe:
         * id, int, identyfikator edytowanego gracza
         * name, string, nowa nazwa gracza
         * level, int, nowy poziom gracza
         *
         * wartość zwracana:
         * brak
         *
         * opis funkcji:
         * Tworzy polecenie zawierające dane potrzebne do edycji gracza.
         *
         * autor:
         * Marcel Szyca
         *************************************************************************/
        public EditPlayerCommand(int id, string name, int level)
        {
            Id = id;
            Name = name;
            Level = level;
        }
    }
}
