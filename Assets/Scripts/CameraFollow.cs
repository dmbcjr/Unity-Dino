using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float smoothFollow = 1f;
    public Vector3 offset;

    Vector3 endPos;

    void Start()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }


    void LateUpdate()
    {
        endPos = new Vector3(player.position.x, transform.position.y, transform.position.z) + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, endPos, smoothFollow);

        transform.position = smoothedPosition;

    }

    void Update()
    {
        if (player.position.x >= 81)
        {
            player.position = new Vector3(player.position.x - 87f, player.position.y, player.position.z);
        }
    }
}
