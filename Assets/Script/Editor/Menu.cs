using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // [MenuItem("Custom Items/Change camera color")]
    // [MenuItem("Assets/Change camera color")]
    // [MenuItem("GameObject/Camera/Change camera color")]
    [MenuItem("CONTEXT/Camera/Change camera color")]
    public static void ChangeColor()
    {
        var cameras = FindObjectsOfType<Camera>();
        cameras.ToList().ForEach(c => c.backgroundColor = Color.red);
    }
}
