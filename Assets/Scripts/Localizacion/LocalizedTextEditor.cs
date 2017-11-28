using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class LocalizedTextEditor : EditorWindow
{
    public LocalizationData localizationData;

    [MenuItem("Window/Editor de textos")]
    static void Init()
    {
        EditorWindow.GetWindow(typeof(LocalizedTextEditor)).Show();
    }

    private void OnGUI()
    {
        if (localizationData != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("localizationData");
            EditorGUILayout.PropertyField(serializedProperty, true);
            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("Guardar datos"))
            {
                SaveGameData();
            }
        }

        if (GUILayout.Button("Cargar datos"))
        {
            LoadGameData();
        }

        if (GUILayout.Button("Crear datos"))
        {
            CreateNewData();
        }
    }

    private void LoadGameData()
    {
        string filePath = EditorUtility.OpenFilePanel("Seleccionar fichero de traduccion", Application.streamingAssetsPath, "json");

        if (!string.IsNullOrEmpty(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);

            localizationData = JsonUtility.FromJson<LocalizationData>(dataAsJson);
        }
    }

    private void SaveGameData()
    {
        string filePath = EditorUtility.SaveFilePanel("Guardar fichero de traduccion", Application.streamingAssetsPath, "", "json");

        if (!string.IsNullOrEmpty(filePath))
        {
            string dataAsJson = JsonUtility.ToJson(localizationData);
            File.WriteAllText(filePath, dataAsJson);
        }
    }

    private void CreateNewData()
    {
        localizationData = new LocalizationData();
    }

}