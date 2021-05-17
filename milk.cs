using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class milk : MonoBehaviour
{
    public GameObject player;
    public GameObject ded;
    public GameObject thing;
    public TextMesh athing;

    void Update()
    {
        // https://www.youtube.com/watch?v=nYIbDAW950s&list=PL-8q4gkLWpdi2QP3EG-TMZjEF2bxXUIxE&index=2
        // Thanks Dani, very cool
        transform.Rotate(new Vector3(1, 1, Mathf.PingPong(Time.time, 1f)), 1f);

        if (thing.GetComponent<Collider>().bounds.Intersects(player.GetComponent<Collider>().bounds))
        {
            ded.SetActive(false);
            player.GetComponent<player>().ded = false;
            if (gameObject.GetComponent<Collider>().bounds.Intersects(player.GetComponent<Collider>().bounds))
            {
                otherstuff();
            }
        }
    }

    private void otherstuff()
    {
        GameObject save = GameObject.Find("teleportation?");
        save.GetComponent<teleporte>().tele = true;
        save.GetComponent<teleporte>().player = player;
        save.GetComponent<teleporte>().athing = athing;
        DontDestroyOnLoad(save);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
