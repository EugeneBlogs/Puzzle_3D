using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubratprosrachno : MonoBehaviour
{
    public GameObject[] firstGroup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject first in firstGroup)
            {
                first.GetComponent<Collider>().isTrigger = true;
            }
        }
    }
}
