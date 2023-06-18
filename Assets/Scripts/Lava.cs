using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lava : MonoBehaviour
{
    public Image hpShow;

    private void Start()
    {
        hpShow = GetComponent<Image>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        float a = hpShow.color.a;
        a += 0.1f;
        hpShow.color = new Color(0, 0, 0, a);

    }
}
