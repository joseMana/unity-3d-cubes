using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform transformTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = transformTarget.position;
    }
}
