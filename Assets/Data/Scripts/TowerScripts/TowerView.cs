using System;
using UnityEngine;

namespace DragonFight
{
    public class TowerView : MonoBehaviour
    {
        private TowerController _towerController;
        private Animator _animator;
        public event Action OnDie;
        private void Start()
        {
            _animator = gameObject.GetComponent<Animator>();
        }

        public void Changed()
        {
            _animator.Play("TowerAnim");
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Destroyer"))
            {
                OnDie?.Invoke();
            }
        }
    }
}