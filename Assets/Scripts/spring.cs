using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public float xForce;
    public float yForce;
    public List<Transform> waypoints;
    private int curentWaypointsIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(xForce, yForce), ForceMode2D.Impulse);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (waypoints.Count == 0) return;

        Transform targetWaypoint = waypoints[curentWaypointsIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, Time.deltaTime * 5f);

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            curentWaypointsIndex = (curentWaypointsIndex + 1) % waypoints.Count;
        }
    }
}
