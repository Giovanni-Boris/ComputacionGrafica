using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCamaraController : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

}
