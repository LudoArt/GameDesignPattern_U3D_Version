using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner
{
	protected Monster prototype;

	public abstract Monster spawnMonster(int id);
}

// T约束，T必须继承名为Monster的类，T必须要有一个无参构造函数
public class SpawnerFor<T>: Spawner where T : Monster, new()
{
	public SpawnerFor()
	{
		prototype = new T();
	}

	public override Monster spawnMonster(int id)
	{
		return prototype.Clone(id);
	}
}