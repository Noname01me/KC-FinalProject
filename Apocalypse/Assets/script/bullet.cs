
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    public float Speed;

    

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 4f);
        
    }

  
    void Update()
    {
        _rigidbody.velocity = (transform.up * Speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var enemy = other.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Die();
            

        }

        Destroy(gameObject);
        
    }

}
