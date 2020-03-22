using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float force = 5; //public float for force

    Rigidbody2D rb; //variable for the Rigidbody2D

    public static Player_Movement instance; //this static variable will hold the Singleton

    private void Awake()
    {
        if (instance == null) //instance hasn't been set yet
        {
            instance = this; //set instance to this object
            DontDestroyOnLoad(gameObject); //Dont Destroy this object when you load a new scene
        }
        else
        { //if the instance is already set to an object
            Destroy(gameObject); //destroy this new object, so there is only ever one
        }
    }

    // Start is called before the first frame update
    void Start() //setup
    {
        rb = GetComponent<Rigidbody2D>(); //get the Rigidbody2D of this gameObject
    }

    // Update is called once per frame
    void Update() //draw
    {
        if (Input.GetKey(KeyCode.W))//if W is pressed
        {
            rb.AddForce(Vector2.up * force); //apply upwards force
        }

        if (Input.GetKey(KeyCode.S))//if S is pressed
        {
            rb.AddForce(Vector2.down * force); //apply downwards force
        }

        if (Input.GetKey(KeyCode.A))//if A is pressed
        {
            rb.AddForce(Vector2.left * force); //apply force to go left
        }

        if (Input.GetKey(KeyCode.D)) //if D is pressed
        {
            rb.AddForce(Vector2.right * force); //apply force to go right
        }
    }
}
