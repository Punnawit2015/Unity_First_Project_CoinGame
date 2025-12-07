using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planedestroy : MonoBehaviour
{
    [SerializeField] public Transform Player;
    [SerializeField] public Transform RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = RespawnPoint.transform.position;
    }
}