using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Zenject;
using RollABall.ViewModels;

public class PlayerCollector : MonoBehaviour
{
    [Inject]
    CollectableViewModel viewModel;

    void Start()
    {
        this.OnTriggerEnterAsObservable()
            .Subscribe(x => {
                viewModel.OnEnter(x);
            });
    }
}