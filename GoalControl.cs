using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalControl : MonoBehaviour
{
    public GameObject Panel;

    // �浹�ߴ°�, ���ߴ°�
    private bool is_collided = false;
    // �ٸ� GameObject�� �浹�ϴ� ���� ��� ȣ��
    void OnCollisionStay(Collision other)
    {
        this.is_collided = true;
    }
    private GUIStyle guiStyle = new GUIStyle(); // font style
    void OnGUI()
    {
        if (is_collided)
        { // �浹������
            GUIStyle guiStyle = new GUIStyle();
            guiStyle.fontSize = 40; // font size
            guiStyle.normal.textColor = Color.white; // font color
            GUI.Label(new Rect(Screen.width / 2, 80, 100, 40), "����!", guiStyle);
            Time.timeScale = 0;
            Panel.gameObject.SetActive(true);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Panel.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
