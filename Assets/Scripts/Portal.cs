using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private float timer;
    public GameObject outPortal;

    private void OnTriggerStay2D(Collider2D collision)
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            collision.gameObject.transform.position = outPortal.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        timer = 0f;
    }
}
