using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;

    public int rotateSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collied" + other.name);
        Destroy(gameObject);
        score++;
    }
}
