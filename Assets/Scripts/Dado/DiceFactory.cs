using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
namespace RAYEDPS
{

#if UNITY_EDITOR
    
    public class DiceFactory: EditorWindow
    {
        #region datos

        int side1, side2, side3, side4, side5 = 0;
        bool bside1, bside2, bside3, bside4, bside5 = false;

        bool numericDice=false;
        bool boolDice=false;

        #endregion

        #region GUI_Ventana
        
        [MenuItem("RAYEDPS/Crear/Dado")]
        public static void ShowWindow()
        {
            DiceFactory window = (DiceFactory)EditorWindow.GetWindow(typeof(DiceFactory));
            window.Show();

        }
      

        void OnGUI()
        {

            GUILayout.Label("Configuracion del dado:", EditorStyles.boldLabel);
            if(EditorGUILayout.BeginToggleGroup("Numerico:", numericDice))
            {
                numericDice = true;
                boolDice = false;
                side1 = EditorGUILayout.IntField("Lado1: ", side1);
                side2 = EditorGUILayout.IntField("Lado2: ", side2);
                side3 = EditorGUILayout.IntField("Lado3: ", side3);
                side4 = EditorGUILayout.IntField("Lado4: ", side4);
                side5 = EditorGUILayout.IntField("Lado5: ", side5);

            }
            else{
                numericDice = false;
            }
            EditorGUILayout.EndToggleGroup();

            EditorGUILayout.Separator();

            if (EditorGUILayout.BeginToggleGroup("Booleano:", boolDice))
            {
                numericDice = false;
                boolDice = true;
                bside1 = EditorGUILayout.Toggle("Lado1: ", bside1);
                bside2 = EditorGUILayout.Toggle("Lado2: ", bside2);
                bside3 = EditorGUILayout.Toggle("Lado3: ", bside3);
                bside4 = EditorGUILayout.Toggle("Lado4: ", bside4);
                bside5 = EditorGUILayout.Toggle("Lado5: ", bside5);

            }
            else
            {
                boolDice = false;
            }
            EditorGUILayout.EndToggleGroup();

            EditorGUILayout.Separator();
            EditorGUILayout.Separator();
            if (GUILayout.Button("Crear"))
            {
                if (boolDice)
                {
                    CreateBooleanDice();
                }
                else if(numericDice)
                {
                    CreateNumericDice();
                }
            }
            
        }
        #endregion


        #region metodos factoria

        public void CreateNumericDice()
        {
<<<<<<< HEAD
            DiceBase<int> dado = ScriptableObject.CreateInstance<DiceBase<int>>();
=======
            DiceBase dado = ScriptableObject.CreateInstance<DiceBase>();
>>>>>>> Try

            //dado = new DiceBase<int>(new int[5] { side1, side2, side3, side4,side5});
            AssetDatabase.CreateAsset(dado,"Assets/Scripts/Dado/Dados/dadoInt.asset");
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = dado;

<<<<<<< HEAD
            dado.SetFaces(new int[5] { side1, side2, side3, side4, side5 });
=======
          //  dado.SetFaces(new int[5] { side1, side2, side3, side4, side5 });
>>>>>>> Try
        }

        public void CreateBooleanDice()
        {
<<<<<<< HEAD
            DiceBase<bool> dado;
             dado = ScriptableObject.CreateInstance<DiceBase<bool>>();
            
            dado.SetFaces(new bool[5] { bside1, bside2, bside3, bside4, bside5 });
=======
            DiceBase dado;
             dado = ScriptableObject.CreateInstance<DiceBase>();
            
          //  dado.SetFaces(new bool[5] { bside1, bside2, bside3, bside4, bside5 });
>>>>>>> Try

            AssetDatabase.CreateAsset(dado, "Assets/Scripts/Dado/Dados/dadoBool.asset");
            
            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = dado;

        }
        #endregion





        //[MenuItem("Assets/RAYEDPS/Crear/Dado/Especial")]
        //public static void CrearDadoEsp(){

        //    BaseDado<bool> dado = ScriptableObject.CreateInstance<BaseDado<bool>>();
        //    AssetDatabase.CreateAsset(dado, "Assets/Objetos/Dados");
        //    AssetDatabase.SaveAssets();
        //    EditorUtility.FocusProjectWindow();
        //    EditorUtility.FocusProjectWindow();
        //    Selection.activeObject = dado;

        //}
    }
#endif

    }


