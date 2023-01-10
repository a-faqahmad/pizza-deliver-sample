using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "character1")
        {
            GameManager.Instance.PizzaDelivered();
        }
    }
}
