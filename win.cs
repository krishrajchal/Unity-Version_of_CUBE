using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public Image bgImage;

    public bool show = false;
    private float transition;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transition += Time.deltaTime;
        if (!show)
        {
            return;
        }

        bgImage.color = Color.Lerp(new Color(0f, 0f, 0f, 0f), new Color(0, 0, 0, .7f), transition);
    }

    public void StartingMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
