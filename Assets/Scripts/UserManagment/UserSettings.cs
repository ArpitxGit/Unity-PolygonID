using UnityEngine;

public class UserSettings : MonoBehaviour
{
    private bool soundEnabled;
    private int graphicsQuality;

    private void Start()
    {
        LoadSettings(); // Load user settings when the game starts
    }

    public void SetSoundEnabled(bool isEnabled)
    {
        soundEnabled = isEnabled;
        // Save sound settings
        SaveSettings();
    }

    public bool GetSoundEnabled()
    {
        return soundEnabled;
    }

    public void SetGraphicsQuality(int qualityLevel)
    {
        graphicsQuality = qualityLevel;
        // Save graphics settings
        SaveSettings();
    }

    public int GetGraphicsQuality()
    {
        return graphicsQuality;
    }

    private void LoadSettings()
    {
        // Load user settings from PlayerPrefs or other storage
        soundEnabled = PlayerPrefs.GetInt("SoundEnabled", 1) == 1;
        graphicsQuality = PlayerPrefs.GetInt("GraphicsQuality", 2);
    }

    private void SaveSettings()
    {
        // Save user settings to PlayerPrefs or other storage
        PlayerPrefs.SetInt("SoundEnabled", soundEnabled ? 1 : 0);
        PlayerPrefs.SetInt("GraphicsQuality", graphicsQuality);
        PlayerPrefs.Save();
    }

    // Other methods for managing user settings
}
