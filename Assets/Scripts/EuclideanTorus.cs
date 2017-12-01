using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EuclideanTorus : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
		if (transform.position.x > 5.3f)
        {
            transform.position = new Vector3(-5.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -5.3f)
        {
            transform.position = new Vector3(5.3f, transform.position.y, 0);
        }
    }
}
