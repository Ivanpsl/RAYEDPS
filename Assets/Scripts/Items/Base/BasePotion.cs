using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAYEDPS
{
    public class BasePotion : BaseItem
    {


        #region newData
        public PocionType type;
        public float buff;

        public bool temporal=false;
        public float sec;
        #endregion

        public BasePotion()
        {
            Type = ItemType.CONSUMABLE;

        }
    }



}