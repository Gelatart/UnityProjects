using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Original template taken from Unity Roll-A-Ball Tutorial: https://learn.unity.com/tutorial/environment-and-player?projectId=5c51479fedbc2a001fd5bb9f
public class PlayerController : MonoBehaviour {

    public float speed;
    public Vector3 startingPosition;
    public Text statusText;

    private Rigidbody rb;
    public Transform focus;
    private CharacterController controller;
    public MoveBase CharacterMover;

    public GameObject altCamera;
    
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        statusText.text = "";
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
        CharacterMover.Move(controller);
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Portal")
            gameObject.transform.position = startingPosition;
        //Teleport inspiration: https://answers.unity.com/questions/1266525/how-to-create-a-portalteleport.html
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
        } else if (other.gameObject.CompareTag ("Bottom"))
        {
            altCamera = GameObject.FindWithTag("Alt-Camera");
            altCamera.SetActive (true);
            statusText.text = "Changing camera";
            //Figure out why this isn't triggering, so I can trigger camera changes
        }

        statusText.text = "Acquired " + other.gameObject.name;
    }
    //Inspired by: https://learn.unity.com/tutorial/collecting-scoring-and-building-the-game?projectId=5c51479fedbc2a001fd5bb9f#5c7f8529edbc2a002053b789
}
//Text on screen inspired by: https://learn.unity.com/tutorial/collecting-scoring-and-building-the-game?projectId=5c51479fedbc2a001fd5bb9f#5c7f8529edbc2a002053b78b