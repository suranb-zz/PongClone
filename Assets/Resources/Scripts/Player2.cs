using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float movementSpeed;
    //float pointer_y = Input.GetAxis("Mouse Y");

    private void FixedUpdate()
    {

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
           */

            //transform.Translate(0, pointer_y, 0 * movementSpeed);

            //transform.position = touchPosition;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, touchPosition.y * movementSpeed);
        }
    }
}
