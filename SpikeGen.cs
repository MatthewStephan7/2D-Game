using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGen : MonoBehaviour
{
    public GameObject spike;
    public float minSpeed;
    public float curSpeed;
    public float maxSpeed;
    public float SpeedMulti;
    void Awake()
    {
        curSpeed = minSpeed;
        genSpike();
    }
   public void genSpike()
    {
        GameObject Spikeins = Instantiate(spike, transform.position, transform.rotation);

        Spikeins.GetComponent<SpikeScript>().spikeGen = this;

    }
    void Update()
    {
        if(curSpeed < maxSpeed)
        {
            curSpeed += SpeedMulti;
        }
    }

}
