﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class next_btn : MonoBehaviour {
    public GameObject imageObj;
    public Image myimage;
    int count = 0;
    
	// Use this for initialization
	void Start () {
        imageObj = GameObject.FindGameObjectWithTag("Finish");
        myimage = imageObj.GetComponent<Image>();

        transform.localPosition = new Vector2(520, -375);
        transform.localScale = new Vector2(1.5f, 1.5f);
    }
    
    public void onclickbutton()
    {
        count++;
        switch (count)
        {
            case 1:
            myimage.sprite = Resources.Load<Sprite>("howto/gameguide_2") as Sprite;
            break;
            case 2:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_3") as Sprite;
                break;
            case 3:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_4") as Sprite;
                break;
            case 4:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_5") as Sprite;
                break;
        }
    }
    
}
