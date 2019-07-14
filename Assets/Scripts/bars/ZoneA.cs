using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneA : MonoBehaviour
{
    [SerializeField] GameObject LeftBar1;
    public Rigidbody2D rb2D;
    private float angleA;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = LeftBar1.GetComponent<Rigidbody2D>();
        angleA = LeftBar1.transform.rotation.eulerAngles.z;
        //Quaternion quaternion = LeftBar1.transform.rotation;
    }

    void OnMouseDrag()
    {
        rb2D.angularVelocity = 2880.0f;
    }

    /*void OnMouseExit()
    {
    }*/
    // Update is called once per frame
    /*void Update()
    {
        quaternion.eulerAngles.z = angleA;
    }*/

    /*void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            rb2D.AddTorque(LeftBar1.transform.up.z * torque, ForceMode2D.Impulse);
            Debug.Log("angleA = " );

        }
        if (Input.GetMouseButtonUp(1))
        {
            rb2D.AddTorque(-LeftBar1.transform.up.z * torque, ForceMode2D.Impulse);
        }
    }*/

    /*void OnMouseDown()
    {
            rb2D.AddTorque(LeftBar1.transform.up.z * torque, ForceMode2D.Impulse);
        }
        */


}
