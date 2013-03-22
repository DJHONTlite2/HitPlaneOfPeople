using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 关卡类
    /// </summary>
    public interface IMission
    {
        string Name { get; }
        IEnemy[] GetEnemys();
        IPlayer GetPlayer();
        IMap GetMap();
    }
}
