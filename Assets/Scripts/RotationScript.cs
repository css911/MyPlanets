using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class RotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    public  Vector3 Rotation;

    private void Update()
    {
        PlanetObject.transform.Rotate(Rotation* Time.deltaTime);
    }
}
