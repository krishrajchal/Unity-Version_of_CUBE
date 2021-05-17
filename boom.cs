using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class boom : MonoBehaviour
{
    public GameObject player;
    public int force;
    private void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            Collider[] colliders = Physics.OverlapSphere(player.transform.position, 20);
            foreach(Collider coll in colliders)
            {
                try
                {
                    if (coll.gameObject != player && coll.gameObject.tag != "uniSpike")
                        coll.gameObject.GetComponent<Rigidbody>().AddExplosionForce(force, player.transform.position, 20, 3.0f);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
