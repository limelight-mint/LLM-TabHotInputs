using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace PrimeLime.Utility.Tabs
{
    /// <summary>
    /// Unfortunately, Unity doesnt provide system to PRESS TAB and jump to the next input.
    /// This is what this class is here for.
    /// </summary>
    public class TabSystemBase : MonoBehaviour
    {
        [Tooltip("Inputs to jump between")]
        [SerializeField] protected List<TMP_InputField> inputs = new List<TMP_InputField>();

        public int CurrentId { get; protected set; }
        public TMP_InputField CurrentInput => inputs[CurrentId];

        protected void Awake() => SubscribeInputs();

        protected virtual void SubscribeInputs()
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                int index = i;
                inputs[i].onSelect.AddListener((value) => JumpTo(index));
            }
        }

        public void JumpToNext() 
        {
            CurrentInput.DeactivateInputField(true);
            
            JumpTo(CurrentId + 1 >= inputs.Count ?  0 : CurrentId + 1);
        }

        public virtual void JumpTo(int id)
        {
            CurrentId = id;
            inputs[id].ActivateInputField();
        }
    }
}