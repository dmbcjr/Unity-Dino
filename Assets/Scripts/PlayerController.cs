using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float playerSpeed = 6f;

    Rigidbody rb;

    [SerializeField] float jumpForce = 1f;

    bool isAlive;
    Vector3 playerStartPos;

    [SerializeField] GameObject restartMenu;
    // Start is called before the first frame update
    void Start()
    {
        playerStartPos = transform.position;
        rb = GetComponent<Rigidbody>();
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (isAlive)
        {

           

            if (Input.GetKeyDown(KeyCode.Space) && transform.position.y == .75f)
            {
                rb.AddForce(transform.up * jumpForce);
                //Debug.Log("yes");
            }
            else
            {
                transform.position += Vector3.right.normalized * Time.deltaTime * playerSpeed;
            }
        }

        playerSpeed += transform.position.x * Time.deltaTime /100;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Time.timeScale = 0;
            isAlive = false;
            restartMenu.SetActive(true);
            
        }
    }

    public void RestartGame()
    {
        restartMenu.SetActive(false);
        transform.position = playerStartPos;
        Time.timeScale = 1;
        isAlive = true;
        playerSpeed = 6f;


    }

    //add 
}
