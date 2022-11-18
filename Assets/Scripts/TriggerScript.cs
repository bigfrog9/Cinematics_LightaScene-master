using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public PlayableDirector timeline;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger1");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Trigger1");

            timeline.Play();

            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

        }
    }




}
