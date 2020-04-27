using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using Zenject;
using RollABall.ViewModels;

namespace RollABall.UI {
    public class CountText : MonoBehaviour
    {
        [SerializeField]
        Text text;

        [Inject]
        CollectableViewModel viewModel;

        void Start()
        {
            viewModel.Score.Subscribe( i => text.text = "Count: " + i.ToString());
        }
    }
}
