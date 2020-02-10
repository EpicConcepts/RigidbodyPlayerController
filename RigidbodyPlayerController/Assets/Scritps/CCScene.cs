using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CCScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene("Rigibody");
        }
    }
}
