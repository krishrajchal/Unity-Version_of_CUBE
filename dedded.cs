using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dedded : MonoBehaviour
{
    public GameObject player;
    public GameObject thing;

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.GetComponent<Collider>().bounds.Intersects(player.GetComponent<Collider>().bounds)){
            player.GetComponent<player>().ded = true;
            thing.SetActive(true);
        }
    }
}
