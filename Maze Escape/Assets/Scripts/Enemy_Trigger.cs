using UnityEngine;

public class Enemy_Trigger : MonoBehaviour
{
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player"))
        {
            Debug.Log("Enemy will spawn");
            enemy.SetActive(true);
        }
    }
}
