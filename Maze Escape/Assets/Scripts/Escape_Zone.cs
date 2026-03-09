using UnityEngine;
using UnityEngine.UIElements;

public class Escape_Zone : MonoBehaviour
{
    public GameObject panel;
    public GameObject winText;
    public Unlock_Gate unlock;

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player") && unlock.isCollected)
        {
            Debug.Log("Player Escaped!");
            panel.SetActive(true);
            winText.SetActive(true);
        }
        else
        {
            Debug.Log("Need a key");
        }
    }

    void Update()
    {
        if (panel.activeSelf)
        {
            PauseController.setPause(true);
        }
    } 
}
