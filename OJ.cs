using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OJ : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        // https://www.youtube.com/watch?v=nYIbDAW950s&list=PL-8q4gkLWpdi2QP3EG-TMZjEF2bxXUIxE&index=2
        // Thanks Dani, very cool
        transform.Rotate(new Vector3(1, 1, Mathf.PingPong(Time.time, 1f)), 1f);
        if (gameObject.GetComponent<Collider>().bounds.Intersects(player.GetComponent<Collider>().bounds))
        {
            otherstuff();
        }
    }

    private void otherstuff()
    {
        GameObject save = GameObject.Find("speedy?");
        save.GetComponent<upSpeed>().speeed = true;
        save.GetComponent<upSpeed>().player = player;
        DontDestroyOnLoad(save);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
