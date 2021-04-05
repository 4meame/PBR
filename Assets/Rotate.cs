using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    void Update() {
        gameObject.transform.eulerAngles += new Vector3(0, Time.deltaTime * rotateSpeed, 0);
    }
}
