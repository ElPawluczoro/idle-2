using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject monkeyWorker;

    private GameObject monkeySpawned;

    static int monkeyWorkerCount;

    public void spawnMonkeyWorker() {
        monkeySpawned = Instantiate(monkeyWorker);
        monkeySpawned.transform.position = new Vector2(Random.Range(-2.0f,2.0f), Random.Range(-3.0f, -0.5f));
        monkeyWorkerCount++;
    }

    void monkeyWorkerHieredListener()
    {
        for (int i = 0; i < Stats.GetUnitsPerHire(); i++)
        {
            if (monkeyWorkerCount < 30)
            {
                spawnMonkeyWorker();
            }
            if (monkeyWorkerCount >= 30)
            {
                ButtonsControler.monkeyWorkerHiered -= monkeyWorkerHieredListener;
            }
        }
    }

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        ButtonsControler.monkeyWorkerHiered += monkeyWorkerHieredListener;
    }

}
