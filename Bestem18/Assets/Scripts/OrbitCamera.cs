using UnityEngine;
using System.Collections;

public class OrbitCamera : MonoBehaviour
{

    public float turnSpeed = 4.0f;
    public Transform player;

    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(player.position.x, player.position.y + 3.0f, player.position.z + 1.0f);
    }

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.LookAt(player.position);


        if (Input.GetMouseButton(1))
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        }
    }

}