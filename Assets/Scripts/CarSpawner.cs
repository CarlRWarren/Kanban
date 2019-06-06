using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] possibleCars;
    [SerializeField] GameObject car = null;
    [SerializeField] float carSpeed = 1.0f;
    float timer = 0.0f;

    void Start()
    {
        car = Instantiate(possibleCars[Random.Range(0, possibleCars.Length - 1)], transform.position, Quaternion.identity, transform);
        carSpeed += Random.Range(0, 3);
    }

    void Update()
    {
        timer += Time.deltaTime;

        car.transform.position += (car.transform.right * (carSpeed) * Time.deltaTime);

        if (timer >= 5.0f)
        {
            timer = 0.0f;
        }
        if (car.transform.position.x >= 6)
        {
            car = Instantiate(possibleCars[Random.Range(0, possibleCars.Length - 1)], transform.position, Quaternion.identity, transform);
        }
        if (car.transform.position.x <= -6)
        {
            car = Instantiate(possibleCars[Random.Range(0, possibleCars.Length - 1)], transform.position, Quaternion.identity, transform);
        }

    }
}
