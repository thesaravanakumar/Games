using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectobject;

    private void Start()
    {
        effectobject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball>() != null)
        {
            effectobject.SetActive(true);
        }
    }
}
