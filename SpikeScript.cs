using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public SpikeGen spikeGen;

    void Update()
    {
        transform.Translate(Vector2.left * spikeGen.curSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("next"))
        {
            spikeGen.genSpike();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
        
    }
}
