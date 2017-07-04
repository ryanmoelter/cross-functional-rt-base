using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class NavigationHandler : MonoBehaviour
{
    public Selectable SelectFirst;
    private CanvasGroup _myCanvasGroup;
    [CanBeNull] private UiScreen _screen;

    void Awake()
    {
        _myCanvasGroup = GetComponent<CanvasGroup>();
        _screen = GetComponent<UiScreen>();
    }

    public void NavigateToThis()
    {
        AnimateToThis();
        
        _myCanvasGroup.interactable = true;

        if (_screen != null)
        {
            _screen.OnShow();
        }
        
        if (SelectFirst != null)
        {
            SelectFirst.Select();
        }
    }

    public void NavigateFromThis()
    {
        if (_screen != null)
        {
            _screen.OnHide();
        }
        
        AnimateFromThis();
        _myCanvasGroup.interactable = false;
    }

    public void AnimateToThis()
    {
        gameObject.SetActive(true);
    }

    public void AnimateFromThis()
    {
        gameObject.SetActive(false);
    }
}
