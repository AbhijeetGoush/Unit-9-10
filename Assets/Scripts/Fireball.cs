using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    Joystick joystickScr;
    public GameObject fireballPrefab;
    public Transform fireballTrans;
    public GameObject cameraObj;
    Rigidbody2D fireballRb;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = GameObject.FindWithTag("MainCamera");
        joystickScr = cameraObj.GetComponent<Joystick>();
        fireballRb = GetComponent<Rigidbody2D>();
        float angle = Mathf.Atan2(joystickScr.directionV.y, joystickScr.directionV.x) * Mathf.Rad2Deg + 90;
        fireballPrefab.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        fireballRb.AddForce(-transform.up * 17);
        if (fireballTrans.position.x >= 10.788f)
        {
            Destroy(this.gameObject);
        }
        if (fireballTrans.position.x <= -10.788)
        {
            Destroy(this.gameObject);
        }
        if (fireballTrans.position.y >= 6.4f)
        {
            Destroy(this.gameObject);
        }
        if (fireballTrans.position.y <= -6.4f)
        {
            Destroy(this.gameObject);
        }
    }
}
