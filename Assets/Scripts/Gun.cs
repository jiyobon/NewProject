using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject rocket;
    public float speed=20f;
    PlayerMoving playerMoving;
Animator anim;
    // Start is called before the first frame update
    void Start()
    {
anim = transform.root.gameObject.GetComponent<Animator>();
        playerMoving = transform.root.GetComponent<PlayerMoving>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(playerMoving.bFaceRight)
            {
                GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(0, 0, 0)) ;
                Rigidbody2D bi= bulletInstance.GetComponent<Rigidbody2D>();
                bi.velocity = new Vector2(speed, 0);
            }
            else
            {
                GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(0, 0, 180));
                Rigidbody2D bi = bulletInstance.GetComponent<Rigidbody2D>();
                bi.velocity = new Vector2(-speed, 0);
                //Rigidbody2D bi = bulletInstance as Rigidbody2D;
            }
        }
        
    }
}
