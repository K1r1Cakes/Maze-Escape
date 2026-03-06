using UnityEngine;
using UnityEngine.AI;

public class New_Enemy : MonoBehaviour
{
   public Transform target;
   private NavMeshAgent agent;
    public GameObject panel;
    public GameObject loseText;
     Rigidbody2D rb;

     private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }

    void FixedUpdate()
    {
         if (PauseController.isGamePaused)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Caught Player");
            panel.SetActive(true);
            loseText.SetActive(true);
        }
    }
}


