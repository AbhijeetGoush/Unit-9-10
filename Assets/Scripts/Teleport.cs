using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform playerTrans;
    private Vector2 destination;

    private bool cooldown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Teleport button")
                {
                    if(cooldown == false)
                    {
                        destination = new Vector2(Random.Range(-10, 10), Random.Range(-4, 4));
                        playerTrans.position = new Vector2(destination.x, destination.y);
                        Invoke("ResetCooldown", 1.0f);
                        cooldown = true;
                    }
                }

            }
        }
    }
    void ResetCooldown()
    {
        cooldown = false;
    }
}
