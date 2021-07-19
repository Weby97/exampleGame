using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject bullet;
    public bool canShoot;
    public float timeUntilNextShot;
    public float timeBetweenShots = 1f;
    public PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pm.isDead)
        {
            if (Time.time > timeUntilNextShot)
            {
                canShoot = true;
            }
            if (Input.GetMouseButtonDown(0) && canShoot)
            {
                canShoot = false;
                timeUntilNextShot = Time.time + timeBetweenShots;
                Instantiate(bullet, this.transform.position, this.transform.rotation);
            }
        }
    }
}
