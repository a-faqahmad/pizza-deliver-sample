using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

	void Awake() => Instance = this;
    [SerializeField] private GameObject[] deliveryPoints;
    [SerializeField] private GameObject pizzaPoint;
    [SerializeField] private GameObject PizzaPickText, PizzaDeliverText;
    private int activeDeliveryPoint;
    
    public void PizzaPicked() {
        PizzaDeliverText.SetActive(true);
        PizzaPickText.SetActive(false);
        pizzaPoint.SetActive(false);
        activeDeliveryPoint = Random.Range(0, deliveryPoints.Length);
        deliveryPoints[activeDeliveryPoint].SetActive(true);
        deliveryPoints[activeDeliveryPoint].GetComponentInChildren<ParticleSystem>().Play();
    }
    
    public void PizzaDelivered() {
        PizzaDeliverText.SetActive(false);
        PizzaPickText.SetActive(true);
        deliveryPoints[activeDeliveryPoint].SetActive(false);
        pizzaPoint.SetActive(true);
        pizzaPoint.GetComponentInChildren<ParticleSystem>().Play();
    }
}
