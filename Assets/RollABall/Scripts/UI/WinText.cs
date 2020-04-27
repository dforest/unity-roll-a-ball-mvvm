using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using Zenject;
using RollABall.ViewModels;

namespace RollABall.UI
{
    public class WinText : MonoBehaviour
    {
        [SerializeField]
        Text text;

        [Inject]
        CollectableViewModel viewModel;

        void Start()
        {
            text.text = "";
            viewModel.IsWin.Subscribe(b => {
                if (b) {
                    text.text = "You Win!";
                }
            });
        }
    }
}
