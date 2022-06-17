using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float minRotate, maxRotate;
    private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
       rotateSpeed = Random.Range(minRotate, maxRotate);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, rotateSpeed) * Time.deltaTime);
    }
}
