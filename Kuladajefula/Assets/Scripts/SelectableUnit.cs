using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectableUnit : MonoBehaviour
{
    public bool _isSelected;
    public List<MonoBehaviour> components;

    private void Start()
    {
        if (_isSelected == true)
        {
            OnSelected();
        }
        else
        {
            OnDeselected();
        }
    }
    private void OnMouseDown()
    {
        _isSelected = !_isSelected;
        if(_isSelected == true)
        {
            OnSelected();
        }
        else
        {
            OnDeselected();
        }
    }

    private void OnSelected()
    {
        for (int i = 0; i <components.Count; i++)
        {
            components[i].enabled = true;
        }
    }
    private void OnDeselected()
    {
        for (int i = 0; i < components.Count; i++)
        {
            components[i].enabled = false;
        }
    }
}
