using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class BlasterBehaviour : MonoBehaviour
{
    public float Speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0.0f, 0.0f, Speed * Time.deltaTime);
	}
}
