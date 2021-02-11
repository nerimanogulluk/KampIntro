using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Silindi.");
        }

        public void UpDate(Game game)
        {
            Console.WriteLine(game.GameName + "Güncellendi.");
        }
    }
}
