using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall.Collectables.PickUp {
    public class PickUpRotate : MonoBehaviour
    {
        void Update()
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }

}
