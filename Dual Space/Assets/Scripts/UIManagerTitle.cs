using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class UIManagerTitle : MonoBehaviour
{
    [Header("Title Screen")]
    [SerializeField] private AudioSource TitleMusic;
    [SerializeField] private RectTransform Title;
    [SerializeField] private Button Start_btn;
    [SerializeField] private Button Help_btn;

    // Start is called before the first frame update
    void Start()
    {
        TitleInAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TitleInAnimation() 
    {
        TitleMusic.Play();

        float TitleEndPosY = Title.position.y;
        Title.localPosition = new Vector3(0f, -TitleEndPosY * 2f, 0f);
        Start_btn.transform.localScale = new Vector3(.5f, .5f, .5f);
        Start_btn.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        Help_btn.transform.localScale = new Vector3(.5f, .5f, .5f);
        Help_btn.GetComponent<Image>().color = new Color32(255, 255, 255, 0);

        Sequence TitleAnim = DOTween.Sequence()
            .Append(Title.DOMoveY(TitleEndPosY, 1f))
            .Append(Start_btn.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), .3f))
            .Join(Start_btn.GetComponent<Image>().DOFade(1f, .3f))
            .Append(Start_btn.transform.DOScale(Vector3.one, .3f))            
            .Join(Help_btn.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), .3f))
            .Join(Help_btn.GetComponent<Image>().DOFade(1f, .3f))
            .Append(Help_btn.transform.DOScale(Vector3.one, .3f));            
    }
}
