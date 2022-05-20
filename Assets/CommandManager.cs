using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public Stack<ICommand> commandStack = new Stack<ICommand>();

    public Transform unit;

    void Move(Vector3 direction, float speed)
    {
        ICommand newCommand = new MoveCommand(unit, direction, speed);
        newCommand.Execute();
        commandStack.Push(newCommand);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Move(Vector3.right, 2*Time.deltaTime);
        }
        else if (Input.GetMouseButton(1))
        {
            Undo();
        }
    }

    void Undo()
    {
        if(commandStack.Count>0)
        commandStack.Pop().Undo();
    }
}
