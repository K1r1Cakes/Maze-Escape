using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
           fireBullet(); 
        }
        
    }

    private void fireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = bulletSpeed * transform.up;
    }
}
