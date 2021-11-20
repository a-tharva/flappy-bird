using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{

    public GameObject columnPrefab;
    
    public float minY, maxY;
    
    float timer;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        // Initial column spawn (4 columns)
        SpawnColumnStart();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            SpawnColumn();
            timer = 0;
        }
    }
    
    void SpawnColumn()
    {
    
        float randYPos = Random.Range(minY, maxY);
    
        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector2(
            transform.position.x + 12,
            randYPos);

    }
    
    // Spawn 4 columns at the start
    void SpawnColumnStart()
    {
        // 1
        
        float randYPos1 = Random.Range(minY, maxY);
    
        GameObject newColumn1 = Instantiate(columnPrefab);
        newColumn1.transform.position = new Vector2(
            transform.position.x,
            randYPos1);
        
        // 2
        
        float randYPos2 = Random.Range(minY, maxY);
        
        GameObject newColumn2 = Instantiate(columnPrefab);
        newColumn2.transform.position = new Vector2(
            transform.position.x + 8,
            randYPos2);
            
         // 3
        
        float randYPos3 = Random.Range(minY, maxY);
        
        GameObject newColumn3 = Instantiate(columnPrefab);
        newColumn3.transform.position = new Vector2(
            transform.position.x + 12,
            randYPos3);
            
        // 4
        
        float randYPos4 = Random.Range(minY, maxY);
        
        GameObject newColumn4 = Instantiate(columnPrefab);
        newColumn4.transform.position = new Vector2(
            transform.position.x + 4,
            randYPos4);
    }
}
