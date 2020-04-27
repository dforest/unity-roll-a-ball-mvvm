using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Zenject;

namespace RollABall.Collectables.PickUp {
    public class PickUpCollectable : MonoBehaviour, ICollectable
    {
        public void Collect()
        {
            gameObject.SetActive(false);
        }
    }

}
