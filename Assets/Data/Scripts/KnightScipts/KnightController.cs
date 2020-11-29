using System;
using UnityEngine;

namespace DragonFight
{
    public class KnightController : IUpdatable
    {
        #region Fields

        private KnightModel _knightModel;
        public KnightStruct _knightAccessor;
        public event Action OnChange;
        private KnightView _knightView;

        public KnightController(KnightModel knightModel)
        {
            _knightModel = knightModel;
            _knightAccessor = _knightModel._knightStruct;
            _knightView = _knightAccessor._knight.GetComponent<KnightView>();
            OnChange += _knightView.Moved;
            _knightView.OnHit += Hitted;

        }

        #endregion
        public void UpdateTick()
        {
            if (_knightAccessor._spriteRenderer.flipX)
            {
                _knightAccessor._knight.transform.position += new Vector3(_knightAccessor._speed * -1, 0, 0) * Time.deltaTime;
            }
            else
            {
                _knightAccessor._knight.transform.position += new Vector3(_knightAccessor._speed, 0, 0) * Time.deltaTime;
            }
            
            OnChange?.Invoke();
        }

        public void Hitted()
        {
            if (_knightAccessor._spriteRenderer.flipX)
            {
                _knightAccessor._spriteRenderer.flipX = false;
            }
            else
            {
                _knightAccessor._spriteRenderer.flipX = true;
            }
        }
        
    }
}