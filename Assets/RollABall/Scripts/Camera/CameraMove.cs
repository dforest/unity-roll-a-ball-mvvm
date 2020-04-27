using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Zenject;
using RollABall.ViewModels;

namespace RollABall.Camera {
    public class CameraMove : MonoBehaviour
    {
        [Inject]
        PlayerViewModel playerViewModel;

        private Vector3 offset;

        void Awake()
        {
            playerViewModel.Position.First().Subscribe(pos =>
            {
                offset = transform.position - pos;
            });
        }

        void Start()
        {
            playerViewModel.Position.Subscribe(pos =>
            {
                transform.position = pos + offset;
            });
        }

    }

}
