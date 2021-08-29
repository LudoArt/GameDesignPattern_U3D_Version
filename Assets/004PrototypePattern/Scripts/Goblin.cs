using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Monster
{
	public Goblin()
	{
		Debug.Log("Creat goblin prototype");
	}

	public override Monster Clone(int id)
	{
		Debug.Log("Creat goblin " + id);
		return new Goblin();
	}
}
