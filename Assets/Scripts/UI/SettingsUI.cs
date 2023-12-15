using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    public Toggle soundToggle;
    public Dropdown qualityDropdown;

    public UserSettings userSettings;

    private void Start()
    {
        // Initialize UI elements with user settings
        InitializeSettings();
    }

    private void InitializeSettings()
    {
        soundToggle.isOn = userSettings.GetSoundEnabled();
        qualityDropdown.value = userSettings.GetGraphicsQuality();
    }

    // Method to handle sound toggle change
    public void OnSoundToggleChanged(bool isSoundOn)
    {
        userSettings.SetSoundEnabled(isSoundOn);
    }

    // Method to handle quality dropdown change
    public void OnQualityDropdownChanged(int qualityLevel)
    {
        userSettings.SetGraphicsQuality(qualityLevel);
    }

    // Other methods for settings UI interactions
}
