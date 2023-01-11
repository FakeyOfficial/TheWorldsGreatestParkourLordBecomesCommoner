using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
	private Vector3 initialPosition;
	void Awake()
{
	initialPosition = transform.position;
}
    void Update()
    {
        moveUpAndDown();
    }
    void moveUpAndDown()
    {
        transform.position = new Vector3(transform.position.x, initialPosition.y + Mathf.PingPong(Time.time, 1), transform.position.z);
    }
}
