using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ZenoxZX.UI
{
    [Serializable]
    public class GUIBase
    {
        public event Action OnOpen;
        public event Action OnClose;
        [SerializeField] protected GameObject panel;
        protected RectTransform rectTransform;

        public virtual void Initialize() => rectTransform = panel.transform as RectTransform;
        public virtual void Open()
        {
            OnOpen?.Invoke();
            panel.SetActive(true);
        }

        public virtual void Close()
        {
            OnClose?.Invoke();
            panel.SetActive(false);
        }

        public virtual void TopMost() => rectTransform.SetAsLastSibling();
    }
}