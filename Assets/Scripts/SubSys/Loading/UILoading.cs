﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColaFramework;

public class UILoading :UIBase
{
    private Text progressText;
    private RawImage background;

    public UILoading(int resId, UILevel uiLevel) : base(resId, uiLevel)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();
        progressText = Panel.GetComponentByPath<Text>("progress_text");
        background = Panel.GetComponentByPath<RawImage>("bg");
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
        progressText = null;
        background = null;
    }
}
