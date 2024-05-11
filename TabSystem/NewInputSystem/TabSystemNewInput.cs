using UnityEngine;
using UnityEngine.InputSystem;

namespace LLM.Utility.Tabs
{
    /// <summary>
    /// Unfortunately, Unity doesnt provide system to PRESS TAB and jump to the next input.
    /// This is what this class is here for.
    /// </summary>
    public class TabSystemNewInput : TabSystemBase
    {
        [Space]
        [SerializeField] protected InputAction switchInputAction;

        protected void OnEnable() => switchInputAction.Enable();

        protected void OnDisable() => switchInputAction.Disable();

        protected override void SubscribeInputs()
        {
            base.SubscribeInputs();
            switchInputAction.started += JumpToNext;
        }

        protected void JumpToNext(InputAction.CallbackContext context) => JumpToNext();
    }
}