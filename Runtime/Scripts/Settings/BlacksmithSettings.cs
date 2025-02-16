using UnityEditor;
using UnityEngine;

namespace Fsi.Roguelite.Settings
{
    public class BlacksmithSettings : ScriptableObject
    {
        private const string RESOURCE_PATH = "Settings/BlacksmithSettings";
        private const string FULL_PATH = "Assets/Resources/" + RESOURCE_PATH + ".asset";

        private static BlacksmithSettings _settings;
        public static BlacksmithSettings Settings => _settings ??= GetOrCreateSettings();
        
        public static BlacksmithSettings GetOrCreateSettings()
        {
            BlacksmithSettings settings = Resources.Load<BlacksmithSettings>(RESOURCE_PATH);

            #if UNITY_EDITOR
            if (!settings)
            {
                if (!AssetDatabase.IsValidFolder("Assets/Resources"))
                {
                    AssetDatabase.CreateFolder("Assets", "Resources");
                }

                if (!AssetDatabase.IsValidFolder("Assets/Resources/Settings"))
                {
                    AssetDatabase.CreateFolder("Assets/Resources", "Settings");
                }

                settings = CreateInstance<BlacksmithSettings>();
                AssetDatabase.CreateAsset(settings, FULL_PATH);
                AssetDatabase.SaveAssets();
            }
            #endif

            return settings;
        }

        #if UNITY_EDITOR
        public static SerializedObject GetSerializedSettings()
        {
            return new SerializedObject(GetOrCreateSettings());
        }
        #endif
    }
}