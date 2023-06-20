using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
    using UnityEngine;
    using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    private Transform target;
    public float smoothness;
    public float minX, maxX, minY, maxY;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }
    private void Update()
    {
        float targetX = target.position.x;
        float targetY = target.position.y;
        float camX = transform.position.x;
        float camY = transform.position.y;
        float distance = Mathf.Sqrt(Mathf.Pow((targetX - camX), 2) + Mathf.Pow((targetY - camY), 2));
        if (distance >= 5f)     //카메라와 플레이어의 거리가 5 이상일 때 텔포
        {
            transform.position = new Vector3(targetX, targetY, transform.position.z);
        }
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
