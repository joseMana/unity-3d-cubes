using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelButton : MonoBehaviour
{
    [SerializeField]
    KeyCode restartButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(restartButton))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
