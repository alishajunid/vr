using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneSwitcher : MonoBehaviour
{
    public string nextScene = "PaintingScene"; // Change this to your target scene name

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}



