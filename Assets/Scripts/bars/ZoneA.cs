using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneA : MonoBehaviour
{
    [SerializeField] GameObject LeftBar1;
    private float angleA;

    // Start is called before the first frame update
    void Start()
    {
        angleA = LeftBar1.transform.rotation.eulerAngles.z;
    }

    void OnMouseDown()
    {
        Debug.Log("angleA = " + angleA);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
