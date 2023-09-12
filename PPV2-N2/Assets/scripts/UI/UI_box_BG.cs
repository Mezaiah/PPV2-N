using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_box_BG : UI_box
{
    private Sprite BackGround;
    public Color BackGroundColor;
    // Start is called before the first frame update
    void Start()
    {
        BackGround = GetComponent<Sprite>();
        BackGroundColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
