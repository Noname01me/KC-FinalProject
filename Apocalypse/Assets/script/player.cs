
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D _ridgidbody;
    private Vector2 _input;

    public float Speed;
    public GameObject BulletPrefab;
    public Transform GunPoint;

    void Start()
    {
        _ridgidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.up = (mouceUtis.GetMoucePosition2d() - (Vector2)transform.position).normalized;

        _ridgidbody.velocity = _input.normalized * Speed;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    private void Shoot()
    {
        Instantiate(BulletPrefab, GunPoint.position, transform.rotation);

    }


    public void Die()
    {
        Destroy(gameObject);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var enemy = other.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            Die();

        }
    }
}