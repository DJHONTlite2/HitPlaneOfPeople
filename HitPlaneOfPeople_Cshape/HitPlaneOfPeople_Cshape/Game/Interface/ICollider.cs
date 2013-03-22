using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 碰撞物,实现碰撞必须实现此接口
    /// </summary>
    public interface ICollider
    {
        /// <summary>
        /// 相对坐标，坐标0,0是中心点.
        /// </summary>
        void GetColliderSize(out float x, out float y, out float w, out float h);

        /// <summary>
        /// 获得全局坐标
        /// </summary>
        void GetPos(out float x, out float y);

        /// <summary>
        /// 发生碰撞的时候响应(只触发一次).
        /// </summary>
        /// <param name="target">碰撞上的目标</param>
        void OnCollision(string target);
    }
}
