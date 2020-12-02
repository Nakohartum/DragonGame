using System;
using UnityEngine;

namespace DragonFight
{
    public class PlatformView : MonoBehaviour
    {
        private TowerController _towerController;
        private Animator _animator;
        public event Action OnDie;
        

        

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Destroyer"))
            {
                OnDie?.Invoke();
            }
        }
    }
}