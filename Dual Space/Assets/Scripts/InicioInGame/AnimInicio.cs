using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class AnimInicio : MonoBehaviour
{

    [Header("Game Screen")]
    [SerializeField] private RectTransform Set;
    [SerializeField] private RectTransform Ready;
    [SerializeField] private RectTransform Go;
    public Canvas UiManager;

    // Start is called before the first frame update
    void Start()
    {
        Set.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        Ready.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        Go.GetComponent<Image>().color = new Color32(255, 255, 255, 0);

        Sequence TitleAnim = DOTween.Sequence()
             .Append(Set.GetComponent<Image>().DOFade(1f, 1f))
             .Append(Ready.GetComponent<Image>().DOFade(1f, 1f))
             .Append(Go.GetComponent<Image>().DOFade(1f, 1f))
             .Append(Set.GetComponent<Image>().DOFade(0, 1f))
             .Append(Ready.GetComponent<Image>().DOFade(0, 1f))
             .Append(Go.GetComponent<Image>().DOFade(0, 1f));
    }


}


