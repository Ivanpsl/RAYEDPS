using System.Collections;
using System.Collections.Generic;

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
namespace RAYEDPS
{
    public class ItemFactory
    {

#if UNITY_EDITOR

        [MenuItem("Assets/RAYEDPS/Crear/Arma")]
        public static void CreateArma()
        {

            BaseWeapon arma = ScriptableObject.CreateInstance<BaseWeapon>();
            AssetDatabase.CreateAsset(arma, "Assets/Objetos/CartasItems/Armas/nuevaArma.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = arma;
        }


        [MenuItem("Assets/RAYEDPS/Crear/Pocion")]
        public static void CreatePociones()
        {

            BasePotion pocion = ScriptableObject.CreateInstance<BasePotion>();
            AssetDatabase.CreateAsset(pocion, "Assets/Objetos/CartasItems/Pociones/nuevaPocion.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = pocion;
        }

        //[MenuItem("Assets/RAYEDPS/Crear/Trampa")]
        //public static void CrearTrampa()
        //{

        //    BaseRefuerzo escudo = ScriptableObject.CreateInstance<BaseRefuerzo>();
        //    AssetDatabase.CreateAsset(escudo, "Assets/CartasItems/Pociones/nuevoRefuerzo.asset");
        //    AssetDatabase.SaveAssets();
        //    EditorUtility.FocusProjectWindow();
        //    Selection.activeObject = escudo;
        //}
#endif
    }
}
