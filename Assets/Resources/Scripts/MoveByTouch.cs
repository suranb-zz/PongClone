using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
    public float movementSpeed;

    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            touchPosition.x = 557f;

            //transform.position = touchPosition;

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, touchPosition.y);

            /*
            if (touchPosition.y >= 269f)
            {
                touchPosition.y = 269f;
            }
            else if (touchPosition.y <= -269f)
            {
                touchPosition.y = -269f;
            }
            */

        }
    }
}
