using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] private Transform target;

    private void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10.0f) + new Vector3(0,-1.0f,0);
    }
}
