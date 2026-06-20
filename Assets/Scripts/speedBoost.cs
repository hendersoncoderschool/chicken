using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    public float strength;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.name == "Body")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(collision.gameObject.transform.right * strength, ForceMode2D.Impulse);
            print(collision.gameObject.transform.right * strength);
            print(collision.gameObject.name);

        }
    }
}
