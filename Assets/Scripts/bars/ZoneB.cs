using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneB : MonoBehaviour
{
    [SerializeField] GameObject RightBar1;
    private float angleB;

    // Start is called before the first frame update
    void Start()
    {
        angleB = RightBar1.transform.rotation.eulerAngles.z;
    }

    void OnMouseDown()
    {
        Debug.Log("angleB = " + angleB);
    }
}
