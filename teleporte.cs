using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporte : MonoBehaviour
{
    public bool tele;
    public GameObject player;
    public LayerMask layers;

    private float x = Screen.width / 2;
    private float y = Screen.height / 2;

    private bool t;
    private Vector3 point;
    public TextMesh athing;

    void Start()
    {
        player = GameObject.Find("actualPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("actualPlayer") == null || !tele)
            return;

        if(GameObject.Find("texttet") != null)
            GameObject.Find("texttet").GetComponent<TextMesh>().text = "Don't press t (press t).";

        if (!GameObject.Find("actualPlayer").GetComponent<player>().ded)
        {
            thing();

            if (t)
            {
                GameObject.Find("actualPlayer").transform.position = point;
            }
        }
    }

    private int thing()
    {
        if (Input.GetKeyDown("t"))
        {
            t = true;
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layers))
            {
                point = hit.point;
            }
            return 0;
        }
        t = false;
        return 0;
    }
}
