using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyTemplate;
    private Enemy _enemy;

    private void Start()
    {
        _enemy = GetComponentInChildren<Enemy>();
    }

    public void CreateEnemy()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(_enemyTemplate, gameObject.transform).GetComponent<Enemy>();
        }
    }
}
