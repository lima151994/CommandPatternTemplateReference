using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    Transform transform;
    Vector3 direction;
    float speed;

    public MoveCommand(Transform transform, Vector3 direction, float speed)
    {
        this.transform = transform;
        this.direction = direction;
        this.speed = speed;
    }

    public void Execute()
    {
        transform.position += direction * speed;
    }

    public void Undo()
    {
        transform.position -= direction * speed;
    }

 
}
