using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D pacManRigidBody;
    private Animator pacManAnimator;

	// Use this for initialization
	void Start ()
    {
        pacManRigidBody = GetComponent<Rigidbody2D>();
        pacManAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayProperAnimation();
	}

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        pacManRigidBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }

    private void PlayProperAnimation()
    {
        if (IsGoingRight())
        {
            pacManAnimator.Play("PacManRight");
        }
        else if (IsGoingLeft())
        {
            pacManAnimator.Play("PacManLeft");
        }
        else if (IsGoingUp())
        {
            pacManAnimator.Play("PacManUp");
        }
        else if (IsGoingDown())
        {
            pacManAnimator.Play("PacManDown");
        }
    }

    private bool IsGoingRight()
    {
        return Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
    }

    private bool IsGoingLeft()
    {
        return Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
    }

    private bool IsGoingUp()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
    }

    private bool IsGoingDown()
    {
        return Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
    }
}
