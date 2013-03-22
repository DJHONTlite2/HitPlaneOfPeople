using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 当前屏幕位于地图的位置,怪物是否激活等
    /// </summary>
    public interface IEngine : IUpdate
    {
        /// <summary>
        /// 初始化当前关卡
        /// </summary>
        void GameInit(IMission mission);
        /// <summary>
        /// 暂停当前关卡
        /// </summary>
        void Pause();
        /// <summary>
        /// 继续当前关卡
        /// </summary>
        void Continue();
        /// <summary>
        /// 声音开或者关
        /// </summary>
        /// <param name="toggle"></param>
        void VoiceSetting(bool toggle);
    }
}
