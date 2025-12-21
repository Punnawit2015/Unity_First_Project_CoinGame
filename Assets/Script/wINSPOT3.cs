using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wINSPOT3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Win");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
