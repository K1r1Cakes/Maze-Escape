using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructionscontroller : MonoBehaviour
{
   public void OnContinueClick()
    {
        SceneManager.LoadScene("Main");
    }
}
