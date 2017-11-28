using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAYEDPS
{


    [CreateAssetMenu]
    [System.Serializable]
    public class BaseWeapon: BaseItem
    {

        #region Data

        public WeaponType weaponType;
        public DiceBase[] _DiceUsed { get; set; }
        #endregion

        #region Constructor


        public  BaseWeapon()
        {   
            Type = ItemType.WEAPON;
        }

        public BaseWeapon(string name, WeaponType wType)
        {
            
            this.ItemName = name;
            Type = ItemType.WEAPON;
            weaponType = wType;
        }
        #endregion

        #region Methods

        private BaseWeapon SetWeaponType(WeaponType wT)
        {
            weaponType = wT;
            return this;
        }        
                
        #endregion

    }

}