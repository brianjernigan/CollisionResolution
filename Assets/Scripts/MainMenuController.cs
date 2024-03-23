using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject _playButton;

    public void OnClickPlayButton()
    {
        SceneManager.LoadScene("CollisionResolution");
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }
}
