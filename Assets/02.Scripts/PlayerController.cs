using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] private EnemyManager enemyManager;
    // Start is called before the first frame update
    private float speed = 5.0f;
    void Start()
    {
        Application.targetFrameRate = 60;
        Debug.Log("Hello World");
        // enemyManager.AttackAll();
        Debug.Log("Hello World qq");

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        Debug.Log(collision.gameObject.name);
    }
}
