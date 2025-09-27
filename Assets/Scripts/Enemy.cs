using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EnemiesManager.instance.AddEnemy(this);
    }

    void OnDestroy()
    {
        EnemiesManager.instance.RemoveEnemy(this);
    }
}
