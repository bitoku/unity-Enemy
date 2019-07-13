using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneB : MonoBehaviour
{
    [SerializeField] GameObject RightBar1;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = RightBar1.GetComponent<Rigidbody2D>();
    }

    void OnMouseDrag()
    {
        Debug.Log("a");
        rb2D.AddTorque(-15f, ForceMode2D.Impulse);
    }
}
