using Fsi.Roguelite.Ui;
using Fsi.Roguelite.Upgradable;
using UnityEngine;

namespace Fsi.Roguelite
{
    public abstract class BlacksmithController<T> : MonoBehaviour
        where T : IUpgradable
    {
        [SerializeField]
        private BlacksmithUi<T> blacksmithUi;

        private void Start()
        {
            blacksmithUi.gameObject.SetActive(true);
        }

        public virtual void Upgrade(BlacksmithEntryUi<T> entry)
        {
            Debug.Log($"Blacksmith: Upgrade {entry.Value}");
            entry.Value.Upgrade();
        }
    }
}
