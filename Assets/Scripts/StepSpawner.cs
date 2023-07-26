using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSpawner : MonoBehaviour
{
    private int positionRight = 3;
    private int positionLeft = 0;
    

    public GameObject stepPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i <= 6; i++)
        {
            SpawnRightStep(i);
            SpawnLeftStep(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRightStep(float y)
    {
        Vector3 spawnPos = new Vector3(0, y, 0);
        if (positionRight == 0)
        {
            spawnPos = new Vector3(-1.5f, y, 0);
            positionRight = 1;
        }
        else if (positionRight == 3)
        {
            spawnPos = new Vector3(0, y, 0);
            positionRight = 2;
        }
        else if (positionRight == 1)
        {
            if (Random.Range(0, 2) == 0)
            {
                spawnPos = new Vector3(-3, y, 0);
                positionRight = 0;
            }
            else 
            {
                spawnPos = new Vector3(0, y, 0);
                positionRight = 2;
            }
        }
        else if (positionRight == 2)
        {
            if (Random.Range(0, 2) == 0)
            {
                spawnPos = new Vector3(-1.5f, y, 0);
                positionRight = 1;
            }
            else 
            {
                spawnPos = new Vector3(1.5f, y, 0);
                positionRight = 3;
            }
        }
        Instantiate(stepPrefab, spawnPos, stepPrefab.transform.rotation);
    }

    public void SpawnLeftStep(float y)
    {
        Vector3 spawnPos = new Vector3(0, y, 0);
        if (positionLeft == 0)
        {
            spawnPos = new Vector3(-7.5f, y, 0);
            positionLeft = 1;
        }
        else if (positionLeft == 3)
        {
            spawnPos = new Vector3(-6, y, 0);
            positionLeft = 2;
        }
        else if (positionLeft == 1)
        {
            if (Random.Range(0, 2) == 0)
            {
                spawnPos = new Vector3(-9, y, 0);
                positionLeft = 0;
            }
            else 
            {
                spawnPos = new Vector3(-6, y, 0);
                positionLeft = 2;
            }
        }
        else if (positionLeft == 2)
        {
            if (Random.Range(0, 2) == 0)
            {
                spawnPos = new Vector3(-7.5f, y, 0);
                positionLeft = 1;
            }
            else 
            {
                spawnPos = new Vector3(-4.5f, y, 0);
                positionLeft = 3;
            }
        }
        Instantiate(stepPrefab, spawnPos, stepPrefab.transform.rotation);
    }
}
