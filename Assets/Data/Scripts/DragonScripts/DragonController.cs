using System;
using UnityEngine;

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
        public event Action<bool> OnGrounded; 
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
            OnGrounded += _dragonView.HasGrounded;
            
            _isDead = false;
            

        }

        #endregion
        public void UpdateTick()
        {
            RaycastHit hit;
            Ray ray = new Ray(_dragonAccess._dragon.transform.position, Vector3.down);
            var raycast = Physics.Raycast(ray, out hit, 20.0f);
            if (raycast)  
            {
                Debug.DrawRay(_dragonAccess._dragon.transform.position, Vector3.down, Color.red, 50.0f);
                OnGrounded?.Invoke(true);
            }
            
            if (Input.GetButton("Fire1"))
            {
                _dragonAccess._rigidbody.AddForce(new Vector2(0, _dragonAccess._force), ForceMode2D.Impulse);
                OnMove?.Invoke(true);
            }
        }

        public void Die()
        {
            _isDead = true;
            _dragonAccess._dragon.SetActive(false);
        }
    }
}