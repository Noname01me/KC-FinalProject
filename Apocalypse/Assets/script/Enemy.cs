
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D _ridgidbody;
    private player _player;
    private float _speed;

    public float BaseSpeed;

    void Start()
    {
        _ridgidbody = GetComponent<Rigidbody2D>();
        _speed = BaseSpeed * (1 + Random.Range(-0.1f, 0.1f));
        _player = FindObjectOfType<player>();
    }

    
    void Update()
    {
        if (_player != null)
        {
            transform.up = (_player.transform.position - transform.position).normalized;
            _ridgidbody.velocity = transform.up * _speed;
        }
    }


    public void Die()
    {
        Destroy(gameObject);
    }


}
