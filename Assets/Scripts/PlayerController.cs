using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{
    
    
    [SerializeField] WeaponHolder weaponHolder;
    public float speed = 5f;
    private void Update()
    {
        //Input
       
        if(Input.GetMouseButtonDown(0))
        {
            weaponHolder.Shoot(transform.up);

        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.position = (Vector2)transform.position + movement * speed * Time.deltaTime;



        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;

    }




}





