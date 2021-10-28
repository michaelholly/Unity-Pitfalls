using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] private GameObject prefab;
	[SerializeField] private float spawnDelay;
	private float spawnTimer;

    void Update()
    {
	    spawnTimer += Time.deltaTime;
	    if(spawnTimer > spawnDelay)
	    {
		    spawnTimer = 0;
		    Instantiate(prefab, transform.position, Quaternion.identity);
	    }
    }
}
