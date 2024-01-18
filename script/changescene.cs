using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changescene : MonoBehaviour
{
    public void scenechange(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
