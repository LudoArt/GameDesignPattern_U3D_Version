using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    Spawner DragonSpawner;
    Spawner GoblinSpawner;

	private void Awake()
	{
        DragonSpawner = new SpawnerFor<Dragon>();
        GoblinSpawner = new SpawnerFor<Goblin>();
    }

	// 测试用
	private void Start()
	{
        InvokeRepeating(nameof(testSpawn), 1, 2);
    }

    private void testSpawn()
	{
        int type = Random.Range(0, 2);
        int id = Random.Range(0, 100);

        SpawnerMonster((MonsterType)type, id);
    }

	public void SpawnerMonster(MonsterType type, int id)
	{
        switch(type)
		{
            case MonsterType.Dragon:
                DragonSpawner.spawnMonster(id);
                break;
            case MonsterType.Goblin:
                GoblinSpawner.spawnMonster(id);
                break;
            default:
                Debug.LogError("No this monster type: " + type.ToString());
                break;
		}
	}
}


public enum MonsterType
{
    Dragon,
    Goblin
}
