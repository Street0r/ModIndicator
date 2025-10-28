using BepInEx;
using HarmonyLib;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace SFKMods
{
    [BepInPlugin("com.sfkmoddingteam.modindicator", "SFK Mod Indicator", "1.0.0")]
    public class ModIndicator : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("SFK Mod Indicator loaded!");
            
            // Subscribe to scene loaded event
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Logger.LogInfo($"Scene loaded: {scene.name} (buildIndex: {scene.buildIndex})");
            
            // Only show on title screen
            if (scene.name == "TitleScene")
            {
                CreateModIndicator();
            }
        }

        private void CreateModIndicator()
        {
            // Find the "Super Fantasy Games" text to position our indicator above it
            var allTexts = Resources.FindObjectsOfTypeAll<TextMeshProUGUI>();
            TextMeshProUGUI versionText = null;
            
            foreach (var tmpText in allTexts)
            {
                if (tmpText.text != null && tmpText.text.Contains("Super Fantasy Games"))
                {
                    versionText = tmpText;
                    Logger.LogInfo($"Found version text: {tmpText.text}");
                    break;
                }
            }

            if (versionText == null)
            {
                Logger.LogWarning("Could not find Super Fantasy Games text!");
                return;
            }

            // Create our mod indicator text as a sibling to the version text
            GameObject textObj = new GameObject("ModIndicatorText");
            textObj.transform.SetParent(versionText.transform.parent);
            
            var text = textObj.AddComponent<TextMeshProUGUI>();
            text.text = "Mods Loaded";
            text.font = versionText.font;
            text.fontSize = versionText.fontSize;
            text.alignment = versionText.alignment;
            text.color = new Color(0, 1, 0, 1); // Green color
            
            var rectTransform = textObj.GetComponent<RectTransform>();
            var versionRect = versionText.GetComponent<RectTransform>();
            
            // Copy the version text's rect transform properties
            rectTransform.anchorMin = versionRect.anchorMin;
            rectTransform.anchorMax = versionRect.anchorMax;
            rectTransform.pivot = versionRect.pivot;
            rectTransform.sizeDelta = versionRect.sizeDelta;
            
            // Position above the version text (add offset to Y position)
            rectTransform.anchoredPosition = versionRect.anchoredPosition + new Vector2(0, versionRect.sizeDelta.y + 5);

            Logger.LogInfo("Mod indicator created above version text!");
        }
    }
}