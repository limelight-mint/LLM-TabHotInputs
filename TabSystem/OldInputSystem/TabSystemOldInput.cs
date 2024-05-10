using UnityEngine;

namespace PrimeLime.Utility.Tabs
{
    /// <summary>
    /// Unfortunately, Unity doesnt provide system to PRESS TAB and jump to the next input.
    /// This is what this class is here for.
    /// </summary>
    public class TabSystemOldInput : TabSystemBase
    {
        [SerializeField] protected KeyCode switchKey = KeyCode.Tab;

        private void Update()
        {
            if(!CurrentInput.isFocused) return;
            if(Input.GetKeyDown(switchKey)) JumpToNext();
        }
    }
}