using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float moveSpeed;

    public GameObject dieEffect;
    public SpriteRenderer spriteRenderer;
    public void Die()
    {
        //
        Instantiate(dieEffect,transform.position, Quaternion.identity);
        Instantiate(gameObject,transform.position +(Vector3) Random.insideUnitCircle*Random.Range(3f,7f),Quaternion.identity);
        //update GameManager
        Destroy(gameObject);
    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        transform.localScale = Vector3.one * Random.Range(.75f, 2.2f);
        //GetComponent<SpriteRenderer>().color=
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
   

}
