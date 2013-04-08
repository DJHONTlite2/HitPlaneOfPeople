using System;
using System.Collections.Generic;
using System.Linq;
//Auther:DJHONT
//Date:2013-4-8
//这些Unity中间件直接连接引擎Engine类

using System.Text;
using UnityEngine;

namespace HitPlaneOfPeople_Cshape
{
    public class U3DPlayer : IPlayer
    {
        private GameObject mGameObj;

        public U3DPlayer()
        {
            this.mGameObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.mGameObj.name = "player";
        }

        #region ICollider 成员

        public void GetColliderSize(out float x, out float y, out float w, out float h)
        {
            throw new NotImplementedException();
        }

        public void GetPos(out float x, out float y)
        {
            throw new NotImplementedException();
        }

        public void OnCollision(string target)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IPawn 成员

        public float X
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float Y
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void UnderAttack(int damage)
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Death()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
