using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public string keyObjectName = "key";

    public void PickUpKey()
    {
        GameObject key = GameObject.Find(keyObjectName);

        if (key != null)
        {
            key.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Key GameObject not found.");
        }
    }
}
