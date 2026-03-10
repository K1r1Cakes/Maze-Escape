using UnityEngine;

public class Unlock_Gate : MonoBehaviour
{
    public bool isCollected = false;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isCollected == false)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.CompareTag("Player"))
        {
            isCollected = true;
            audioSource.Play();
            Invoke("keyCollected", 0.2f);
            Debug.Log("Key collected");
        }
    }

    void keyCollected()
    {
        gameObject.SetActive(false); 

    }
}
