using UnityEngine;
using System.Collections;

//Original template taken from Unity Roll-A-Ball Tutorial: https://learn.unity.com/tutorial/environment-and-player?projectId=5c51479fedbc2a001fd5bb9f
public class PlayerController : MonoBehaviour {

    public float speed;
    public Vector3 startingPosition;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Portal")
            gameObject.transform.position = startingPosition;
        //Teleport inspiration: https://answers.unity.com/questions/1266525/how-to-create-a-portalteleport.html
    }
}