using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{

    public static CommandManager Instance;
    public Player player;
    public int undoStepNum = 20;

    public KeyCode LEFT = KeyCode.A;
    public KeyCode RIGHT = KeyCode.D;
    public KeyCode JUMP = KeyCode.Space;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        InputHandler();
    }

    private void InputHandler()
    {
        if (Input.GetKey(LEFT))
        {
            Command cmd = new MoveLeftCommand();
            cmd.Execute(player);
        }
        if (Input.GetKey(RIGHT))
        {
            Command cmd = new MoveRightCommand();
            cmd.Execute(player);
        }
        if (Input.GetKey(JUMP))
        {
            Command cmd = new JumpCommand();
            cmd.Execute(player);
        }
    }
}
