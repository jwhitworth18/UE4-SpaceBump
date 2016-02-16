using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveForce = 5;
    public float boostMulti = 2;
    Rigidbody2D myBody;

	void Start ()
    {
        myBody = this.GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        Vector2 moveVec = new Vector2();
	}
}
