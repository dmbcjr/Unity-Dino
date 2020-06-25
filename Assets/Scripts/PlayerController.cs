using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float playerSpeed = 6f;
    Rigidbody rb;
    [SerializeField] float jumpForce = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y == .75f)
        {
            rb.AddForce(transform.up * jumpForce);
            //Debug.Log("yes");
        }

        transform.position += Vector3.right.normalized * Time.deltaTime * playerSpeed;

    }
    
    //add 
}
