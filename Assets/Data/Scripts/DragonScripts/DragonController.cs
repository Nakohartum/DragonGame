using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DragonFight
{
    public class DragonController : IUpdatable, IDieable
    {
        #region Fields

        [SerializeField] private DragonModel _dragonModel;
        private DragonStruct _dragonAccess;
        private Rigidbody2D _rigidbody;
        private DragonView _dragonView;
        private bool _isDead;
        
        public event Action<bool> OnMove;
        public event Action<bool> OnWalk;
        #endregion

        #region Constructor

        public DragonController(DragonModel dragonModel)
        {
            _dragonModel = dragonModel;
            _dragonAccess = _dragonModel._dragonStruct;
            _rigidbody = _dragonAccess._rigidbody;
            _dragonView = _dragonAccess._dragon.GetComponent<DragonView>();
            _dragonView._dragonController = this;
            OnMove += _dragonView.HasMoved;
            OnWalk += _dragonView.Walk;
            _isDead = false;
            

        }

        #endregion
        public void UpdateTick()
        {
            Walking();
            if (Input.GetButton("Fire1"))
            {
                _dragonAccess._rigidbody.AddForce(new Vector2(0, _dragonAccess._force), ForceMode2D.Impulse);
                OnMove?.Invoke(true);
            }
        }

        public void Walking()
        {
            
            var cast = Physics2D.Raycast(
                new Vector2(_dragonAccess._dragon.transform.position.x, _dragonAccess._dragon.transform.position.y),
                Vector2.down, 1.0f);
            if (cast.transform != null)
            {
                OnWalk?.Invoke(true);
            }
        }
        
        
        public void Die()
        {
            
            _isDead = true;
            _dragonAccess._dragon.SetActive(false);
        }
    }
}