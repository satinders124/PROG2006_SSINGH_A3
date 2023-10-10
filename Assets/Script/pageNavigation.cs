using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pageNavigation : MonoBehaviour
{
    public void LoadMyScene(string sceneName)
{
     SceneManager.LoadScene(sceneName);
}
}
