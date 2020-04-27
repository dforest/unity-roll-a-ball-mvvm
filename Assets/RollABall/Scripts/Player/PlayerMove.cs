using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Zenject;
using RollABall.ViewModels;
using RollABall.Configs;

namespace RollABall.Player {
    public class PlayerMove : MonoBehaviour
    {
        [Inject]
        InputViewModel inputViewModel;

        [Inject]
        PlayerViewModel playerViewModel;

        [Inject]
        GameConfig gameConfig;
        

        void Start()
        {
            var rig = GetComponent<Rigidbody>();

            this.FixedUpdateAsObservable()
                .WithLatestFrom(inputViewModel.Axis, (_, axis) => axis)
                .Subscribe(axis =>
                {
                    rig.AddForce(axis * gameConfig.playerSpeed);
                });

            this.UpdateAsObservable()
                .Select(_ => transform.position)
                .Subscribe(pos => playerViewModel.UpdatePosition(pos));
        }
    }
}
