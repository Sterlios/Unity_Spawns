using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyTemplate;
    private Enemy _enemy;

    private void Start()
    {
        _enemy = gameObject.GetComponentInChildren<Enemy>();
    }

    public void CreateEnemy()
    {
        if (_enemy == null)
        {
            Instantiate(_enemyTemplate, gameObject.transform);
        }
    }
}
