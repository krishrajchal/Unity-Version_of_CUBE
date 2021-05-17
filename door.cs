using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject sdfdoor;
    public GameObject gjsdoor;
    public GameObject player;

    private Collider sdfCol;
    private Collider playerCol;

    // Start is called before the first frame update
    void Start()
    {
        sdfCol = sdfdoor.GetComponent<Collider>();
        playerCol = player.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sdfCol.bounds.Intersects(playerCol.bounds))
        {
            sdfdoor.SetActive(false);
            gjsdoor.SetActive(true);
        }
    }
}
