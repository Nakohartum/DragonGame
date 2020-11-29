using System;
using UnityEngine;

namespace DragonFight
{
    public class KnightView : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        private KnightController _controller;
        public event Action OnHit;

        private void Start()
        {
            _animator = gameObject.GetComponent<Animator>();
        }

        public void Moved()
        {
            _animator.Play("knight");
            
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
           OnHit?.Invoke();
        }
    }
}