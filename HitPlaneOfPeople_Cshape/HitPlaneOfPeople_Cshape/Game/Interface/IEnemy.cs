using System;
using System.Collections.Generic;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 敌人类接口
    /// </summary>
    public interface IEnemy : ICollider, IPawn
    {
        /// <summary>
        /// 当这个敌人被激活时.(当玩家快遇到它时,会被激活)
        /// </summary>
        void OnActiveUpdate();
        /// <summary>
        /// 如果该敌人会以飞出屏幕外结束，就需要这个函数。否则死亡才算结束.(一直执行在判断)
        /// </summary>
        /// <returns></returns>
        bool IsMoveOut();
    }
}