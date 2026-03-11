using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CmdSystem : MonoBehaviour
{
    [SerializeField] private TMP_InputField cmdfield;
    [SerializeField] private AudioSource typeSound;
    [SerializeField] private GameObject player;
    [SerializeField]private PlayerKeyboeardMoving playerKeyboeardMoving;
    [SerializeField]private GameObject HelpList;
    [SerializeField] private TextMeshProUGUI placeholderCMD;
    [SerializeField]private TextMeshProUGUI cmdArea;
    [SerializeField]private InputField inputField;
    private string cmdtext;

    public void CommandBase()
    {
        cmdtext = cmdfield.text;

        string[] words = cmdtext.Split(' ');

        if (words[0] == "mv")
        {
            if (words[1] == "player")
            {
                if (words[2] == "up")
                {
                    player.transform.position += new Vector3(0, 0.5f, 0);
                }
                if (words[2] == "down")
                {
                    player.transform.position += new Vector3(0, -0.5f, 0);
                }
                if (words[2] == "left")
                {
                    player.transform.position += new Vector3(-0.5f, 0, 0);
                }
                if (words[2] == "right")
                {
                    player.transform.position += new Vector3(0.5f, 0, 0);
                }
            }
            else if (words[1] == "enemy")
            {
                
            }
        }
        if (words[0] == "help")
        {
            HelpList.transform.DOMove(new Vector3(960, 566, 0), 1f);
            placeholderCMD.text = "Введите команду...";
        }

    }
    public void stopMoving()
    {
        playerKeyboeardMoving.enabled = false;
    }
    public void afterCommand()
    {
        cmdArea.text = "";
        playerKeyboeardMoving.enabled = true;
    }
    public void typing()
    {
        typeSound.Play();
    }
}