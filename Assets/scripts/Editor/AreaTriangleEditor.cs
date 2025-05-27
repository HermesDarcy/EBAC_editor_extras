using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using static UnityEngine.GraphicsBuffer;
using Packages.Rider.Editor.ProjectGeneration;
using Unity.VisualScripting.ReorderableList.Internal;



[CustomEditor(typeof(AreaTriangulo))]
public class AreaTriangleEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        AreaTriangulo mytarget = (AreaTriangulo)target;
        
        mytarget.objt = (GameObject)EditorGUILayout.ObjectField("Prefab", mytarget.objt, typeof(GameObject), true);

        EditorGUI.BeginChangeCheck();
        mytarget.colorido = (AreaTriangulo.cores)EditorGUILayout.EnumPopup("Cor",mytarget.colorido);
        mytarget.colorMe = EditorGUILayout.ColorField("Color",mytarget.howColor());

        
        EditorGUILayout.LabelField("base x Altura",mytarget.multiAB.ToString());
        EditorGUILayout.LabelField("limites", mytarget.myLimit.ToString());
        EditorGUILayout.LabelField("Nova cor",mytarget.mycolor.ToString());
        //EditorGUILayout.ColorField("Color", mytarget.colorMe);

       
       
        mytarget.b1 = EditorGUILayout.FloatField("Base do trinagulo", mytarget.b1);
        mytarget.h1 = EditorGUILayout.FloatField("Altura do trinagulo", mytarget.h1);
        EditorGUILayout.HelpBox("Cálculo da área", MessageType.Info);
        EditorGUILayout.LabelField("Area do trinagulo", mytarget.AreaTriangle().ToString());
        if (mytarget.b1 == 0 || mytarget.h1 == 0)
        {
            EditorGUILayout.HelpBox("não pode haver valor zero", MessageType.Warning);
        }
        if (mytarget.b1 < 0 || mytarget.h1 < 0)
        {
            EditorGUILayout.HelpBox("não pode haver valor menor que zero", MessageType.Error);
        }

        //GUI.color = Color.yellow;
        GUI.color = mytarget.howColor();
        
        if(GUILayout.Button("criar Objeto"))
        {
            mytarget.create();
            mytarget.changeUmaCor();
        }

        GUI.color = PlayUtils.ColorString(mytarget.umaCor);
        EditorGUILayout.LabelField(" Nova Cor Randomizada", mytarget.umaCor);


        // Desenha o restante do Inspector padrão (outras variáveis serializadas)
        //DrawDefaultInspector();


    }
    



}
