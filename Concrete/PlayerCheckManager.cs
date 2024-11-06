using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;
using ServiceReference1;

namespace GameDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            //KPSPublicSoapClient client=new KPSPublicSoapClient();
            //bu yanlış kullanımdır. en küçük değişiklikte kod patlar.
            return true;
        }
    }
}
