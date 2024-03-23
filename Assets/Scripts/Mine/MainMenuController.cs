//////////////////////////////////////////////
//Assignment/Lab/Project: Collision Resolution
//Name: Brian Jernigan
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////

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
