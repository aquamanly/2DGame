
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PCMove : MonoBehaviour
{

    public float speed = .2f;
    public float jumpVelocity = 750.0f;
    public bool jumped;
    public Rigidbody2D PCRB;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        
        jumped = false;
        PCRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        /* if(Input.GetKey(KeyCode.W)){
			transform.position += transform.forward * speed;
		} 
		if(Input.GetKey(KeyCode.S)){
			transform.position -= transform.forward * (speed*.8f);
		}
		Commands left in for the possibility of repurposing. In its current state, it would just walk the character off the stage inward and outward. Or could jump, if you prefer.*/
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * (speed);
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (speed);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetButtonDown("Jump") && jumped == false)
        {
            //transform.position += transform.up * (speed*.9f);
            anim.SetTrigger("Jump");
            PCRB.AddForce(new Vector2(0, jumpVelocity));
            Debug.Log("Yes this is jumping.");
            jumped = true;
            Debug.Log(jumped);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            jumped = false;
            anim.SetTrigger("Land");
        }
        if (coll.gameObject.tag == "EndLvlFloor")
        {
            Debug.Log("start new level");
            anim.SetTrigger("Land");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            transform.parent = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            transform.parent = null;
        }
    }



}