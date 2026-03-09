using UnityEngine;

public class Unlock_Gate : MonoBehaviour
{
    public bool isCollected = false;

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player"))
        {
            isCollected = true;
            gameObject.SetActive(false);
            Debug.Log("Key collected");
        }
    }
}
