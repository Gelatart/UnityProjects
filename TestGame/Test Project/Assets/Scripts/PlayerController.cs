using UnityEngine;
using System.Collections;

//Original template taken from Unity Roll-A-Ball Tutorial: https://learn.unity.com/tutorial/environment-and-player?projectId=5c51479fedbc2a001fd5bb9f
public class PlayerController : MonoBehaviour {

    public float speed;
    public Vector3 startingPosition;

    private Rigidbody rb;
    public Transform focus;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        /*if(Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * Time.deltaTime * speed;
        } else if(Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * Time.deltaTime * speed;
        } else if(Input.GetKey(KeyCode.D)) {
            transform.position += transform.right * Time.deltaTime * speed;
        } else if(Input.GetKey(KeyCode.A)) {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }*/
        //Inspired by: https://answers.unity.com/questions/616195/how-to-make-an-object-go-the-direction-it-is-facin.html


        rb.AddForce (movement * speed);
        //transform.LookAt(focus);
        //Figure out why it makes the player launch off, how to get movement to be relative to camera rotation
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Portal")
            gameObject.transform.position = startingPosition;
        //Teleport inspiration: https://answers.unity.com/questions/1266525/how-to-create-a-portalteleport.html
    }
}