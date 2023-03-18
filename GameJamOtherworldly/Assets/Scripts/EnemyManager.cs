using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    private float SpawnTime;
    public GameObject Enemy;

    private int Side = 0; // 0 = Right; 1 = Down; 2 = Up; 3 = Left;
    private bool canSpawn = true;

    private GameObject CloneEnemy;
    void Start()
    {
        print(Enemy.GetComponent<Transform>().rotation.z);
        SpawnTime = 7.0f;
        StartCoroutine(SpawnEnemy(SpawnTime));
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnEnemy(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            if (canSpawn)
            {
                if (waitTime > 2)
                {
                    waitTime -= 0.2f;
                }

                Side = Random.Range(0, 3);

                if (Side == 0) // Right
                {
                    CloneEnemy = Instantiate(Enemy, new Vector3(5, Random.Range(-5f, 3f), 0), Quaternion.identity);
                    CloneEnemy.transform.Rotate(0, 0, 0);
                    print("Transform: " + CloneEnemy.transform.position.ToString() + "Rotation: " + CloneEnemy.transform.rotation.ToString() + " Right");
                    canSpawn = false;
                }

                else if (Side == 1) // Down
                {
                    CloneEnemy = Instantiate(Enemy, new Vector3(Random.Range(7f, -8.3f), -1.41f, 0), Quaternion.identity);
                    CloneEnemy.transform.Rotate(0, 0, -90);
                    print("Transform: " + CloneEnemy.transform.position.ToString() + "Rotation: " + CloneEnemy.transform.rotation.ToString() + " Down");
                    canSpawn = false;
                }

                else if (Side == 2) // Up
                {
                    CloneEnemy = Instantiate(Enemy, new Vector3(Random.Range(-7f, 9f), 1.45f, 0), Quaternion.identity);
                    CloneEnemy.transform.Rotate(0, 0, 90);
                    print("Transform: " + CloneEnemy.transform.position.ToString() + "Rotation: " + CloneEnemy.transform.rotation.ToString() + " Up");
                    canSpawn = false;
                }

                else if (Side == 3) // Left
                {
                    CloneEnemy = Instantiate(Enemy, new Vector3(-5, Random.Range(4.5f, -3.2f), 0), Quaternion.identity);
                    CloneEnemy.transform.Rotate(0, 0, -180);
                    print("Transform: " + CloneEnemy.transform.position.ToString() + "Rotation: " + CloneEnemy.transform.rotation.ToString() + " Left");
                    canSpawn = false;
                }
            } else
            {
                Destroy(CloneEnemy);
                canSpawn = true;
            }
        }
    }
}
