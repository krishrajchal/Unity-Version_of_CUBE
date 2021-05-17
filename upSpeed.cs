using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class upSpeed : MonoBehaviour
{
    public GameObject player;
    public bool speeed;

    void Update()
    {
        try
        {
            if (speeed && !GameObject.Find("actualPlayer").GetComponent<player>().ded)
                GameObject.Find("actualPlayer").GetComponent<player>().maxSpeed = 50;
        }
        catch (Exception)
        {
            return;
        }
    }
}
