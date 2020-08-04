using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float movementSpeed;
    //float pointer_y = Input.GetAxis("Mouse Y");

    public Rigidbody2D rb;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {


        rb.velocity = new Vector2(0, Input.acceleration.y * movementSpeed);
        /*
        Vector2 acc = Input.acceleration;
        acc.x = 0.0f;
        rb.AddForce(acc * movementSpeed);
        */


        //Vector3 acc = transform.Translate(0, Input.acceleration.y * movementSpeed * Time.deltaTime, 0);

        //GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(0f, Input.acceleration.y); //transform.Translate(0.0f, Input.acceleration.y * movementSpeed * Time.deltaTime, 0.0f);

        //transform.Translate(0.0f, Input.acceleration.y * movementSpeed * Time.deltaTime, 0.0f);


        /*
                Vector2 movement = new Vector2(Input.acceleration.y, 0.0f);

                GetComponent<Rigidbody2D>().velocity = movement * movementSpeed;

                //GetComponent<Rigidbody2D>().velocity = new Vector2(0, touchPosition.y * movementSpeed);


                if (Input.touchCount > 0)
                {

                    Touch touch = Input.GetTouch(0);
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.x = 557f;
                    touchPosition.z = 0f;



                    /*
                   if (pointer_y >= 267f)
                   {
                       pointer_y = 267f;
                   }
                   else if (pointer_y <= -267f)
                   {
                       pointer_y = -267f;
                   }


                //transform.Translate(0, pointer_y, 0 * movementSpeed);

                //transform.position = touchPosition;



            }
                */

    }
}
