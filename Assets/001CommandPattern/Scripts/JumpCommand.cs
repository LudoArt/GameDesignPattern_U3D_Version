using System.Collections;
using System.Collections.Generic;

public class JumpCommand : Command
{
    public override void Execute(Player actor)
    {
        actor.Jump();
    }
}