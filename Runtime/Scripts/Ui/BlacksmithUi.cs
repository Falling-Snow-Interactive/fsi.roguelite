using System.Collections.Generic;
using Fsi.Roguelite.Upgradable;
using UnityEngine;

namespace Fsi.Roguelite.Ui
{
    public class BlacksmithUi<T> : MonoBehaviour
        where T : IUpgradable
    {
        [Header("Scene References")]

        [SerializeField]
        private BlacksmithController<T> blacksmith;

        private List<BlacksmithEntryUi<T>> blacksmithEntries;

        private void Awake()
        {
            blacksmithEntries = new List<BlacksmithEntryUi<T>>();
        }

        private void OnEntrySelected(BlacksmithEntryUi<T> entry)
        {
            blacksmith.Upgrade(entry);
        }
    }
}
