using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Monster
{
	public Dragon()
	{
		Debug.Log("Creat dragon prototype");
	}

	public override Monster Clone(int id)
	{
		Debug.Log("Creat dragon " + id);
		return new Dragon();
	}
}
