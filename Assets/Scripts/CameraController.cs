using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    public float smoothness;
    public float minX, maxX, minY, maxY;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void LateUpdate()
    {
        float playerX = Mathf.Clamp(target.position.x, minX, maxX);
        float playerY = Mathf.Clamp(target.position.y, minY, maxY);

        transform.position = Vector3.Lerp(transform.position,
            new Vector3(playerX, playerY, transform.position.z),
            smoothness * Time.deltaTime);
    }
}
