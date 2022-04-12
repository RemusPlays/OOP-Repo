using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceedButton : MonoBehaviour
{
    public void Proceed()
    {
        SceneManager.LoadScene(2);
    }
}
