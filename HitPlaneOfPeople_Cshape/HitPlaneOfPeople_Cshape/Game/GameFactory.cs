using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 针对一些类的创建，而进行的封装.
    /// </summary>
    public static class GameFactory
    {
        public static IBullet CreateBullet(float x, float y)
        {
            return null;
        }

        public static IPawn CreateEnemy()
        {
            return null;
        }

        public static IPawn CreateBoss()
        {
            return null;
        }

        public static IPawn CreatePlayer()
        {
            return null;
        }
    }
}
