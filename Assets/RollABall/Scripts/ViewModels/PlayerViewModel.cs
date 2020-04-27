using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerViewModel : MonoBehaviour
{
    ReactiveProperty<Vector3> _position = new ReactiveProperty<Vector3>();
    public IReactiveProperty<Vector3> Position => _position;

    public void UpdatePosition(Vector3 pos)
    {
        Position.Value = pos;
    }
}
