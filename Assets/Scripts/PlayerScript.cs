using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletShooter;
    public int Health = 3;
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
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bulletPrefab, bulletShooter.transform.position, Quaternion.identity);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bulletPrefab, bulletShooter.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            Health -= 1;
        }
    }
}
