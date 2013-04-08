//Auther:DJHONT
//Date:2013-4-8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople_Cshape
{
    //ReMark: 做摄像机的时候，注意坐标问题,和俯视视角的xyz对应
    public class PlayerCtrl : IPlayerCtrl
    {
        private IPlayer mPlayer;
        private float mSpeed;

        public PlayerCtrl(IPlayer player)
        {
            this.mPlayer = player;
        }

        #region IPlayerCtrl 成员

        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.left:

                    mPlayer.X -= mSpeed;

                break;

                case Direction.right:

                    mPlayer.X += mSpeed;

                break;

                case Direction.up:

                    mPlayer.Y -= mSpeed;

                break;

                case Direction.down:

                    mPlayer.Y += mSpeed;

                break;
            }
        }

        public void Attack()
        {
            mPlayer.Attack();
        }

        #endregion
    }
}
