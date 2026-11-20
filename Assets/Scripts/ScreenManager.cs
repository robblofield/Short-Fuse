using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private ScreenBounds currentScreen; // Other scripts can't directly read

    public ScreenBounds CurrentScreen => currentScreen; // how other scripts can read the value

    public void SetCurrentScreen(ScreenBounds newScreen)
    {
        currentScreen = newScreen;
    }
}
