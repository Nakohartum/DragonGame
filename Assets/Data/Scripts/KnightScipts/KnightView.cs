using System;
using UnityEngine;

namespace DragonFight
{
    public class KnightView : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        private KnightController _controller;
        public event Action onDead;

        private void Start()
        {
            _animator = gameObject.GetComponent<Animator>();
        }

        public void Moved()
        {
            _animator.Play("knight");
            
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            onDead?.Invoke();;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            var renderer = gameObject.GetComponent<SpriteRenderer>();
            if (renderer.flipX)
            {
                renderer.flipX = false;
            }
            else
            {
                renderer.flipX = true;
            }
        }
    }
}