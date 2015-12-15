using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	[SerializeField] Transform[] m_SpawnPoints;
	[SerializeField] GameObject enemy;
	
	int m_range;
	int m_enemyCount;
	
	void Start()
	{
		InvokeRepeating("Spawn", 10, 20);
	}
	
	void Spawn ()
	{
		switch (enemy.name) {
		case "Bat":
			m_range = 30;
			break;
		case "Tarantula":
			m_range = 60;
			break;
		case "Ghost":
			m_range = 90;
			break;
		default:
			break;
		}
		
		int spawn = Random.Range(0, m_range);
		int spot = Random.Range(0, m_SpawnPoints.Length);
		
		if (spawn < 15 && m_enemyCount < 4)
		{
			Instantiate(enemy, m_SpawnPoints[spot].position, m_SpawnPoints[spot].rotation);
			m_enemyCount += 1;
			StartCoroutine(Death (enemy, 9));
		}	
	}
	
	IEnumerator Death (GameObject enemy, int time)
	{
		yield return new WaitForSeconds(time);
//		Destroy(enemy);
	}
	
}
