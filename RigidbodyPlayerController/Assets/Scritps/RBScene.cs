using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RBScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene("CharacterController");
        }
    }
}
