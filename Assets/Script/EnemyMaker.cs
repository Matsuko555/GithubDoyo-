using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float enemyZ;
    [SerializeField] private float enemyX;
    private float ranX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }

        else
        {
            ranX = Random.Range(enemyX * -1, enemyX);
            Instantiate(enemyPrefab, new Vector3(ranX, 0, enemyZ), enemyPrefab.transform.rotation);
            
            waitTime = 0;
        }
        
    }
}
