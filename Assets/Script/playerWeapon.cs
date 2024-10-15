using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWeapon : MonoBehaviour
{
    public GameObject bullerPrefab;
    public GameObject shooter;
    private Transform shootPoint;

    private void Awake() {
        shootPoint = transform.Find("shootPoint");
    }
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Shoot",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }

    public void Shoot() {
        if (bullerPrefab != null && shootPoint != null && shooter != null) { 
        GameObject bulleCloned = Instantiate (bullerPrefab, shootPoint.position,Quaternion.identity) as GameObject;
            PlayerBullet bulletComponent = bulleCloned.GetComponent<PlayerBullet>();

            if (shooter.transform.localScale.x < 0f)
            {
                bulletComponent.direction = Vector2.left;
            }
            else {
                bulletComponent.direction = Vector2.right;
            }
        }
    }
}
