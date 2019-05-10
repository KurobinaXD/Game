using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControler : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab1;
    [SerializeField] private GameObject enemyPrefab2;
    private GameObject _enemy1;
    private GameObject _enemy2;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (_enemy1 == null)
        {
            _enemy1 = Instantiate(enemyPrefab1) as GameObject;
            //_enemy.transform.position = new Vector3(0, 1, 0);
            _enemy1.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            _enemy1.transform.Rotate(0, angle, 0);
        }
        if (_enemy2 == null)
        {
            _enemy2 = Instantiate(enemyPrefab2) as GameObject;
            //_enemy.transform.position = new Vector3(0, 1, 0);
            _enemy2.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            _enemy2.transform.Rotate(0, angle, 0);
        }

    }
}
