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
