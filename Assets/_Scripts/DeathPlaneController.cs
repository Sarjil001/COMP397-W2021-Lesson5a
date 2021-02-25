using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spwanPoint;


    void OnTriggerEnter(Collider other)
    {
        //check if the obj collision is player
        if(other.gameObject.CompareTag("Player"))
        {
            //get a reference to player's controller
            var controller = other.gameObject.GetComponent<CharacterController>();
            //turn controller off
            controller.enabled = false;
            //move to spawn point
            other.gameObject.transform.position = spwanPoint.position;
            //turn on
            controller.enabled = true;
        }
    }
}
