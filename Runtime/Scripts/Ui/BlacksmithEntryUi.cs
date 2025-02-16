using System;
using Fsi.Roguelite.Upgradable;
using UnityEngine;

namespace Fsi.Roguelite.Ui
{
    public abstract class BlacksmithEntryUi<T> : MonoBehaviour
        where T : IUpgradable
    {
        public T Value { get; private set; }
        
        private Action<BlacksmithEntryUi<T>> onSelect;
            
        public virtual void Initialize(T value, Action<BlacksmithEntryUi<T>> onSelect)
        {
            Value = value;
            this.onSelect = onSelect;
        }

        public void Select()
        {
            onSelect?.Invoke(this);
        }
    }
}