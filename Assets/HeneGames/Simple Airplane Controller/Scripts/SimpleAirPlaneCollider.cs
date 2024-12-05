using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeneGames.Airplane
{
    public class SimpleAirPlaneCollider : MonoBehaviour
    {
        public bool collideSometing;

        [HideInInspector]
        public SimpleAirPlaneController controller;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<SimpleAirPlaneCollider>() == null && other.gameObject.GetComponent<LandingArea>() == null)
            {
                collideSometing = true;

                if (other.isTrigger)
                {
                    HandleTriggerCollision(other);
                }
                else
                {
                    HandleRegularCollision(other);
                }
            }
        }


        private void HandleTriggerCollision(Collider other)
        {

            Debug.Log("Hit a trigger: " + other.gameObject.name);

            controller.triggerHit(other.tag); 
        }

        private void HandleRegularCollision(Collider other)
        {

            Debug.Log("Hit a non-trigger: " + other.gameObject.name);

            controller.Crash(true); 
        }
    }
}