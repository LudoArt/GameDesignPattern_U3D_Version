using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : Command
{

    public override void Execute(Player actor)
    {
        actor.MoveLeft();
    }
}
