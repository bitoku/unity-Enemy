using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneD : MonoBehaviour
{
    [SerializeField] GameObject RightBar2;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = RightBar2.GetComponent<Rigidbody2D>();
    }

    void OnMouseDrag()
    {
        rb2D.angularVelocity = -2880.0f;
    }
}
