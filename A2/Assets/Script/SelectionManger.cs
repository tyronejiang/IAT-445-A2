using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManger : MonoBehaviour
{
   [SerializeField] private string selectableTag = "Selectable";
   [SerializeField] private Material highlightMaterial;
   [SerializeField] private Material defaultMaterial;
   private Transform _selection;
   
    // Update is called once per frame
    private void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = defaultMaterial;
            }
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        _selection = null;
       
        if(Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag (selectableTag))
            {
                _selection = selection;
            }
        }
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial;
            }    
        }
    }
}
