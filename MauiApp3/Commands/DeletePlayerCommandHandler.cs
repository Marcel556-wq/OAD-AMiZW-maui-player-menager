/*************************************************************************
 * nazwa klasy:
 * DeletePlayerCommandHandler
 *
 * opis:
 * Klasa obsługuje polecenie usunięcia gracza.
 * Wyszukuje gracza po identyfikatorze i usuwa go z repozytorium.
 *
 * pola / właściwości:
 * _playerRepository, PlayerRepository, repozytorium przechowujące listę graczy
 *
 * autor:
 * Marcel Szyca
 *************************************************************************/

using MauiApp3.Data;
using System.Linq;

namespace MauiApp3.Commands
{
    public class DeletePlayerCommandHandler
    {
        private readonly PlayerRepository _playerRepository;

        /*************************************************************************
         * nazwa funkcji:
         * DeletePlayerCommandHandler
         *
         * parametry wejściowe:
         * playerRepository, PlayerRepository, repozytorium graczy
         *
         * wartość zwracana:
         * brak
         *
         * opis funkcji:
         * Konstruktor przekazuje repozytorium graczy do handlera.
         *
         * autor:
         * Marcel Szyca
         *************************************************************************/
        public DeletePlayerCommandHandler(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        /*************************************************************************
         * nazwa funkcji:
         * Handle
         *
         * parametry wejściowe:
         * command, DeletePlayerCommand, polecenie zawierające Id gracza do usunięcia
         *
         * wartość zwracana:
         * brak
         *
         * opis funkcji:
         * Wyszukuje gracza o podanym Id i usuwa go z repozytorium,
         * jeżeli taki gracz istnieje.
         *
         * autor:
         * Marcel Szyca
         *************************************************************************/
        public void Handle(DeletePlayerCommand command)
        {
            var player = _playerRepository.Players
                .FirstOrDefault(p => p.Id == command.Id);

            if (player != null)
            {
                _playerRepository.Players.Remove(player);
            }
        }
    }
}
