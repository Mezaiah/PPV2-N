using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_box_Header : UI_box_BG
{
    // Start is called before the first frame update
    private Sprite HBackGround;
    public Color HBackGroundColor;
    // Start is called before the first frame update
    void Start()
    {
        HBackGround = GetComponent<Sprite>();
        //HBackGroundColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
