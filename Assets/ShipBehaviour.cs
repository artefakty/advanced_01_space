using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehaviour : MonoBehaviour
{
    public float Speed = 1.0f;
    public float TurnSpeed = 35.0f;
    public GameObject Blaster;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(0.0f, 0.0f, Speed * Time.deltaTime);
		
        if(Input.GetKey(KeyCode.UpArrow))
            this.transform.Rotate(TurnSpeed * Time.deltaTime, 0.0f, 0.0f);
        if(Input.GetKey(KeyCode.DownArrow))
            this.transform.Rotate(-TurnSpeed * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Rotate(0.0f, TurnSpeed * Time.deltaTime, 0.0f);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Rotate(0.0f, -TurnSpeed * Time.deltaTime, 0.0f);

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        GameObject.Instantiate(Blaster,
                this.transform.position,
                this.transform.rotation);
	    }
    }
}
