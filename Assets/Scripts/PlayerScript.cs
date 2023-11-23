using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Transform playerTrans;
    // Start is called before the first frame update
    void Start()
    {
        playerTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTrans.position.x >= 10.788f)
        {
            playerTrans.transform.position = new Vector2(-10.683f, playerTrans.position.y);
        }
        if(playerTrans.position.x <= -10.788)
        {
            playerTrans.transform.position = new Vector2(10.683f, playerTrans.position.y);
        }
        if(playerTrans.position.y >= 6.4f)
        {
            playerTrans.transform.position = new Vector2(playerTrans.position.x, -6);
        }
        if (playerTrans.position.y <= -6.4f)
        {
            playerTrans.transform.position = new Vector2(playerTrans.position.x, 6);
        }
    }
}
