using UnityEditor;

namespace Editor
{
    public static class ExportUnityPackage
    {
        [MenuItem("Unity-Notion/Export Unity Package")]
        private static void ExportPackage()
        {
            AssetDatabase.ExportPackage(
                new string[]
                {
                    "Assets/Notion-Unity",
                },
                "Notion-Unity.unitypackage",
                ExportPackageOptions.Recurse |
                ExportPackageOptions.IncludeDependencies
            );
        }
    }
}