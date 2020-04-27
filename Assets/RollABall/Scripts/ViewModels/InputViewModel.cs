using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace RollABall.ViewModels {
    public class InputViewModel : MonoBehaviour
    {
        private readonly ReactiveProperty<Vector3> _axis = new ReactiveProperty<Vector3>();
        public IReactiveProperty<Vector3> Axis => _axis;

        public void UpdateAxis(Vector3 vector) {
            _axis.Value = vector;
        }
    }
}

