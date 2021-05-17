using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject player;
    public GameObject toStart;
    public GameObject win;
    public GameObject ded;

    public float maxSpeed;
    public int amountOfSpikes;

    private Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
    private Collider b;
    private bool wait = false;
    private bool done = false;

    void Start()
    {
        b = toStart.GetComponent<Collider>();
        for (int i=0; i<amountOfSpikes; i++)
        {
            IDKHowToNameThisFun();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3((Mathf.Sin(Time.time * 100f) * Random.Range(0f, 1f))+19, transform.position.y, (Mathf.Sin(Time.time * 100f) * Random.Range(0f, 1f))-481);
        foreach (GameObject a in GameObject.FindGameObjectsWithTag("uniSpike"))
        {
            if (b.bounds.Intersects(player.GetComponent<Collider>().bounds))
            {
                if (!done)
                    a.transform.position = Vector3.Lerp(player.transform.position, a.transform.position, maxSpeed);

                if (a.transform.position.y <= -35)
                    a.transform.position = new Vector3(a.transform.position.x, -20, a.transform.position.z);
                a.transform.LookAt(player.transform); 
                wait = true;
            }
            }
        StartCoroutine(doWait());
    }

    IEnumerator doWait()
    {
        if (wait && !GameObject.Find("actualPlayer").GetComponent<player>().ded && b.bounds.Intersects(player.GetComponent<Collider>().bounds))
        {
            for(int i = 0; i < 60; i++)
            {
                if (!b.bounds.Intersects(player.GetComponent<Collider>().bounds) || player.GetComponent<player>().ded)
                    yield break;

                yield return new WaitForSeconds(1);
            }

            done = true;
            ded.SetActive(false);
            GameObject.Find("actualPlayer").GetComponent<player>().ded = true;
            win.GetComponent<win>().show = true;
            win.SetActive(true);
        }
    }

    private void IDKHowToNameThisFun()
    {
        GameObject clone = Instantiate(GameObject.Find("movingSpike"));

        clone.transform.localPosition = GameObject.Find("movingSpike").transform.position;
        clone.transform.localScale = new Vector3(4f, 4f, 4f);
    }
}
