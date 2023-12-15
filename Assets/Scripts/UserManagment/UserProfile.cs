using UnityEngine;

public class UserProfile : MonoBehaviour
{
    private string username;
    private string email;
    private int age;
    // Additional profile information as needed

    public void SetUserProfile(string newUsername, string newEmail, int newAge)
    {
        username = newUsername;
        email = newEmail;
        age = newAge;
        // Set other profile information
    }

    public string GetUsername()
    {
        return username;
    }

    public string GetEmail()
    {
        return email;
    }

    public int GetAge()
    {
        return age;
    }

    // Other methods for managing user profile data
}
