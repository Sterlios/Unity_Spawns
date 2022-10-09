using System.Collections;
using UnityEngine;

public class EnemiesSpawns : MonoBehaviour
{
    private EnemySpawn[] _spawns;

    private void Start()
    {
        _spawns = gameObject.GetComponentsInChildren<EnemySpawn>();
        StartCoroutine(CraeteEnemies());
    }

    private IEnumerator CraeteEnemies()
    {
        float waitSeconds = 2f;
        var waitTime = new WaitForSeconds(waitSeconds);

        foreach(var spawn in _spawns)
        {
            spawn.CreateEnemy();
            yield return waitTime;
        }
    }
}
