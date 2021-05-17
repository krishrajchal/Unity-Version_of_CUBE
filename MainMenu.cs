using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject title;
    public GameObject sub;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Colorfull(title));
        StartCoroutine(Colorfull(sub));
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void Sandbox()
    {
        SceneManager.LoadScene("Sandbox");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator Colorfull(GameObject target)
    {
        Text text = target.GetComponent<Text>();
        int r = Random.Range(0, 255);
        int g = Random.Range(0, 255);
        int b = Random.Range(0, 255);

        text.color = new Color(r, g, b, 1);
        yield return new WaitForSeconds(1);
    }
}
