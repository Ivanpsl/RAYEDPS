using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace RAYEDPS
{

    public class BigItemFactory : EditorWindow
    {

        //public ItemDB iItemList;
        //private int viewIndex = 1;

        //[MenuItem("RAYEDPS/Item Editor %#e")]
        //static void Init()
        //{
        //    EditorWindow.GetWindow(typeof(ItemDB));
        //}

        //void OnEnable()
        //{
        //    if (EditorPrefs.HasKey("ObjectPath"))
        //    {
        //        string objectPath = EditorPrefs.GetString("ObjectPath");
        //        iItemList = AssetDatabase.LoadAssetAtPath(objectPath, typeof(ItemDB)) as ItemDB;
        //    }

        //}

        //void OnGUI()
        //{
        //    GUILayout.BeginHorizontal();
        //    GUILayout.Label("Inventory Item Editor", EditorStyles.boldLabel);
        //    if (iItemList != null)
        //    {
        //        if (GUILayout.Button("Lista de Items"))
        //        {
        //            EditorUtility.FocusProjectWindow();
        //            Selection.activeObject = iItemList;
        //        }
        //    }
        //    if (GUILayout.Button("Abrir lista de items"))
        //    {
        //        OpenItemList();
        //    }
        //    if (GUILayout.Button("Nueva lista"))
        //    {
        //        EditorUtility.FocusProjectWindow();
        //        Selection.activeObject = iItemList;
        //    }
        //    GUILayout.EndHorizontal();

        //    if (iItemList == null)
        //    {
        //        GUILayout.BeginHorizontal();
        //        GUILayout.Space(10);
        //        if (GUILayout.Button("Crear nueva lista de items", GUILayout.ExpandWidth(false)))
        //        {
        //            CreateNewItemList();
        //        }
        //        if (GUILayout.Button("Abrir lista existente", GUILayout.ExpandWidth(false)))
        //        {
        //            OpenItemList();
        //        }
        //        GUILayout.EndHorizontal();
        //    }

        //    GUILayout.Space(20);

        //    if (iItemList != null)
        //    {
        //        GUILayout.BeginHorizontal();

        //        GUILayout.Space(10);

        //        if (GUILayout.Button("Prev", GUILayout.ExpandWidth(false)))
        //        {
        //            if (viewIndex > 1)
        //                viewIndex--;
        //        }
        //        GUILayout.Space(5);
        //        if (GUILayout.Button("Siguiente", GUILayout.ExpandWidth(false)))
        //        {
        //            if (viewIndex < iItemList.itemList.Count)
        //            {
        //                viewIndex++;
        //            }
        //        }

        //        GUILayout.Space(60);

        //        if (GUILayout.Button("Añadir Item", GUILayout.ExpandWidth(false)))
        //        {
        //            AddItem();
        //        }
        //        if (GUILayout.Button("Eliminar Item", GUILayout.ExpandWidth(false)))
        //        {
        //            DeleteItem(viewIndex - 1);
        //        }

        //        GUILayout.EndHorizontal();
        //        if (iItemList.itemList == null)
        //            Debug.Log("wtf");
        //        if (iItemList.itemList.Count > 0)
        //        {
        //            GUILayout.BeginHorizontal();
        //            viewIndex = Mathf.Clamp(EditorGUILayout.IntField("Current Item", viewIndex, GUILayout.ExpandWidth(false)), 1, iItemList.itemList.Count);
        //            //Mathf.Clamp (viewIndex, 1, inventoryItemList.itemList.Count);
        //            EditorGUILayout.LabelField("of   " + iItemList.itemList.Count.ToString() + "  items", "", GUILayout.ExpandWidth(false));
        //            GUILayout.EndHorizontal();

        //            iItemList.itemList[viewIndex - 1].itemName = EditorGUILayout.TextField("Item Name", iItemList.itemList[viewIndex - 1].itemName as string);
        //            iItemList.itemList[viewIndex - 1].itemIcon = EditorGUILayout.ObjectField("Item Icon", iItemList.itemList[viewIndex - 1].itemIcon, typeof(Texture2D), false) as Texture2D;
        //            iItemList.itemList[viewIndex - 1].itemObject = EditorGUILayout.ObjectField("Item Object", iItemList.itemList[viewIndex - 1].itemObject, typeof(Rigidbody), false) as Rigidbody;

        //            GUILayout.Space(10);

        //            GUILayout.BeginHorizontal();
        //            iItemList.itemList[viewIndex - 1].isUnique = (bool)EditorGUILayout.Toggle("Unique", iItemList.itemList[viewIndex - 1].isUnique, GUILayout.ExpandWidth(false));
        //         //   inventoryItemList.itemList[viewIndex - 1].isIndestructible = (bool)EditorGUILayout.Toggle("Indestructable", inventoryItemList.itemList[viewIndex - 1].isIndestructible, GUILayout.ExpandWidth(false));
        //           // inventoryItemList.itemList[viewIndex - 1].isQuestItem = (bool)EditorGUILayout.Toggle("QuestItem", inventoryItemList.itemList[viewIndex - 1].isQuestItem, GUILayout.ExpandWidth(false));
        //            GUILayout.EndHorizontal();

        //            GUILayout.Space(10);

        //            GUILayout.BeginHorizontal();
        //      //      inventoryItemList.itemList[viewIndex - 1].isStackable = (bool)EditorGUILayout.Toggle("Stackable ", inventoryItemList.itemList[viewIndex - 1].isStackable, GUILayout.ExpandWidth(false));
        //        //    inventoryItemList.itemList[viewIndex - 1].destroyOnUse = (bool)EditorGUILayout.Toggle("Destroy On Use", inventoryItemList.itemList[viewIndex - 1].destroyOnUse, GUILayout.ExpandWidth(false));
        //         //   inventoryItemList.itemList[viewIndex - 1].encumbranceValue = EditorGUILayout.FloatField("Encumberance", inventoryItemList.itemList[viewIndex - 1].encumbranceValue, GUILayout.ExpandWidth(false));
        //            GUILayout.EndHorizontal();

        //            GUILayout.Space(10);

        //        }
        //        else
        //        {
        //            GUILayout.Label("This Inventory List is Empty.");
        //        }
        //    }
        //    if (GUI.changed)
        //    {
        //        EditorUtility.SetDirty(iItemList);
        //    }
        //}

        //void CreateNewItemList()
        //{
        //    // There is no overwrite protection here!
        //    // There is No "Are you sure you want to overwrite your existing object?" if it exists.
        //    // This should probably get a string from the user to create a new name and pass it ...
        //    viewIndex = 1;
        //    iItemList = ItemDBFactory.Create();
        //    if (iItemList)
        //    {
        //        iItemList.itemList = new List<IItem>();
        //        string relPath = AssetDatabase.GetAssetPath(iItemList);
        //        EditorPrefs.SetString("ObjectPath", relPath);
        //    }
        //}

        //void OpenItemList()
        //{
        //    string absPath = EditorUtility.OpenFilePanel("Select Inventory Item List", "", "");
        //    if (absPath.StartsWith(Application.dataPath))
        //    {
        //        string relPath = absPath.Substring(Application.dataPath.Length - "Assets".Length);
        //        iItemList = AssetDatabase.LoadAssetAtPath(relPath, typeof(ItemDB)) as ItemDB;
        //        if (iItemList.itemList == null)
        //            iItemList.itemList = new List<IItem>();
        //        if (iItemList)
        //        {
        //            EditorPrefs.SetString("ObjectPath", relPath);
        //        }
        //    }
        }
         

        /// ************************************************************
        /// 

        /// <summary>
        ///  QUE TIPO DE ITEMS CREAMOS 
        /// </summary>
    //    void AddItem()
    //    {
           
    //      //  IItem newItem = new IItem();
    //        //newItem.itemName = "New Item";
    //        //inventoryItemList.itemList.Add(newItem);
    //        //viewIndex = inventoryItemList.itemList.Count;
    //    }

    //    void DeleteItem(int index)
    //    {
    //        //inventoryItemList.itemList.RemoveAt(index);
    //    }
    //}
}