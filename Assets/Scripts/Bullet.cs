
using UnityEditor.Timeline;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Vector3 direction;
    private Rigidbody2D rb;
    public void Init(Vector3 dir)
    {
        direction = dir;
    }
    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();    
    }
    void Update()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        rb.velocity = direction * speed;
    }

    public GameObject destroyEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("enemy"))
        {
            //kill enemy
            if(collision.TryGetComponent<Enemy>(out Enemy e))
            {
                e.Die();
            }
        }
        Instantiate(destroyEffect,transform.position,Quaternion.identity);

        ObjectPool.Instance.ReturnObject(gameObject);
    }

}

