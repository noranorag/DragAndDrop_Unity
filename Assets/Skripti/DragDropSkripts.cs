using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	//Uzglabas noradi uz objekti skriptu
	public Objekti objektuSkripts;
	//Uzglabās norādi uz katra objekta CanvasGroup
	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;


    void Start()
    {
		kanvasGrupa= GetComponent<CanvasGroup>();
		velkObjRectTransf= GetComponent<RectTransform>();

    }

    public void OnBeginDrag(PointerEventData eventData)
	{

	}

	public void OnEndDrag(PointerEventData eventData)
	{

	}

	public void OnDrag(PointerEventData eventData)
	{

	}


	
	
}
