using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject Cube;
    public Material changedMat;

    public void ChangeMaterial()
    {
        Cube.GetComponent<MeshRenderer>().material = changedMat;
    }
   
}
