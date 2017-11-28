using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


namespace RAYEDPS
{
#if UNITY_EDITOR
    public class BarajaFactory : ScriptableObject
    {
        [MenuItem("Assets/RAYEDPS/Crear/Baraja")]
        public static void CrearBaraja()
        {

            Baraja baraja = ScriptableObject.CreateInstance<Baraja>();
            AssetDatabase.CreateAsset(baraja, "Assets/Objetos/Baraja.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = baraja;

        }


    }

#endif
}
