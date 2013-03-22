using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    public interface IPlayerCtrl
    {
        /// <summary>
        /// 移动
        /// </summary>
        void Move(Direction dir);

        /// <summary>
        /// 攻击
        /// </summary>
        void Attack();
    }
}
