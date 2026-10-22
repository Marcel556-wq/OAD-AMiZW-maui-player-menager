/*************************************************************************
 * nazwa klasy:
 * EditPlayerCommandHandler
 *
 * opis:
 * Klasa obsługuje polecenie edycji gracza.
 * Wyszukuje gracza po Id i zmienia jego nazwę oraz poziom.
 *
 * pola / właściwości:
 * _playerRepository, PlayerRepository, repozytorium przechowujące graczy
 *
 * autor:
 * Marcel Szyca
 *************************************************************************/

using MauiApp3.Data;
using System.Linq;

namespace MauiApp3.Commands
{
    public class EditPlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;

        /*************************************************************************
         * nazwa funkcji:
         * EditPlayerCommandHandler
         *
         * parametry wejściowe:
         * playerRepository, PlayerRepository, repozytorium graczy
         *
         * wartość zwracana:
         * brak
         *
         * opis funkcji:
         * Przekazuje repozytorium graczy do handlera.
         *
         * autor:
         * Marcel Szyca
         *************************************************************************/
        public EditPlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        /*************************************************************************
         * nazwa funkcji:
         * Handle
         *
         * parametry wejściowe:
         * command, EditPlayerCommand, polecenie z Id, nową nazwą i poziomem
         *
         * wartość zwracana:
         * bool, informacja, czy znaleziono i edytowano gracza
         *
         * opis funkcji:
         * Wyszukuje gracza po Id. Jeśli gracz istnieje, zmienia jego nazwę
         * oraz poziom i zwraca true. W przeciwnym razie zwraca false.
         *
         * autor:
         * Marcel Szyca
         *************************************************************************/
        public bool Handle(EditPlayerCommand command)
        {
            var player = _playerRepository.Players
                .FirstOrDefault(p => p.Id == command.Id);

            if (player == null)
            {
                return false;
            }

            player.Name = command.Name;
            player.Level = command.Level;

            return true;
        }
    }
}
