using TMPro;
using UnityEngine;

public class Basment_monologue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textgui;
    [SerializeField] private GameObject diawin;
    [SerializeField] private PlayerKeyboeardMoving playerKeyboeardMoving;
    [SerializeField] private Basment_monologue basment_Monologue;
    [SerializeField] private GameObject playerDia;
    private bool blocknext = false;
    private int diapos = 0;
    
    void Start()
    {
        playerDia.SetActive(true);
        textgui.text = "*звук зевания";
        diapos = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 1)
        {
            blocknext = true;
            textgui.text = "- Где я?";
            Invoke("unblocknext", 0.1f);
            diapos = 2;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 2)
        {
            blocknext = true;
            textgui.text = "- Почему я в подвале?";
            Invoke("unblocknext", 0.1f);
            diapos = 3;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 3)
        {
            blocknext = true;
            textgui.text = "- Надо выбиратся отсюда.";
            Invoke("unblocknext", 0.1f);
            diapos = 4;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 4)
        {
            playerDia.SetActive(false);
            diawin.SetActive(false);
            playerKeyboeardMoving.enabled = true;
            Destroy(basment_Monologue);
        }
    }
    private void unblocknext()
    {
        blocknext = false;
    }
}
