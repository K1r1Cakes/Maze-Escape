using UnityEngine;

public class UI : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif 
    }
}
