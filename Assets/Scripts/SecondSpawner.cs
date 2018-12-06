using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;
    public void SecondSpawn()
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }
}
