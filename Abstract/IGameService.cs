using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
        public void Sale(Game game , Player player , Campaign campaign);
        public void AddGame(Game game);
        public void RemoveGame(Game game);
        public void UpdateGame(Game game);
    }
}
