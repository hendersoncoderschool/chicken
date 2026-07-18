using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(PushBall());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator PushBall()
    {
        while (true)
        {
            rb.AddForce(Vector2.right * 100000f);
            yield return new WaitForSeconds(1f);
            rb.AddForce(Vector2.right * -100000f);
            yield return new WaitForSeconds(1f);
        }
    }
}
