using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // [SerializeField] private EnemyController[] enemyControllers;
    // Start is called before the first frame update
    [SerializeField] GameObject enemyPrefab;
    // private List<EnemyController> enemyControllers = new List<EnemyController>();
    void Start()
    {
        Debug.Log(gameObject.name);

        for (int i = 0; i < 10; i++)
        {
            // GameObject enemy = Instantiate(enemyPrefab, new Vector3(i * 2.0f, 2.0f, 0), Quaternion.identity);
            // enemy.transform.SetParent(gameObject.transform);
        }

        // transform.rotation
        // transform.position
        // transform.localScale
        
        // EnemyController[] enemyControllerData = gameObject.GetComponentsInChildren<EnemyController>();
        // foreach (EnemyController controller in enemyControllerData)
        // {
        //    enemyControllers.Add(controller);
        // }

    //    enemyControllers = FindObjectsOfType<EnemyController>();
    //    foreach (EnemyController controller in enemyControllers)
    //     {
    //         Debug.Log(controller.gameObject.name);
    //     }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void AttackAll()
    // {
    //     foreach (EnemyController controller in enemyControllers)
    //     {
    //         controller.Attack();
    //     }
    // }
}
