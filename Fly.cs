using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private GameObject dot;
    [SerializeField] 
    private float speed = 0.5f;
    public bool myGo = false;
    
    void Start()
    {

    }
    /*private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }*/
    public void OnMouseDown()
    {
        if(!myGo)
        {
            myGo = true;
        }
    }
    public void TakePoint()
    {
      if (Input.GetMouseButtonDown(0))
      {
        this.transform.position = Vector3.MoveTowards(transform.position, dot.transform.position, speed * Time.deltaTime);
      }
    }
    /*private void OnMouseDown()
    {
        rb.velocity = new Vector2(2f, 90f);
        //transfom.position = Vector2.MoveTowards(transform.position, dot.transform.position, speed * Time.deltaTime);
    }*/
    void Update()
    {
        if(myGo)
        {
            TakePoint();
        }
        //transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("bombed").transform.position, speed* Time.deltaTime);
        //transfom.position = Vector2.MoveTowards(transform.position, gameObject.FindGameObjectWithTag("bombed").transform.position, speed * Time.deltaTime);
    }
    //transform.position = Vector3.MoveTowards(transform.position, meteor.transform.position, speed* Time.deltaTime);
}
