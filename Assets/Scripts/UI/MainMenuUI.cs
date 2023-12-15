using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;

    // Method to handle UI button click to show settings panel
    public void ShowSettingsPanel()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    // Method to handle UI button click to go back to main menu panel
    public void ShowMainMenuPanel()
    {
        settingsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // Other methods for main menu UI interactions
}
