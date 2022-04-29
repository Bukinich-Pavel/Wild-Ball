using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKeyE : MonoBehaviour
{
    public Canvas helpKey;
    private Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }
    

    private void Update()
    {
        if (NextToTheTrigger())
        {
            helpKey.gameObject.SetActive(true);

            if (Input.GetButton("E"))
            {
                anim.Play();
            }
        }
        else
        {
            helpKey.gameObject.SetActive(false);
        }

    }


    private bool NextToTheTrigger()
    {
        var bridge = GameObject.Find("Player");
        if (Vector3.Distance(transform.position, bridge.transform.position) <= 3) return true;
        return false;
    }
}
