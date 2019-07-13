using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneA : MonoBehaviour
{
    [SerializeField] GameObject LeftBar1;
    public float torque;
    public Rigidbody2D rb2D;
    private float angleA;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = LeftBar1.GetComponent<Rigidbody2D>();
        angleA = LeftBar1.transform.rotation.eulerAngles.z;
        //Quaternion quaternion = LeftBar1.transform.rotation;
    }

    /*void OnMouseDown()
    {
        for (angleA = 340; angleA <= 375f; angleA += 5f)
        {
            Debug.Log("angleA = " + angleA);
        }
    }

    private void OnMouseExit()
    {
        for (angleA = 375f; 340f <= angleA ; angleA += 5f)
        {
            Debug.Log("angleA = " + angleA);
        }
    }
    // Update is called once per frame
    void Update()
    {
        quaternion.eulerAngles.z = angleA;
    }*/

    void FixedUpdate()
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
    }
}
