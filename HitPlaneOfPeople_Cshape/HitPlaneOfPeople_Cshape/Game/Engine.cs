using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    /// <summary>
    /// 控制游戏的整体运行.(不是游戏引擎,而是意义上的引擎)
    /// </summary>
    public class Engine : IEngine
    {
        #region IEngine 成员

        public void GameInit(IMission mission)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Continue()
        {
            throw new NotImplementedException();
        }

        public void VoiceSetting(bool toggle)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IUpdate 成员

        public void Update()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
