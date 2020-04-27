using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Zenject;
using RollABall.ViewModels;

namespace RollABall.UI {
    public class KeyboardInput : MonoBehaviour
    {
        [Inject]
        InputViewModel inputViewModel;

        void Start()
        {
            this.UpdateAsObservable()
                .Select(_ => new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")))
                .Subscribe(vector => inputViewModel.UpdateAxis(vector));
        }
    }
}