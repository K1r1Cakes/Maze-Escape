using UnityEngine;
using UnityEngine.AI;

public class New_Enemy : MonoBehaviour
{
   public Transform target;
   private NavMeshAgent agent;
    public GameObject panel;
    public GameObject loseText;

    public float speedRate = 0.1f;
    public float startSpeed = 2f;

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
           if (PauseController.isGamePaused)
         {
            agent.speed = 0;
            return;
        }

        agent.SetDestination(target.position);
         
        agent.speed = startSpeed + Time.timeSinceLevelLoad*speedRate;

    }

    // void FixedUpdate()
    // {
    //      if (PauseController.isGamePaused)
    //     {
    //         agent.speed = 0;
    //         return;
    //     }

    //      agent.speed += speedRate*Time.deltaTime;

    // }

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


