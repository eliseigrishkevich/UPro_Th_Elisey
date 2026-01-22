using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class macbook : EditorWindow
{

    [MenuItem("Localize/Open Window")]

    public static void ShowWindow()
    {
        GetWindow(typeof(macbook), true, "Смешарики");

        CSVReader.LoadCSV();
    }
}
