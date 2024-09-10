#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEditor.Build;
using GameAnalyticsSDK.Setup;
using UnityEditor.Build.Reporting;

namespace RimuruDev
{
    public sealed class GameAnalyticsBuildVersionUpdater : IPreprocessBuildWithReport
    {
        private const string SettingsPath = "Assets/Resources/GameAnalytics/Settings.asset";

        public int callbackOrder => 0;

        public void OnPreprocessBuild(BuildReport report) =>
            UpdateBuildVersion();

        private static void UpdateBuildVersion()
        {
            var settings = AssetDatabase.LoadAssetAtPath<Settings>(SettingsPath);

            if (settings != null)
            {
                for (var i = 0; i < settings.Build.Count; i++)
                    settings.Build[i] = Application.version;

                EditorUtility.SetDirty(settings);
                AssetDatabase.SaveAssets();
                
                Debug.Log($"<color=yellow>Build version updated to {Application.version} in GameAnalytics Settings</color>");
            }
            else
            {
                Debug.LogError("Failed to load GameAnalytics Settings asset.");
            }
        }
    }
}
#endif
