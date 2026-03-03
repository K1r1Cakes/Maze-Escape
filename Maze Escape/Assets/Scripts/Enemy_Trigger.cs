using UnityEngine;

public class Enemy_Trigger : MonoBehaviour
{

    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TriggerOnEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player"))
        {
            Debug.Log("Enemy will spawn");
        }
    }
}
