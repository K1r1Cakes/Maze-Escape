using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuControll : MonoBehaviour
{
 public void onStartClick()
    {
        SceneManager.LoadScene("Instruction");
    }

 public void OnExitClick()
    {
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif 
    }
}
