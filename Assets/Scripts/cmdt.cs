using TMPro;
using UnityEngine;

public class cmdt : MonoBehaviour
{
    [SerializeField] private TMP_InputField cmdfield;
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerKeyboeardMoving playerKeyboeardMoving;
    private string cmdtext;

    public void moving()
    {
        cmdtext = cmdfield.text;
        if (cmdtext == "mv player +1up")
        {
            player.transform.position += new Vector3(0, 0.5f, 0);
        }
        if (cmdtext == "mv player +1down")
        {
            player.transform.position += new Vector3(0, -0.5f, 0);
        }
        if (cmdtext == "mv player +1left")
        {
            player.transform.position += new Vector3(-0.5f, 0, 0);
        }
        if (cmdtext == "mv player +1right")
        {
            player.transform.position += new Vector3(0.5f, 0, 0);
        }
    }

    public void stopmov()
    {
        playerKeyboeardMoving.enabled = false;
    }

    public void contunmov()
    {
        playerKeyboeardMoving.enabled = true;
    }
}
