using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.iOS;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootButton : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletShooter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            
            if(hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Shoot button")
                {
                    Instantiate(bulletPrefab, bulletShooter.transform.position, Quaternion.identity);
                }
                
            }
        }
    }
    

}
