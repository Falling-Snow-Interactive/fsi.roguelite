using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Fsi.Roguelite.Settings
{
    public class BlacksmithSettingsProvider : SettingsProvider
    {
        private const string SETTINGS_PATH = "Fsi/Blacksmith";
        
        private SerializedObject serializedSettings;

        private BlacksmithSettingsProvider(string path, SettingsScope scopes, IEnumerable<string> keywords = null) 
            : base(path, scopes, keywords)
        {
        }
        
        [SettingsProvider]
        public static SettingsProvider CreateMyCustomSettingsProvider()
        {
            return new BlacksmithSettingsProvider(SETTINGS_PATH, SettingsScope.Project);
        }
        
        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            serializedSettings = BlacksmithSettings.GetSerializedSettings();
        }
        
        public override void OnGUI(string searchContext)
        {
            // EditorGUILayout.PropertyField(serializedSettings.FindProperty("prop"));
            
            EditorGUILayout.Space(20);
            if (GUILayout.Button("Save"))
            {
                serializedSettings.ApplyModifiedProperties();
            }
            
            serializedSettings.ApplyModifiedProperties();
        }
    }
}