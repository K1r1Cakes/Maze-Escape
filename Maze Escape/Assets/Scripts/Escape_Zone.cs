using UnityEngine;

public class Escape_Zone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player"))
        {
            Debug.Log("Player Escaped!");
        }
    }
}
