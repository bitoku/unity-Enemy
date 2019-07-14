using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneC : MonoBehaviour
{
    [SerializeField] GameObject LeftBar2;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = LeftBar2.GetComponent<Rigidbody2D>();
    }

    void OnMouseDrag()
    {
        rb2D.angularVelocity = 2880.0f;
    }
}
