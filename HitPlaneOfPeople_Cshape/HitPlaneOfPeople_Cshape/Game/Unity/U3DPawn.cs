using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HitPlaneOfPeople_Cshape
{
    public class U3DPawn : IPawn
    {
        private GameObject mGameObj;

        public U3DPawn()
        {
            this.mGameObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.mGameObj.name = "Pawn";
        }

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
