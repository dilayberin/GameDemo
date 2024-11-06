using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IPlayerService
    {
        public void SavePlayer(Player player);
        public void RemovePlayer (Player player);
        public void UpdatePlayer (Player player);

    }
}
