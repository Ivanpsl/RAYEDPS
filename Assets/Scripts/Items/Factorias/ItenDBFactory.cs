using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace RAYEDPS
{
    public class ItemDBFactory
    {
        [MenuItem("RAYEDPS/Crear/EMERGENCIA ITENDB")]
        public static ItemDB Create()
        {
            ItemDB asset = ScriptableObject.CreateInstance<ItemDB>();
            int numero = Random.Range(0, 10000);
            AssetDatabase.CreateAsset(asset, "Assets/BD/bd" + numero + ".asset");
            AssetDatabase.SaveAssets();
            return asset;
        }
    }
}
