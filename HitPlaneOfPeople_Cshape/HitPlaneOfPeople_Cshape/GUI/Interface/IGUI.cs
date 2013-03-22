using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    public interface IGUI
    {
        void MoveUI(IPlayerCtrl playerCtrl);
        void SettingUI(IEngine engine);
    }
}
