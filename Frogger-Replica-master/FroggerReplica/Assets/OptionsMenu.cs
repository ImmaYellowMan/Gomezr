using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void SetCarSpeed(float CarSpeed)
    {
        Car.speed = CarSpeed;
        //Debug.Log(CarSpeed);
    }
}
