using UnityEngine;

public class PauseController : MonoBehaviour
{
    public static bool isGamePaused { get; private set; } = false;
    public static void setPause(bool pause)
    {
        isGamePaused = pause;
    }

}
