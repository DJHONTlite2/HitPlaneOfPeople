using System;
using System.Collections.Generic;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    public interface IBullet : ICollider
    {
        /// <summary>
        /// 获得子弹速度
        /// </summary>
        /// <returns></returns>
        int GetSpeed();
        /// <summary>
        /// 设置它发射.执行后就会在游戏屏幕上发射出一颗子弹.
        /// 在屏幕上创建子弹要从工厂去拿. IBullet bullet = GameFactory.CreateBullet();
        /// </summary>
        void Shot(float x, float y);
    }
}