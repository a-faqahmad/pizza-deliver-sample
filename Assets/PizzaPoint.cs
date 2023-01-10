using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "character1")
        {
            GameManager.Instance.PizzaPicked();
        }
    }
}
