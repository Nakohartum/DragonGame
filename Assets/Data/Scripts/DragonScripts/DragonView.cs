using System;
using UnityEngine;

namespace DragonFight
{
    public class DragonView : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        public DragonController _dragonController;
        

        private void Start()
        {
            _animator = gameObject.GetComponent<Animator>();
            
        }

        public void HasMoved(bool moved)
        {
            if (moved)
            {
                _animator.Play("dragon");
            }
        }
        
        public void HasGrounded(bool moved)
        {
            if (moved)
            {
                _animator.Play("DragonWalk");
            }
        }
    }
}