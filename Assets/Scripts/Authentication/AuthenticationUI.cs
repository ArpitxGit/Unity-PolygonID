using UnityEngine;
using UnityEngine.UI;

public class AuthenticationUI : MonoBehaviour
{
    public InputField usernameField;
    public InputField emailField;
    public InputField passwordField;

    public LoginManager loginManager;
    public RegistrationManager registrationManager;

    // Called when Login button is clicked in the UI
    public void OnLoginButtonClicked()
    {
        string username = usernameField.text;
        string password = passwordField.text;

        loginManager.Login(username, password);
    }

    // Called when Register button is clicked in the UI
    public void OnRegisterButtonClicked()
    {
        string username = usernameField.text;
        string email = emailField.text;
        string password = passwordField.text;

        registrationManager.Register(username, email, password);
    }

    // Other UI-related methods
}
