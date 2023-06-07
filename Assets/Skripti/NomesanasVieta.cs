using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;

    void Start()
    {
        //izsledz visas zvaigznes sakuma
        objektuSkripts.zvaigzne1.SetActive(false);
        objektuSkripts.zvaigzne2.SetActive(false);
        objektuSkripts.zvaigzne3.SetActive(false);
    }

    void Update()
    {
        if (objektuSkripts.laiks <= 90)
        {
              objektuSkripts.zvaigzne1.SetActive(true);
              objektuSkripts.zvaigzne2.SetActive(true);
              objektuSkripts.zvaigzne3.SetActive(true);
        }
        else if (objektuSkripts.laiks > 150 && objektuSkripts.laiks <= 110)
        {
              objektuSkripts.zvaigzne1.SetActive(true);
              objektuSkripts.zvaigzne2.SetActive(true);
              objektuSkripts.zvaigzne3.SetActive(false);
        }
        else if (objektuSkripts.laiks > 210)
        {
              objektuSkripts.zvaigzne1.SetActive(true);
              objektuSkripts.zvaigzne2.SetActive(false);
              objektuSkripts.zvaigzne3.SetActive(false);
        }

    }

    public void OnDrop(PointerEventData eventData)
	{
		if(eventData.pointerDrag!= null)
		{
			if(eventData.pointerDrag.tag.Equals(tag)) {
				vietasZRot = GetComponent<RectTransform>().eulerAngles.z;

				velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

				vietasIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

                velkObjIzm = GetComponent<RectTransform>().localScale;

				xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

				if((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba<=360)) && (xIzmeruStarp<= 0.1 && yIzmeruStarp <=0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale= GetComponent<RectTransform>().localScale;

					switch(eventData.pointerDrag.tag)
					{
						case "atkritumi":
							objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                        break;

                        case "medicina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "buss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "b2":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "cement":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "e46":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "e61":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "esk":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "police":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "trak1":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                        case "trak5":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[11]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;
                        case "uguns":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[12]);
                            objektuSkripts.masinasDone++; //pieskaita klat ka pabeigta velviena masina
                            break;

                    }
                }

            } else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;

                    case "medicina":
                        objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;

                    case "b2":
                        objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;

                    case "cement":
                        objektuSkripts.cementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cemMKoord;
                        break;

                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;

                    case "e61":
                        objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord;
                        break;

                    case "esk":
                        objektuSkripts.eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.eskKoord;
                        break;

                    case "police":
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.polKoord;
                        break;

                    case "trak1":
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.trak1Koord;
                        break;

                    case "trak5":
                        objektuSkripts.traktors2.GetComponent<RectTransform>().localPosition = objektuSkripts.trak2Koord;
                        break;

                    case "uguns":
                        objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsKoord;
                        break;

                }

            }

		}

        if (objektuSkripts.masinasDone == 11) //salidzina pabeigtas masinas ar masinu skaitu
        {
     
            if (objektuSkripts.masinasDone == 11) //sa
                objektuSkripts.laiksOn = false; //izsledz laiku
            objektuSkripts.beigas.SetActive(true); //parada izkartni

            objektuSkripts.laikaParadisana.GetComponent<Text>().enabled = true;
            objektuSkripts.laikaParadisana.text = objektuSkripts.laiks.ToString();
        }
    }
}
