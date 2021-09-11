using UnityEditor;
using UnityEngine;

/// <summary>
/// All that will be an editor tool has to be in the Editor folder,
/// the folder will not be compiled
/// </summary>
[CustomEditor(typeof(Hero))]
public class HeroEditor : Editor
{
    /// <summary>
    /// Refer to the object instatiated
    /// </summary>
    private Hero _target;
    private SerializedProperty Damage;
    private SerializedProperty HeroClass;
    private SerializedProperty Attack;
    private SerializedProperty ArrowDamage;

    /// <summary>
    /// Called when intialize the property
    /// </summary>
    private void OnEnable()
    {
        _target = (Hero)target;
        Damage = serializedObject.FindProperty("Damage");
        HeroClass = serializedObject.FindProperty("HeroClass");
        Attack = serializedObject.FindProperty("Attack");
        ArrowDamage = serializedObject.FindProperty("ArrowDamage");
    }

    /// <summary>
    /// Called when the user is using the component on Inspector
    /// </summary>
    public override void OnInspectorGUI()
    {
        EditorGUILayout.PropertyField(HeroClass);

        switch (HeroClass.intValue)
        {
            case 0:
                Damage.intValue = EditorGUILayout.IntField("Damage", Damage.intValue);
                if (Damage.intValue == 0)
                    EditorGUILayout.HelpBox("Damage can not be 0", MessageType.Warning);
                break;
            case 1:
                Attack.intValue = EditorGUILayout.IntSlider("Attack", Attack.intValue, 0, 100);
                break;
            case 2:
                ArrowDamage.intValue = EditorGUILayout.IntField("Arrow Damage", ArrowDamage.intValue);
                break;
            default:
                break;
        }

        if (GUILayout.Button("Move hero"))
            _target.Move();
        
        serializedObject.ApplyModifiedProperties();
    }
}
