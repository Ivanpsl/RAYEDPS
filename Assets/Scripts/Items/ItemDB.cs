using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAYEDPS
{
    public class ItemDB : ScriptableObject
    {

        //Singleton
        public static ItemDB Instance { get; set; }


        public List<BaseItem> itemList = new List<BaseItem>();

        void Start()
        {
            if (Instance != null && Instance != this) Destroy(this);
            else Instance = this;
 
        }

        
    }
}
