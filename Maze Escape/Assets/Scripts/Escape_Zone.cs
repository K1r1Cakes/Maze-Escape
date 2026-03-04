using UnityEngine;
using UnityEngine.UIElements;

public class Escape_Zone : MonoBehaviour
{
    public GameObject panel;
    public string[] Win;

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player"))
        {
            Debug.Log("Player Escaped!");
            panel.SetActive(true);
        }
    }
}
