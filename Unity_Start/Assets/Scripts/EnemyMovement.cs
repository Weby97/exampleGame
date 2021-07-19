using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Vector3 moveVector = new Vector3(1, 0, 0);
    public int speed = 5;
    bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Vector3 rot = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
        if (transform.position.x <= -3 && facingRight == false)
        {
            // Spin 180 degrees around the y axis
            transform.rotation = Quaternion.Euler(rot);
            facingRight = true;
        }
        if (transform.position.x >= 3 && facingRight == true)
        {
            // Spin 180 degrees around the y axis
            transform.rotation = Quaternion.Euler(rot);
            facingRight = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}
