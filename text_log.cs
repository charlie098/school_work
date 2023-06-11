using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


[System.Serializable]
public class Dialogue
{
    // �������� �� �� �ְ� ���ش�.
    [TextArea]
    public string dialogue;
}

public class text_log : MonoBehaviour
{

    static public int npc_talk_int = 0;
    Boolean justOne = false;
    public TextMeshProUGUI txt_Dialogue;
    public Button button_1;
    //public Button button_2;
    //public Button button_3;
    // [SerializeField] �� �޸� ����Ƽ inspector â���� �ش� ������ ���� �� �� �ִ�.

    static public bool isDialogue = true;

    // ��ȭ�� �󸶳� ���� �Ǿ����� Ȯ��
    private int count = 0;

    static private String[] dialogue; // ��ȭ�� ���� �迭

    private void Awake()
    {
        dialogue = new String[100];
        // ó�� intro ���
        dialogue[0] = "[Senior Worker]\n\nAre you newcommer?";
        dialogue[1] = "[Senior Worker]\n\nThere is your task. Test the game and tell me your impression.";
        // ��ȭ ���� null�� �־ ��ȭ�� �������� �˸���.
        dialogue[2] = "";
        dialogue[3] = "end";
        dialogue[5] = "[���]\n\n������ ���͵帱���?";
        dialogue[6] = "[���]\n\n������ ���͵帱���?";
        dialogue[7] = "[���]\n\n������ ���͵帱���?";

    }
    private void Start()
    {
        button_1.gameObject.SetActive(false);
        //button_2.gameObject.SetActive(false);
        //button_3.gameObject.SetActive(false);

        Debug.Log("dialogue.length = " + dialogue.Length);
        ShowDialogue(0);
    }

    public void ShowDialogue(int count_)
    {
        count = count_;
        NextDialogue();
    }
    public void talk_npc()
    {
        button_1.gameObject.SetActive(true);
        //button_2.gameObject.SetActive(true);
        //button_3.gameObject.SetActive(true);
        count = 2;
        txt_Dialogue.text = dialogue[count];
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count];
        count++;
    }



    void Update()
    {
        if (npc_talk_int == 1 && justOne == false)
        {
            talk_npc();
            justOne = true;
        }
        else if (npc_talk_int == 2)
        {

            button_1.gameObject.SetActive(false);
            //button_2.gameObject.SetActive(false);
            //button_3.gameObject.SetActive(false);
            justOne = false;
        }
        // count �� 12�� ������ ��ȭ �������̶� ���� �д�.
        if (isDialogue && count != 4)
        {
            if (dialogue[count].Equals("end"))
            {
                npc_talk_int = 1;
            }
            //if (OVRInput.GetDown(OVRInput.Button.One))
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (count < dialogue.Length)
                    NextDialogue();
            }
        }
    }


    // Start is called before the first frame update

    // Update is called once per frame


}
