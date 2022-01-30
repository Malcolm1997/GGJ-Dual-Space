using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManagerEndTitle : MonoBehaviour
{
    [Header("Title Screen")]
    [SerializeField] private RectTransform Title;
    [SerializeField] private Button Start_btn;
    [SerializeField] private Button Help_btn;
    [SerializeField] private RectTransform HelpPopUP;
    [SerializeField] private AudioSource ClickBtn;
    [SerializeField] private AudioSource hoverClick;




    void Start()
    {
        HelpPopUP.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Sequence TitleHelpAnim = DOTween.Sequence()
            .Append(HelpPopUP.GetComponent<Image>().DOFade(0, .3f));
        }
    }

    public void btnStart()
    {
        float TitleEndPosY = Title.position.y + 2f;

        ClickBtn.Play();

        Sequence TitleAnim = DOTween.Sequence()
            .Append(Title.GetComponent<Image>().DOFade(0F, .5f))
            .Join(Start_btn.GetComponent<Image>().DOFade(0F, .5f))
            .Join(Help_btn.GetComponent<Image>().DOFade(0F, .5f));
        StartCoroutine(nextInGame());

            
    }

    public void btnHelp()
    {
        ClickBtn.Play();

        Sequence TitleHelpAnim = DOTween.Sequence()
            .Append(HelpPopUP.GetComponent<Image>().DOFade(1f, .3f));
            
    }

    public void btnHover()
    {
        hoverClick.Play();
    }

    IEnumerator nextInGame()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("InGame");
    }

}
