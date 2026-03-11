using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class cmdcutscene : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject MysteryMan;
    [SerializeField] private GameObject diawin;
    [SerializeField] private GameObject MysteryManDia;
    [SerializeField] private PlayerKeyboeardMoving playerKeyboeardMoving;
    [SerializeField] private TextMeshProUGUI textgui;
    [SerializeField] private GameObject PlayerDia;
    [SerializeField] private AudioSource MMDisappearanceSound;
    [SerializeField] private GameObject CmdField;
    [SerializeField] private TextMeshProUGUI placeholderCMD;
    [SerializeField]private BoxCollider2D trigger;
    private bool blocknext = false;
    private int diapos = 0;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(trigger);
        playerKeyboeardMoving.enabled = false;
        player.transform.DOMove(new Vector3(0, 11.32f, 0), 1.5f);
        Invoke("MysteryManApperence", 2f);
    }

    private void MysteryManApperence()
    {
        MysteryMan.transform.DOMove(new Vector3(-3.04f, 11.4f, 0), 5f);
        Invoke("walk2player", 6f);
    }
    private void walk2player()
    {
        MysteryMan.transform.DOMove(new Vector3(-1.172f, 11.4f, 0), 3f);
        Invoke("DialogueApperene", 5f);
    }
    private void DialogueApperene()
    {
        diawin.SetActive(true);
        MysteryManDia.SetActive(true);
        textgui.text = "- Hello.";
        diapos = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 1)
        {
            MysteryManDia.SetActive(false);
            PlayerDia.SetActive(true);
            blocknext = true;
            textgui.text = "- Ай донт андерстэнд.";
            Invoke("unblocknext", 0.1f);
            diapos = 2;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 2)
        {
            MysteryManDia.SetActive(true);
            PlayerDia.SetActive(false);
            blocknext = true;
            textgui.text = "- А ты чё по нашему разговариваешь?";
            Invoke("unblocknext", 0.1f);
            diapos = 3;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 3)
        {
            MysteryManDia.SetActive(false);
            PlayerDia.SetActive(true);
            blocknext = true;
            textgui.text = "- Да.";
            Invoke("unblocknext", 0.1f);
            diapos = 4;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 4)
        {
            MysteryManDia.SetActive(true);
            PlayerDia.SetActive(false);
            blocknext = true;
            textgui.text = "- Ну тогда, друг мой...";
            Invoke("unblocknext", 0.1f);
            diapos = 5;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 5)
        {
            blocknext = true;
            textgui.text = "- Не хотел бы ты, да именно ТЫ...";
            Invoke("unblocknext", 0.1f);
            diapos = 6;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 6)
        {
            blocknext = true;
            textgui.text = "- Получить давно утеренную...";
            Invoke("unblocknext", 0.1f);
            diapos = 7;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 7)
        {
            blocknext = true;
            textgui.text = "- Самую могущественную силу...";
            Invoke("unblocknext", 0.1f);
            diapos = 8;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 8)
        {
            blocknext = true;
            textgui.text = "- И это...";
            Invoke("unblocknext", 0.1f);
            diapos = 9;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 9)
        {
            blocknext = true;
            textgui.text = "- КОМАНДНАЯ СТРОКА!!!";
            Invoke("unblocknext", 0.1f);
            diapos = 10;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 10)
        {
            MysteryManDia.SetActive(false);
            PlayerDia.SetActive(true);
            blocknext = true;
            textgui.text = "- ДА НУ?!";
            Invoke("unblocknext", 0.1f);
            diapos = 11;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 11)
        {
            MysteryManDia.SetActive(false);
            PlayerDia.SetActive(true);
            blocknext = true;
            textgui.text = "- ЭТО ТА САМАЯ СТРОКА!?";
            Invoke("unblocknext", 0.1f);
            diapos = 12;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 12)
        {
            MysteryManDia.SetActive(true);
            PlayerDia.SetActive(false);
            blocknext = true;
            textgui.text = "- аГА)";
            Invoke("unblocknext", 0.1f);
            diapos = 13;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 13)
        {
            MysteryManDia.SetActive(false);
            PlayerDia.SetActive(true);
            blocknext = true;
            textgui.text = "- Ну давай, давай.";
            Invoke("unblocknext", 0.1f);
            diapos = 14;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 14)
        {
            MysteryManDia.SetActive(true);
            PlayerDia.SetActive(false);
            blocknext = true;
            textgui.text = "- Получи же силу свою.";
            Invoke("unblocknext", 0.1f);
            diapos = 15;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 15)
        {
            MysteryMan.SetActive(false);
            MysteryManDia.SetActive(false);
            diawin.SetActive(false);
            blocknext = true;
            MMDisappearanceSound.Play();
            CmdField.SetActive(true);
            Invoke("unblocknext", 0.1f);
            diapos = 16;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 16)
        {
            diawin.SetActive(true);
            PlayerDia.SetActive(true);
            blocknext = true;
            textgui.text = "- Куда он делся?";
            Invoke("unblocknext", 0.1f);
            diapos = 17;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 17)
        {
            blocknext = true;
            textgui.text = "- Ай да ладно,";
            Invoke("unblocknext", 0.1f);
            diapos = 18;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 18)
        {
            blocknext = true;
            textgui.text = "- У меня же есть самая сильная вещь в этом мире!";
            Invoke("unblocknext", 0.1f);
            diapos = 19;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 19)
        {
            blocknext = true;
            textgui.text = "- Только разобратся как ей пользоватся осталось.";
            Invoke("unblocknext", 0.1f);
            diapos = 20;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && blocknext == false && diapos == 20)
        {
            placeholderCMD.text = "Введи help";
            PlayerDia.SetActive(false);
            diawin.SetActive(false);
            playerKeyboeardMoving.enabled = true;
        }

    }

    private void unblocknext()
    {
        blocknext = false;
    }
}
