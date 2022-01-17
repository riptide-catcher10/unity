using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public float objectSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 mousemovement;

    Vector2 transposNow;


    void OnMouseDrag()
    {
        mousemovement = new Vector2(Input.mousePosition.x * Time.fixedDeltaTime, Input.mousePosition.y * Time.fixedDeltaTime);
        Vector2 mousePos = Vector2.MoveTowards(transform.position, mousemovement, objectSpeed * Time.fixedDeltaTime);
        rb.MovePosition(mousePos);
    }



    void OnMouseExit()
    {
        transposNow = new Vector2(transform.position.x, transform.position.y);
        transform.position = transposNow;
        Vector2 rbposNow = new Vector2(rb.position.x,rb.position.y);
        rb.position = rbposNow;
    }

    
}
