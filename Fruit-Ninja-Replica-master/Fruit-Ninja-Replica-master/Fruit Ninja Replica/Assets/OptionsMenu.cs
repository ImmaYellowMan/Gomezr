using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Dropdown fruitSize;
    public Dropdown spawnRate;
    public Dropdown fruitSpeed;
    //public Dropdown otherFruit;
    public Dropdown bladeSize;
    public Dropdown gravityModifier;
    public Dropdown gameMode;

    // Update is called once per frame
    void Update()
    {

        switch (fruitSize.value)
        {
            case 1:
                Fruit.width = .5f;
                Fruit.Length = .5f;
                Fruit.height = .5f;
                break;
            case 2:
                Fruit.width = 1f;
                Fruit.Length = 1f;
                Fruit.height = 1f;
                break;
            case 3:
                Fruit.width = 2f;
                Fruit.Length = 2f;
                Fruit.height = 2f;
                break;

        }

        switch (spawnRate.value)
        {
            case 1: //slow
                FruitSpawner.minDelay = .7f;
                FruitSpawner.maxDelay = 2f;
                break;
            case 2: //meduim
                FruitSpawner.minDelay = .1f;
                FruitSpawner.maxDelay = 1f;
                break;
            case 3: //fast
                FruitSpawner.minDelay = .1f;
                FruitSpawner.maxDelay = .5f;
                break;
        }

        switch (fruitSpeed.value)
        {
            case 1:
                Fruit.startForce = 10f;
                break;
            case 2:
                Fruit.startForce = 13f;
                break;
            case 3:
                Fruit.startForce = 20f;
                break;

        }

        switch (bladeSize.value)
        {
            case 1:
                Fruit.width = .5f;
                Fruit.Length = .5f;
                Fruit.height = .5f;
                break;
            case 2:
                Fruit.width = 1f;
                Fruit.Length = 1f;
                Fruit.height = 1f;
                break;
            case 3:
                Fruit.width = 10f;
                Fruit.Length = 10f;
                Fruit.height = 10f;
                break;

        }

        switch (gravityModifier.value)
        {
            case 1:
                Fruit.gravity = .5f;
                break;
            case 2:
                Fruit.gravity = 1f;
                break;
            case 3:
                Fruit.gravity = 4f;
                break;
        }


        switch (gameMode.value)
        {
            case 1:
                Gamemode.timer = 60f;
                break;
            case 2:
                Gamemode.timer = 90f;
                break;
            case 3:
                Gamemode.timer = 120f;
                break;

        }

    }
}
