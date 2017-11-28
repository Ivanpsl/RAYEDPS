using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RAYEDPS
{
    

    [System.Serializable]
    public class BaseItem : ScriptableObject
    {

        //Propiedades del item
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public ItemType Type { get; set; }


        //es unico/legendario
        public bool IsUnique { get; set; }

        //visual
        public Texture2D ItemIcon { get; set; }
        public Sprite ItemSprite { get; set; }
        //Rigidbody ItemObject { get; set; }


        

    }
}