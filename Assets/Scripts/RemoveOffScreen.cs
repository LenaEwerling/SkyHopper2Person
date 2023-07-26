using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOffScreen : MonoBehaviour
{
    private StepSpawner stepSpawnerScript;

    // Start is called before the first frame update
    void Start()
    {
        stepSpawnerScript = GameObject.Find("Spawner").GetComponent<StepSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0.2f)
        {
            if (transform.position.x < -3)
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
                stepSpawnerScript.SpawnRightStep(6.2f);
                stepSpawnerScript.SpawnLeftStep(6.2f);
            }
        }
    }
}
