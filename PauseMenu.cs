using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Transform player;
    public Image bgImage;

    private bool show = false;
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
            gameObject.SetActive(false);
            return;
        }

        if (GameObject.Find("ded") != null)
        {
            if (GameObject.Find("ded").activeInHierarchy)
            {
                gameObject.SetActive(false);
            }
        }
        
        bgImage.color = Color.Lerp(new Color(0f, 0f, 0f, 0f), new Color(0, 0, 0, .7f), transition);
    }

    public void StartingMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        gameObject.SetActive(true);
        GameObject.Find("actualPlayer").GetComponent<player>().ded = true;
        show = true;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        gameObject.SetActive(false);
        GameObject.Find("actualPlayer").GetComponent<player>().ded = false;
        show = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RestartLevel()
    {
        player.transform.position = new Vector3(0, 0, 0);
    }
}
