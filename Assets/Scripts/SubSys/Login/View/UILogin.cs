﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using ColaFramework;

public class UILogin : UIBase
{
    [AutoInject("cancelBtn")]
    private Button cancelBtn;

    [AutoInject("okBtn")]
    private Button okBtn;

    [AutoInject("logo")]
    private Image logo;

    [AutoInject("usernameDes")]
    private Text userNameText;

    [AutoInject("center")]
    private GameObject centerObj;

    public UILogin(int resId, UILevel uiLevel) : base(resId, uiLevel)
    {
    }

    public override void Close()
    {
        base.Close();
    }

    public override void Create()
    {
        base.Create();
    }

    public override void Destroy()
    {
        base.Destroy();
    }

    public override void OnCreate()
    {
        base.OnCreate();
        AutoInject.Inject(Panel, this);
        var text = this.okBtn.name;
        GameObject okBtn = Panel.FindChildByPath("bottom/okBtn");
        Image titleImage = Panel.GetComponentByPath<Image>("logo");
        CommonHelper.AddBtnMsg(okBtn, (obj) =>
        {
        });
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
    }

    public override void OnShow(bool isShow)
    {
        base.OnShow(isShow);
    }

    public override void Open()
    {
        base.Open();
    }

    public override void UpdateUI(EventData eventData)
    {
        base.UpdateUI(eventData);
    }

    protected override void onClick(string name)
    {
        if ("cancelBtn" == name)
        {
            //GameEventMgr.GetInstance().DispatchEvent("CloseUI", EventType.UIMsg, "UILogin");
        }

        if (name == "okBtn")
        {
            Debug.LogWarning("点击了OK按钮！");
            //TODO: 测试视频下载
            var path = Path.Combine(CommonHelper.GetAssetPath(), "Videos.mp4");
            //var testUrl = @"http://vjs.zencdn.net/v/oceans.mp4";
            var testUrl = @"http://vjs.zencdn.net/v/oceans.mp4" + "?" + DateTime.Now;
            Debug.LogWarning("-------------->视频网络资源地址" + testUrl);
            DownloadMovHelper.Begin(path, testUrl, () =>
            {
                Debug.LogWarning("开始下载。");
            }
            ,
            () =>
            {
                Debug.LogWarning("下载完成。");
            },
            (reason) =>
            {
                Debug.LogWarning("下载失败原因" + reason);
            },
            (progress) =>
            {
                Debug.LogWarning("下载进度" + progress);
            });
        }
        if (name == "bg")
        {
            Debug.LogWarning("点击了bg按钮");
        }
        if (name == "calcelBtn")
        {
            DownloadMovHelper.Stop();
        }
    }

    protected override void onEditEnd(string name, string text)
    {
        if (name == "usernameInput")
        {
            Debug.LogWarning("输入用户名：" + text);
        }
        else if (name == "passwordInput")
        {
            Debug.LogWarning("输入密码：" + text);
        }
    }
}
