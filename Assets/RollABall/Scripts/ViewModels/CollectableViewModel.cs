using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace RollABall.ViewModels {
    public class CollectableViewModel : MonoBehaviour
    {
        readonly ReactiveProperty<Collider> _collider = new ReactiveProperty<Collider>();

        public void OnEnter(Collider collider) {
            _collider.Value = collider;
        }

        public IObservable<ICollectable> EnteredCollectable => _collider
            .Where(c => c != null && c.gameObject.GetComponent<ICollectable>() != null )
            .Select(c => c.gameObject.GetComponent<ICollectable>());

        readonly ReactiveProperty<int> _score = new ReactiveProperty<int>(0);
        public IReactiveProperty<int> Score => _score;

        public IObservable<bool> IsWin => _score.Select(i => i >= 12);

        void Start()
        {
            EnteredCollectable.Subscribe(c => {
                c.Collect();
                _score.Value += 1;
            });
        }
    }

}
