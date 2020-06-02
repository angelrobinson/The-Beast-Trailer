using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKitty : MonoBehaviour {

    public Transform startMarker;
    public Transform endMarker;
    public float speed = 0.5F;
    private float startTime;
    private float journeyLength;
    void Start()
    {
        if (startMarker == null)
        {
            startMarker = GameObject.Find("Stop6").transform;
            endMarker = GameObject.Find("Stop7").transform;
        }
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
    }
}
