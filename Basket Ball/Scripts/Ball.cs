using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject trial;
    // Start is called before the first frame update
    void Start()
    {
        trial.SetActive(false);
    }

    public void Activetrial()
    {
        trial.SetActive(true);
    }
}
