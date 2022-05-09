using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton;

    private ItemCollect IC;
    // Start is called before the first frame update
    void Start()
    {
        IC = GameObject.Find("Poço").GetComponent<ItemCollect>();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;

        if (IC.scrollbar.value >= 1)
        {
            IC.scrollbar.value = 0;
            IC.Contagem++;
        }
    }
    public void seleciono(int ButtonTipo)
    {
        switch (ButtonTipo)
        {
            case 0:
                var colors = buton[0].GetComponent<Button>().colors;
                colors.normalColor = Color.green;
                buton[0].GetComponent<Button>().colors = colors;
                break;
            case 1:
                var colors1 = buton[1].GetComponent<Button>().colors;
                colors1.normalColor = Color.green;
                buton[1].GetComponent<Button>().colors = colors1;
                break;
            case 2:
                var colors2 = buton[2].GetComponent<Button>().colors;
                colors2.normalColor = Color.green;
                buton[2].GetComponent<Button>().colors = colors2;
                break;
            case 3:
                var colors3 = buton[3].GetComponent<Button>().colors;
                colors3.normalColor = Color.green;
                buton[3].GetComponent<Button>().colors = colors3;
                buton[4].SetActive(true);
                break;
        }
    }
    public void End()
    {
        if (IC.Contagem >= 260)
        {
            buton[5].SetActive(true);
        }
    }
}
