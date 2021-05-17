using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public List<bool> colors;

    // The levels are yellow, blue, green, orange, pink, purple, and red.

    private void Start()
    {
        colors.Add(false);
        colors.Add(false);
        colors.Add(false);
        colors.Add(false);
        colors.Add(false);
        colors.Add(false);
        colors.Add(false);
    }

    public void StartGame()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("main");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Yellow()
    {
        colors[0] = true;
        StartGame();
    }

    public void Blue()
    {
        colors[1] = true;
        StartGame();
    }

    public void Green()
    {
        colors[2] = true;
        StartGame();
    }

    public void Orange()
    {
        colors[3] = true;
        StartGame();
    }

    public void Pink()
    {
        colors[4] = true;
        StartGame();
    }

    public void Purple()
    {
        colors[5] = true;
        StartGame();
    }

    public void Red()
    {
        colors[6] = true;
        StartGame();
    }
}
