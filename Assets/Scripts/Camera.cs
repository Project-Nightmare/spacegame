using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Vector2 offset;
    Player player;

    // Use this for initialization
    void Start()
    {
        player = (Player)FindObjectOfType(typeof(Player));
        offset = transform.position - player.transform.position;
    }

    private void FixedUpdate()
    {

    }

    private void Update()
    {

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), 1 * Time.deltaTime);

        //transform.position += this.transform.forward * Time.deltaTime;
    }

    void LateUpdate()
    {
        float smoothTime = 0.3f;
        Vector3 velocity = Vector3.zero;

        Vector3 goalPos = player.transform.position;
        goalPos = player.transform.position;
        goalPos.z = -2;
        this.transform.position = Vector3.SmoothDamp(this.transform.position, goalPos, ref velocity, smoothTime);
    }
}