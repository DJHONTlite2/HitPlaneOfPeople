using System;
using System.Collections.Generic;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 相当于碰撞的管理器,这些实现ICollider的类会被添加进来集体管理。
    /// 继承了IUpdate接口，实时刷新的事件就在Update函数中处理。
    /// </summary>
    public interface ICollision : IUpdate
    {
        void Add(ICollider coll, string name);
        void Remove(ICollider coll);
        void Remove(string name);
    }
}
