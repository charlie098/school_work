using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


[System.Serializable]
public class Dialogue
{
    // 여러줄을 쓸 수 있게 해준다.
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
    // [SerializeField] 을 달면 유니티 inspector 창에서 해당 변수를 조작 할 수 있다.

    static public bool isDialogue = true;

    // 대화가 얼마나 진행 되었는지 확인
    private int count = 0;

    static private String[] dialogue; // 대화가 들어가는 배열

    private void Awake()
    {
        dialogue = new String[100];
        // 처음 intro 대사
        dialogue[0] = "[Senior Worker]\n\nAre you newcommer?";
        dialogue[1] = "[Senior Worker]\n\nThere is your task. Test the game and tell me your impression.";
        // 대화 끝에 null을 넣어서 대화가 끝났음을 알린다.
        dialogue[2] = "";
        dialogue[3] = "end";
        dialogue[5] = "[농부]\n\n무었을 도와드릴까요?";
        dialogue[6] = "[농부]\n\n무었을 도와드릴까요?";
        dialogue[7] = "[농부]\n\n무었을 도와드릴까요?";

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
        // count 가 12면 선택지 대화 진행중이라 막아 둔다.
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
