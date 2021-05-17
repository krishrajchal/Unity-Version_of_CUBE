using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class dedMenu : MonoBehaviour
{
    public GameObject player;
    public Image bgImage;

    private bool show = false;
    private float transition = 0.0f;
    private GameObject current;
    public Vector3 pos = new Vector3(11f, 32f, -56f);

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (!show)
            return;

        transition += Time.deltaTime;
        bgImage.color = Color.Lerp(new Color(0, 0, 0, 0), new Color(0, 0, 0, .7f), transition);
    }

    public void ToggleEndMenu()
    {
        GameObject[] stuff = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject level in stuff)
        {
            if (level.GetComponent<Collider>().bounds.Intersects(player.GetComponent<Collider>().bounds))
                current = level;
        }
        gameObject.SetActive(true);
        show = true;
        player.GetComponent<player>().ded = true;
    }

    public void StartingMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartLevel()
    {
        gameObject.SetActive(false);
        try
        {
            switch (int.Parse(current.name))
            {
                case 0:
                    pos = new Vector3(11f, 32f, -56f);
                    break;
                case 1:
                    pos = new Vector3(11f, 32f, -116f);
                    break;
                case 2:
                    pos = new Vector3(11f, 32f, -178f);
                    break;
                case 3:
                    pos = new Vector3(11f, 32f, -240);
                    break;
                case 4:
                    pos = new Vector3(11f, 32f, -302);
                    break;
                case 5:
                    pos = new Vector3(11f, 32f, -365);
                    break;
                case 6:
                    pos = new Vector3(11f, 32f, -417);
                    break;
            }
        }
        catch (Exception)
        {
            player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        player.transform.position = pos;
        player.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        Camera.main.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        show = false;
        player.GetComponent<player>().ded = false;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
