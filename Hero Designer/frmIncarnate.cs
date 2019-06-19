﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmIncarnate
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\Xbass\Desktop\Hero Designer.exe

using Base.Data_Classes;
using Base.Display;
using Base.Master_Classes;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using midsControls;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  [DesignerGenerated]
  public class frmIncarnate : Form
  {
    [AccessedThroughProperty("alphaBtn")]
    private ImageButton _alphaBtn;
    [AccessedThroughProperty("destinyBtn")]
    private ImageButton _destinyBtn;
    [AccessedThroughProperty("GenesisButton")]
    private ImageButton _GenesisButton;
    [AccessedThroughProperty("hybridBtn")]
    private ImageButton _hybridBtn;
    [AccessedThroughProperty("ibClose")]
    private ImageButton _ibClose;
    [AccessedThroughProperty("interfaceBtn")]
    private ImageButton _interfaceBtn;
    [AccessedThroughProperty("judgementBtn")]
    private ImageButton _judgementBtn;
    [AccessedThroughProperty("lblLock")]
    private Label _lblLock;
    [AccessedThroughProperty("llLeft")]
    private ListLabelV2 _llLeft;
    [AccessedThroughProperty("llRight")]
    private ListLabelV2 _llRight;
    [AccessedThroughProperty("loreBtn")]
    private ImageButton _loreBtn;
    [AccessedThroughProperty("OmegaButton")]
    private ImageButton _OmegaButton;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("PopInfo")]
    private ctlPopUp _PopInfo;
    [AccessedThroughProperty("StanceButton")]
    private ImageButton _StanceButton;
    [AccessedThroughProperty("VitaeButton")]
    private ImageButton _VitaeButton;
    [AccessedThroughProperty("VScrollBar1")]
    private VScrollBar _VScrollBar1;
    private ImageButton[] buttonArray;
    private IContainer components;
    protected bool Locked;
    protected frmMain myParent;
    public IPower[] myPowers;
    internal frmIncarnate.CustomPanel Panel2;

    internal virtual ImageButton alphaBtn
    {
      get
      {
        return this._alphaBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.alphaBtn_ButtonClicked);
        if (this._alphaBtn != null)
          this._alphaBtn.ButtonClicked -= clickedEventHandler;
        this._alphaBtn = value;
        if (this._alphaBtn == null)
          return;
        this._alphaBtn.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton destinyBtn
    {
      get
      {
        return this._destinyBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.destinyBtn_ButtonClicked);
        if (this._destinyBtn != null)
          this._destinyBtn.ButtonClicked -= clickedEventHandler;
        this._destinyBtn = value;
        if (this._destinyBtn == null)
          return;
        this._destinyBtn.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton GenesisButton
    {
      get
      {
        return this._GenesisButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.GenesisButton_ButtonClicked);
        if (this._GenesisButton != null)
          this._GenesisButton.ButtonClicked -= clickedEventHandler;
        this._GenesisButton = value;
        if (this._GenesisButton == null)
          return;
        this._GenesisButton.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton hybridBtn
    {
      get
      {
        return this._hybridBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.hybridBtn_ButtonClicked);
        if (this._hybridBtn != null)
          this._hybridBtn.ButtonClicked -= clickedEventHandler;
        this._hybridBtn = value;
        if (this._hybridBtn == null)
          return;
        this._hybridBtn.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton ibClose
    {
      get
      {
        return this._ibClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibClose_ButtonClicked);
        if (this._ibClose != null)
          this._ibClose.ButtonClicked -= clickedEventHandler;
        this._ibClose = value;
        if (this._ibClose == null)
          return;
        this._ibClose.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton interfaceBtn
    {
      get
      {
        return this._interfaceBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.interfaceBtn_ButtonClicked);
        if (this._interfaceBtn != null)
          this._interfaceBtn.ButtonClicked -= clickedEventHandler;
        this._interfaceBtn = value;
        if (this._interfaceBtn == null)
          return;
        this._interfaceBtn.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton judgementBtn
    {
      get
      {
        return this._judgementBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.judgementBtn_ButtonClicked);
        if (this._judgementBtn != null)
          this._judgementBtn.ButtonClicked -= clickedEventHandler;
        this._judgementBtn = value;
        if (this._judgementBtn == null)
          return;
        this._judgementBtn.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual Label lblLock
    {
      get
      {
        return this._lblLock;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblLock_Click);
        if (this._lblLock != null)
          this._lblLock.Click -= eventHandler;
        this._lblLock = value;
        if (this._lblLock == null)
          return;
        this._lblLock.Click += eventHandler;
      }
    }

    internal virtual ListLabelV2 llLeft
    {
      get
      {
        return this._llLeft;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ListLabelV2.ItemClickEventHandler clickEventHandler = new ListLabelV2.ItemClickEventHandler(this.llLeft_ItemClick);
        EventHandler eventHandler = new EventHandler(this.llLeft_MouseEnter);
        ListLabelV2.ItemHoverEventHandler hoverEventHandler = new ListLabelV2.ItemHoverEventHandler(this.llLeft_ItemHover);
        if (this._llLeft != null)
        {
          this._llLeft.ItemClick -= clickEventHandler;
          this._llLeft.MouseEnter -= eventHandler;
          this._llLeft.ItemHover -= hoverEventHandler;
        }
        this._llLeft = value;
        if (this._llLeft == null)
          return;
        this._llLeft.ItemClick += clickEventHandler;
        this._llLeft.MouseEnter += eventHandler;
        this._llLeft.ItemHover += hoverEventHandler;
      }
    }

    internal virtual ListLabelV2 llRight
    {
      get
      {
        return this._llRight;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.llRight_MouseEnter);
        ListLabelV2.ItemHoverEventHandler hoverEventHandler = new ListLabelV2.ItemHoverEventHandler(this.llRight_ItemHover);
        ListLabelV2.ItemClickEventHandler clickEventHandler = new ListLabelV2.ItemClickEventHandler(this.llRight_ItemClick);
        if (this._llRight != null)
        {
          this._llRight.MouseEnter -= eventHandler;
          this._llRight.ItemHover -= hoverEventHandler;
          this._llRight.ItemClick -= clickEventHandler;
        }
        this._llRight = value;
        if (this._llRight == null)
          return;
        this._llRight.MouseEnter += eventHandler;
        this._llRight.ItemHover += hoverEventHandler;
        this._llRight.ItemClick += clickEventHandler;
      }
    }

    internal virtual ImageButton loreBtn
    {
      get
      {
        return this._loreBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.loreBtn_ButtonClicked);
        if (this._loreBtn != null)
          this._loreBtn.ButtonClicked -= clickedEventHandler;
        this._loreBtn = value;
        if (this._loreBtn == null)
          return;
        this._loreBtn.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton OmegaButton
    {
      get
      {
        return this._OmegaButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.OmegaButton_ButtonClicked);
        if (this._OmegaButton != null)
          this._OmegaButton.ButtonClicked -= clickedEventHandler;
        this._OmegaButton = value;
        if (this._OmegaButton == null)
          return;
        this._OmegaButton.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
      }
    }

    internal virtual ctlPopUp PopInfo
    {
      get
      {
        return this._PopInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PopInfo_MouseWheel);
        EventHandler eventHandler = new EventHandler(this.PopInfo_MouseEnter);
        if (this._PopInfo != null)
        {
          this._PopInfo.MouseWheel -= mouseEventHandler;
          this._PopInfo.MouseEnter -= eventHandler;
        }
        this._PopInfo = value;
        if (this._PopInfo == null)
          return;
        this._PopInfo.MouseWheel += mouseEventHandler;
        this._PopInfo.MouseEnter += eventHandler;
      }
    }

    internal virtual ImageButton StanceButton
    {
      get
      {
        return this._StanceButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.StanceButton_ButtonClicked);
        if (this._StanceButton != null)
          this._StanceButton.ButtonClicked -= clickedEventHandler;
        this._StanceButton = value;
        if (this._StanceButton == null)
          return;
        this._StanceButton.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual ImageButton VitaeButton
    {
      get
      {
        return this._VitaeButton;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.VitaeButton_ButtonClicked);
        if (this._VitaeButton != null)
          this._VitaeButton.ButtonClicked -= clickedEventHandler;
        this._VitaeButton = value;
        if (this._VitaeButton == null)
          return;
        this._VitaeButton.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual VScrollBar VScrollBar1
    {
      get
      {
        return this._VScrollBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.VScrollBar1_Scroll);
        if (this._VScrollBar1 != null)
          this._VScrollBar1.Scroll -= scrollEventHandler;
        this._VScrollBar1 = value;
        if (this._VScrollBar1 == null)
          return;
        this._VScrollBar1.Scroll += scrollEventHandler;
      }
    }

    public frmIncarnate(ref frmMain iParent)
    {
      this.Load += new EventHandler(this.frmIncarnate_Load);
      this.myPowers = new IPower[0];
      this.Locked = false;
      this.buttonArray = new ImageButton[10];
      this.InitializeComponent();
      this.myParent = iParent;
      this.myPowers = DatabaseAPI.GetPowersetByName("Alpha", Enums.ePowerSetType.Incarnate).Powers;
    }

    private void alphaBtn_ButtonClicked()
    {
      ImageButton alphaBtn = this.alphaBtn;
      this.SetPowerSet("Alpha", ref alphaBtn);
      this.alphaBtn = alphaBtn;
    }

    private void ChangedScrollFrameContents()
    {
      this.VScrollBar1.Value = 0;
      this.VScrollBar1.Maximum = (int) Math.Round((double) this.PopInfo.lHeight * ((double) this.VScrollBar1.LargeChange / (double) this.Panel1.Height));
      this.VScrollBar1_Scroll((object) this.VScrollBar1, new ScrollEventArgs(ScrollEventType.EndScroll, 0));
    }

    private void destinyBtn_ButtonClicked()
    {
      ImageButton destinyBtn = this.destinyBtn;
      this.SetPowerSet("Destiny", ref destinyBtn);
      this.destinyBtn = destinyBtn;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    public void FillLists()
    {
      this.llLeft.SuspendRedraw = true;
      this.llRight.SuspendRedraw = true;
      this.llLeft.ClearItems();
      this.llRight.ClearItems();
      int[] keys = new int[this.myPowers.Length - 1 + 1];
      if (this.myPowers.Length < 2)
      {
        int num = this.myPowers.Length - 1;
        for (int index = 0; index <= num; ++index)
          keys[index] = this.myPowers[index].StaticIndex;
      }
      else if (this.myPowers[0].DisplayLocation != this.myPowers[1].DisplayLocation)
      {
        int num = this.myPowers.Length - 1;
        for (int index = 0; index <= num; ++index)
          keys[index] = this.myPowers[index].DisplayLocation;
      }
      else
      {
        int num = this.myPowers.Length - 1;
        for (int index = 0; index <= num; ++index)
          keys[index] = this.myPowers[index].StaticIndex;
      }
      Array.Sort<int, IPower>(keys, this.myPowers);
      int num1 = this.myPowers.Length - 1;
      for (int index = 0; index <= num1; ++index)
      {
        ListLabelV2.LLItemState iState = !MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[index]) ? (!(this.myPowers[index].DisplayName == "Nothing") ? ListLabelV2.LLItemState.Enabled : ListLabelV2.LLItemState.Disabled) : ListLabelV2.LLItemState.Selected;
        ListLabelV2.ListLabelItemV2 iItem = !MidsContext.Config.RtFont.PairedBold ? new ListLabelV2.ListLabelItemV2(this.myPowers[index].DisplayName, iState, -1, -1, -1, "", ListLabelV2.LLFontFlags.Normal, ListLabelV2.LLTextAlign.Left) : new ListLabelV2.ListLabelItemV2(this.myPowers[index].DisplayName, iState, -1, -1, -1, "", ListLabelV2.LLFontFlags.Bold, ListLabelV2.LLTextAlign.Left);
        if ((double) index >= (double) this.myPowers.Length / 2.0)
          this.llRight.AddItem(iItem);
        else
          this.llLeft.AddItem(iItem);
      }
      this.llLeft.SuspendRedraw = false;
      this.llRight.SuspendRedraw = false;
      this.llLeft.Refresh();
      this.llRight.Refresh();
    }

    private void frmIncarnate_Load(object sender, EventArgs e)
    {
      this.buttonArray[0] = this.alphaBtn;
      this.buttonArray[1] = this.destinyBtn;
      this.buttonArray[2] = this.hybridBtn;
      this.buttonArray[3] = this.interfaceBtn;
      this.buttonArray[4] = this.judgementBtn;
      this.buttonArray[5] = this.loreBtn;
      this.buttonArray[6] = this.GenesisButton;
      this.buttonArray[7] = this.StanceButton;
      this.buttonArray[8] = this.VitaeButton;
      this.buttonArray[9] = this.OmegaButton;
      foreach (ImageButton button in this.buttonArray)
      {
        button.IA = this.myParent.Drawing.pImageAttributes;
        button.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
        button.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
      }
      this.BackColor = this.myParent.BackColor;
      this.PopInfo.ForeColor = this.BackColor;
      ListLabelV2 llLeft = this.llLeft;
      this.UpdateLLColours(ref llLeft);
      this.llLeft = llLeft;
      ListLabelV2 llRight = this.llRight;
      this.UpdateLLColours(ref llRight);
      this.llRight = llRight;
      this.ibClose.IA = this.myParent.Drawing.pImageAttributes;
      this.ibClose.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
      this.ibClose.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
      PopUp.PopupData iPopup = new PopUp.PopupData();
      int index = iPopup.Add((PopUp.Section) null);
      iPopup.Sections[index].Add("Click powers to enable/disable them.", PopUp.Colors.Title, 1f, FontStyle.Bold, 0);
      iPopup.Sections[index].Add("Powers in gray (or your custom 'power disabled' color) cannot be included in your stats.", PopUp.Colors.Text, 0.9f, FontStyle.Bold, 0);
      this.PopInfo.SetPopup(iPopup);
      this.ChangedScrollFrameContents();
      this.FillLists();
    }

    private void GenesisButton_ButtonClicked()
    {
      ImageButton genesisButton = this.GenesisButton;
      this.SetPowerSet("Genesis", ref genesisButton);
      this.GenesisButton = genesisButton;
    }

    private void hybridBtn_ButtonClicked()
    {
      ImageButton hybridBtn = this.hybridBtn;
      this.SetPowerSet("Hybrid", ref hybridBtn);
      this.hybridBtn = hybridBtn;
    }

    private void ibClose_ButtonClicked()
    {
      this.Close();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmIncarnate));
      this.Panel1 = new Panel();
      this.VScrollBar1 = new VScrollBar();
      this.PopInfo = new ctlPopUp();
      this.lblLock = new Label();
      this.Panel2 = new frmIncarnate.CustomPanel();
      this.llRight = new ListLabelV2();
      this.llLeft = new ListLabelV2();
      this.OmegaButton = new ImageButton();
      this.VitaeButton = new ImageButton();
      this.StanceButton = new ImageButton();
      this.GenesisButton = new ImageButton();
      this.hybridBtn = new ImageButton();
      this.destinyBtn = new ImageButton();
      this.loreBtn = new ImageButton();
      this.interfaceBtn = new ImageButton();
      this.judgementBtn = new ImageButton();
      this.alphaBtn = new ImageButton();
      this.ibClose = new ImageButton();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.Panel1.BorderStyle = BorderStyle.Fixed3D;
      this.Panel1.Controls.Add((Control) this.VScrollBar1);
      this.Panel1.Controls.Add((Control) this.PopInfo);
      Point point = new Point(12, 309);
      this.Panel1.Location = point;
      this.Panel1.Name = "Panel1";
      Size size = new Size(440, 161);
      this.Panel1.Size = size;
      this.Panel1.TabIndex = 35;
      point = new Point(419, -2);
      this.VScrollBar1.Location = point;
      this.VScrollBar1.Name = "VScrollBar1";
      size = new Size(17, 159);
      this.VScrollBar1.Size = size;
      this.VScrollBar1.TabIndex = 10;
      this.PopInfo.BXHeight = 1024;
      this.PopInfo.ColumnPosition = 0.5f;
      this.PopInfo.ColumnRight = false;
      this.PopInfo.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Pixel, (byte) 0);
      this.PopInfo.ForeColor = Color.FromArgb(0, 0, 32);
      this.PopInfo.InternalPadding = 3;
      point = new Point(0, 0);
      this.PopInfo.Location = point;
      this.PopInfo.Name = "PopInfo";
      this.PopInfo.ScrollY = 0.0f;
      this.PopInfo.SectionPadding = 8;
      size = new Size(416, 200);
      this.PopInfo.Size = size;
      this.PopInfo.TabIndex = 9;
      this.lblLock.BackColor = Color.Red;
      this.lblLock.BorderStyle = BorderStyle.FixedSingle;
      this.lblLock.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      this.lblLock.ForeColor = Color.White;
      point = new Point(12, 473);
      this.lblLock.Location = point;
      this.lblLock.Name = "lblLock";
      size = new Size(56, 20);
      this.lblLock.Size = size;
      this.lblLock.TabIndex = 69;
      this.lblLock.Text = "[Unlock]";
      this.lblLock.TextAlign = ContentAlignment.MiddleCenter;
      this.lblLock.Visible = false;
      this.Panel2.AutoScroll = true;
      this.Panel2.BorderStyle = BorderStyle.Fixed3D;
      this.Panel2.Controls.Add((Control) this.llRight);
      this.Panel2.Controls.Add((Control) this.llLeft);
      point = new Point(12, 96);
      this.Panel2.Location = point;
      this.Panel2.Name = "Panel2";
      size = new Size(440, 207);
      this.Panel2.Size = size;
      this.Panel2.TabIndex = 125;
      this.Panel2.TabStop = true;
      this.llRight.AutoSize = true;
      this.llRight.Expandable = true;
      this.llRight.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
      this.llRight.HighVis = true;
      this.llRight.HoverColor = Color.WhiteSmoke;
      point = new Point(218, 0);
      this.llRight.Location = point;
      this.llRight.MaxHeight = 900;
      this.llRight.Name = "llRight";
      this.llRight.PaddingX = 2;
      this.llRight.PaddingY = 2;
      this.llRight.Scrollable = false;
      this.llRight.ScrollBarColor = Color.Red;
      this.llRight.ScrollBarWidth = 11;
      this.llRight.ScrollButtonColor = Color.FromArgb(192, 0, 0);
      size = new Size(198, 414);
      this.llRight.Size = size;
      size = new Size(198, 140);
      this.llRight.SizeNormal = size;
      this.llRight.SuspendRedraw = false;
      this.llRight.TabIndex = 109;
      this.llLeft.AutoSize = true;
      this.llLeft.Expandable = true;
      this.llLeft.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
      this.llLeft.HighVis = true;
      this.llLeft.HoverColor = Color.WhiteSmoke;
      point = new Point(0, 0);
      this.llLeft.Location = point;
      this.llLeft.MaxHeight = 900;
      this.llLeft.Name = "llLeft";
      this.llLeft.PaddingX = 2;
      this.llLeft.PaddingY = 2;
      this.llLeft.Scrollable = false;
      this.llLeft.ScrollBarColor = Color.Red;
      this.llLeft.ScrollBarWidth = 11;
      this.llLeft.ScrollButtonColor = Color.FromArgb(192, 0, 0);
      size = new Size(218, 414);
      this.llLeft.Size = size;
      size = new Size(218, 140);
      this.llLeft.SizeNormal = size;
      this.llLeft.SuspendRedraw = false;
      this.llLeft.TabIndex = 108;
      this.OmegaButton.Checked = false;
      this.OmegaButton.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.OmegaButton.KnockoutLocationPoint = point;
      point = new Point(236, 68);
      this.OmegaButton.Location = point;
      this.OmegaButton.Name = "OmegaButton";
      size = new Size(105, 22);
      this.OmegaButton.Size = size;
      this.OmegaButton.TabIndex = 124;
      this.OmegaButton.TextOff = "Omega";
      this.OmegaButton.TextOn = "Omega";
      this.OmegaButton.Toggle = true;
      this.VitaeButton.Checked = false;
      this.VitaeButton.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.VitaeButton.KnockoutLocationPoint = point;
      point = new Point(125, 68);
      this.VitaeButton.Location = point;
      this.VitaeButton.Name = "VitaeButton";
      size = new Size(105, 22);
      this.VitaeButton.Size = size;
      this.VitaeButton.TabIndex = 123;
      this.VitaeButton.TextOff = "Vitae";
      this.VitaeButton.TextOn = "Vitae";
      this.VitaeButton.Toggle = true;
      this.StanceButton.Checked = false;
      this.StanceButton.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.StanceButton.KnockoutLocationPoint = point;
      point = new Point(347, 40);
      this.StanceButton.Location = point;
      this.StanceButton.Name = "StanceButton";
      size = new Size(105, 22);
      this.StanceButton.Size = size;
      this.StanceButton.TabIndex = 121;
      this.StanceButton.TextOff = "Stance";
      this.StanceButton.TextOn = "Stance";
      this.StanceButton.Toggle = true;
      this.GenesisButton.Checked = false;
      this.GenesisButton.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.GenesisButton.KnockoutLocationPoint = point;
      point = new Point(236, 40);
      this.GenesisButton.Location = point;
      this.GenesisButton.Name = "GenesisButton";
      size = new Size(105, 22);
      this.GenesisButton.Size = size;
      this.GenesisButton.TabIndex = 120;
      this.GenesisButton.TextOff = "Genesis";
      this.GenesisButton.TextOn = "Genesis";
      this.GenesisButton.Toggle = true;
      this.hybridBtn.Checked = false;
      this.hybridBtn.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.hybridBtn.KnockoutLocationPoint = point;
      point = new Point(125, 40);
      this.hybridBtn.Location = point;
      this.hybridBtn.Name = "hybridBtn";
      size = new Size(105, 22);
      this.hybridBtn.Size = size;
      this.hybridBtn.TabIndex = 119;
      this.hybridBtn.TextOff = "Hybrid";
      this.hybridBtn.TextOn = "Hybrid";
      this.hybridBtn.Toggle = true;
      this.destinyBtn.Checked = false;
      this.destinyBtn.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.destinyBtn.KnockoutLocationPoint = point;
      point = new Point(14, 40);
      this.destinyBtn.Location = point;
      this.destinyBtn.Name = "destinyBtn";
      size = new Size(105, 22);
      this.destinyBtn.Size = size;
      this.destinyBtn.TabIndex = 118;
      this.destinyBtn.TextOff = "Destiny";
      this.destinyBtn.TextOn = "Destiny";
      this.destinyBtn.Toggle = true;
      this.loreBtn.Checked = false;
      this.loreBtn.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.loreBtn.KnockoutLocationPoint = point;
      point = new Point(347, 12);
      this.loreBtn.Location = point;
      this.loreBtn.Name = "loreBtn";
      size = new Size(105, 22);
      this.loreBtn.Size = size;
      this.loreBtn.TabIndex = 117;
      this.loreBtn.TextOff = "Lore";
      this.loreBtn.TextOn = "Lore";
      this.loreBtn.Toggle = true;
      this.interfaceBtn.Checked = false;
      this.interfaceBtn.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.interfaceBtn.KnockoutLocationPoint = point;
      point = new Point(236, 12);
      this.interfaceBtn.Location = point;
      this.interfaceBtn.Name = "interfaceBtn";
      size = new Size(105, 22);
      this.interfaceBtn.Size = size;
      this.interfaceBtn.TabIndex = 116;
      this.interfaceBtn.TextOff = "Interface";
      this.interfaceBtn.TextOn = "Interface";
      this.interfaceBtn.Toggle = true;
      this.judgementBtn.Checked = false;
      this.judgementBtn.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.judgementBtn.KnockoutLocationPoint = point;
      point = new Point(125, 12);
      this.judgementBtn.Location = point;
      this.judgementBtn.Name = "judgementBtn";
      size = new Size(105, 22);
      this.judgementBtn.Size = size;
      this.judgementBtn.TabIndex = 115;
      this.judgementBtn.TextOff = "Judgement";
      this.judgementBtn.TextOn = "Judgement";
      this.judgementBtn.Toggle = true;
      this.alphaBtn.Checked = true;
      this.alphaBtn.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.alphaBtn.KnockoutLocationPoint = point;
      point = new Point(14, 12);
      this.alphaBtn.Location = point;
      this.alphaBtn.Name = "alphaBtn";
      size = new Size(105, 22);
      this.alphaBtn.Size = size;
      this.alphaBtn.TabIndex = 114;
      this.alphaBtn.TextOff = "Alpha";
      this.alphaBtn.TextOn = "Alpha";
      this.alphaBtn.Toggle = true;
      this.ibClose.Checked = false;
      this.ibClose.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Pixel, (byte) 0);
      point = new Point(0, 0);
      this.ibClose.KnockoutLocationPoint = point;
      point = new Point(181, 473);
      this.ibClose.Location = point;
      this.ibClose.Name = "ibClose";
      size = new Size(105, 22);
      this.ibClose.Size = size;
      this.ibClose.TabIndex = 7;
      this.ibClose.TextOff = "Done";
      this.ibClose.TextOn = "Alt Text";
      this.ibClose.Toggle = false;
      this.AutoScaleMode = AutoScaleMode.None;
      this.BackColor = Color.FromArgb(0, 0, 32);
      size = new Size(466, 510);
      this.ClientSize = size;
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.OmegaButton);
      this.Controls.Add((Control) this.VitaeButton);
      this.Controls.Add((Control) this.StanceButton);
      this.Controls.Add((Control) this.GenesisButton);
      this.Controls.Add((Control) this.hybridBtn);
      this.Controls.Add((Control) this.destinyBtn);
      this.Controls.Add((Control) this.loreBtn);
      this.Controls.Add((Control) this.interfaceBtn);
      this.Controls.Add((Control) this.judgementBtn);
      this.Controls.Add((Control) this.alphaBtn);
      this.Controls.Add((Control) this.lblLock);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.ibClose);
      this.Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmIncarnate);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Powers";
      this.TopMost = true;
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      this.ResumeLayout(false);
    }

    private void interfaceBtn_ButtonClicked()
    {
      ImageButton interfaceBtn = this.interfaceBtn;
      this.SetPowerSet("Interface", ref interfaceBtn);
      this.interfaceBtn = interfaceBtn;
    }

    private void judgementBtn_ButtonClicked()
    {
      ImageButton judgementBtn = this.judgementBtn;
      this.SetPowerSet("Judgement", ref judgementBtn);
      this.judgementBtn = judgementBtn;
    }

    private void lblLock_Click(object sender, EventArgs e)
    {
      this.Locked = false;
      this.lblLock.Visible = false;
    }

    private void llLeft_ItemClick(ListLabelV2.ListLabelItemV2 Item, MouseButtons Button)
    {
      if (Button == MouseButtons.Right)
      {
        this.Locked = false;
        this.miniPowerInfo(Item.Index);
        this.lblLock.Visible = true;
        this.Locked = true;
      }
      else
      {
        if (Item.ItemState == ListLabelV2.LLItemState.Disabled)
          return;
        bool flag = !MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[Item.Index]);
        int num1 = this.llLeft.Items.Length - 1;
        for (int index = 0; index <= num1; ++index)
        {
          if (this.llLeft.Items[index].ItemState == ListLabelV2.LLItemState.Selected)
            this.llLeft.Items[index].ItemState = ListLabelV2.LLItemState.Enabled;
          if (MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[index]))
            MidsContext.Character.CurrentBuild.RemovePower(this.myPowers[index]);
        }
        int num2 = this.llRight.Items.Length - 1;
        for (int index = 0; index <= num2; ++index)
        {
          if (this.llRight.Items[index].ItemState == ListLabelV2.LLItemState.Selected)
            this.llRight.Items[index].ItemState = ListLabelV2.LLItemState.Enabled;
          if (MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[index + this.llLeft.Items.Length]))
            MidsContext.Character.CurrentBuild.RemovePower(this.myPowers[index + this.llLeft.Items.Length]);
        }
        if (flag)
        {
          MidsContext.Character.CurrentBuild.AddPower(this.myPowers[Item.Index], 49).StatInclude = true;
          Item.ItemState = ListLabelV2.LLItemState.Selected;
        }
        this.llLeft.Refresh();
        this.llRight.Refresh();
        this.myParent.PowerModified();
      }
    }

    private void llLeft_ItemHover(ListLabelV2.ListLabelItemV2 Item)
    {
      this.miniPowerInfo(Item.Index);
    }

    private void llLeft_MouseEnter(object sender, EventArgs e)
    {
      if (!this.ContainsFocus)
        return;
      this.Panel2.Focus();
    }

    private void llRight_ItemClick(ListLabelV2.ListLabelItemV2 Item, MouseButtons Button)
    {
      int pIDX = Item.Index + this.llLeft.Items.Length;
      if (Button == MouseButtons.Right)
      {
        this.Locked = false;
        this.miniPowerInfo(pIDX);
        this.lblLock.Visible = true;
        this.Locked = true;
      }
      else
      {
        if (Item.ItemState == ListLabelV2.LLItemState.Disabled)
          return;
        bool flag = !MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[pIDX]);
        int num1 = this.llLeft.Items.Length - 1;
        for (int index = 0; index <= num1; ++index)
        {
          if (this.llLeft.Items[index].ItemState == ListLabelV2.LLItemState.Selected)
            this.llLeft.Items[index].ItemState = ListLabelV2.LLItemState.Enabled;
          if (MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[index]))
            MidsContext.Character.CurrentBuild.RemovePower(this.myPowers[index]);
        }
        int num2 = this.llRight.Items.Length - 1;
        for (int index = 0; index <= num2; ++index)
        {
          if (this.llRight.Items[index].ItemState == ListLabelV2.LLItemState.Selected)
            this.llRight.Items[index].ItemState = ListLabelV2.LLItemState.Enabled;
          if (MidsContext.Character.CurrentBuild.PowerUsed(this.myPowers[index + this.llLeft.Items.Length]))
            MidsContext.Character.CurrentBuild.RemovePower(this.myPowers[index + this.llLeft.Items.Length]);
        }
        if (flag)
        {
          MidsContext.Character.CurrentBuild.AddPower(this.myPowers[pIDX], 49).StatInclude = true;
          Item.ItemState = ListLabelV2.LLItemState.Selected;
        }
        this.llLeft.Refresh();
        this.llRight.Refresh();
        this.myParent.PowerModified();
      }
    }

    private void llRight_ItemHover(ListLabelV2.ListLabelItemV2 Item)
    {
      this.miniPowerInfo(Item.Index + this.llLeft.Items.Length);
    }

    private void llRight_MouseEnter(object sender, EventArgs e)
    {
      this.llLeft_MouseEnter(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void loreBtn_ButtonClicked()
    {
      ImageButton loreBtn = this.loreBtn;
      this.SetPowerSet("Lore", ref loreBtn);
      this.loreBtn = loreBtn;
    }

    public void miniPowerInfo(int pIDX)
    {
      if (this.Locked)
        return;
      IPower power1 = (IPower) new Power(this.myPowers[pIDX]);
      power1.AbsorbPetEffects(-1);
      power1.ApplyGrantPowerEffects();
      PopUp.PopupData iPopup = new PopUp.PopupData();
      if (pIDX < 0)
      {
        this.PopInfo.SetPopup(iPopup);
        this.ChangedScrollFrameContents();
      }
      else
      {
        int index1 = iPopup.Add((PopUp.Section) null);
        string str1 = "";
        switch (power1.PowerType)
        {
          case Enums.ePowerType.Click:
            if (power1.ClickBuff)
            {
              str1 = "(Click)";
              break;
            }
            break;
          case Enums.ePowerType.Auto_:
            str1 = "(Auto)";
            break;
          case Enums.ePowerType.Toggle:
            str1 = "(Toggle)";
            break;
        }
        iPopup.Sections[index1].Add(power1.DisplayName, PopUp.Colors.Title, 1f, FontStyle.Bold, 0);
        iPopup.Sections[index1].Add(str1 + " " + power1.DescShort, PopUp.Colors.Text, 0.9f, FontStyle.Bold, 0);
        string str2 = power1.DescLong.Replace("<br>", "\r\n");
        iPopup.Sections[index1].Add(str1 + " " + str2, PopUp.Colors.Common, 1f, FontStyle.Regular, 0);
        int index2 = iPopup.Add((PopUp.Section) null);
        if ((double) power1.EndCost > 0.0)
        {
          if ((double) power1.ActivatePeriod > 0.0)
            iPopup.Sections[index2].Add("End Cost:", PopUp.Colors.Title, Utilities.FixDP(power1.EndCost / power1.ActivatePeriod) + "/s", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
          else
            iPopup.Sections[index2].Add("End Cost:", PopUp.Colors.Title, Utilities.FixDP(power1.EndCost), PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        }
        if (power1.EntitiesAutoHit == Enums.eEntity.None | (double) power1.Range > 20.0 & power1.I9FXPresentP(Enums.eEffectType.Mez, Enums.eMez.Taunt))
          iPopup.Sections[index2].Add("Accuracy:", PopUp.Colors.Title, Utilities.FixDP((float) ((double) MidsContext.Config.BaseAcc * (double) power1.Accuracy * 100.0)) + "%", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        if ((double) power1.RechargeTime > 0.0)
          iPopup.Sections[index2].Add("Recharge:", PopUp.Colors.Title, Utilities.FixDP(power1.RechargeTime) + "s", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        int durationEffectId = power1.GetDurationEffectID();
        float iNum = 0.0f;
        if (durationEffectId > -1)
          iNum = power1.Effects[durationEffectId].Duration;
        if (power1.PowerType != Enums.ePowerType.Toggle & power1.PowerType != Enums.ePowerType.Auto_ && (double) iNum > 0.0)
          iPopup.Sections[index2].Add("Duration:", PopUp.Colors.Title, Utilities.FixDP(iNum) + "s", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        if ((double) power1.Range > 0.0)
          iPopup.Sections[index2].Add("Range:", PopUp.Colors.Title, Utilities.FixDP(power1.Range) + "ft", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        if (power1.Arc > 0)
          iPopup.Sections[index2].Add("Arc:", PopUp.Colors.Title, Conversions.ToString(power1.Arc) + "°", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        else if ((double) power1.Radius > 0.0)
          iPopup.Sections[index2].Add("Radius:", PopUp.Colors.Title, Conversions.ToString(power1.Radius) + "ft", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        if ((double) power1.CastTime > 0.0)
          iPopup.Sections[index2].Add("Cast Time:", PopUp.Colors.Title, Utilities.FixDP(power1.CastTime) + "s", PopUp.Colors.Title, 0.9f, FontStyle.Bold, 1);
        IPower power2 = power1;
        if (power2.Effects.Length > 0)
        {
          iPopup.Sections[index2].Add("Effects:", PopUp.Colors.Title, 1f, FontStyle.Bold, 0);
          char[] chArray = new char[1]{ '^' };
          int num1 = power2.Effects.Length - 1;
          for (int index3 = 0; index3 <= num1; ++index3)
          {
            if ((power2.Effects[index3].EffectType != Enums.eEffectType.GrantPower | power2.Effects[index3].Absorbed_Effect) & power2.Effects[index3].EffectType != Enums.eEffectType.RevokePower & power2.Effects[index3].EffectType != Enums.eEffectType.SetMode)
            {
              int index4 = iPopup.Add((PopUp.Section) null);
              power1.Effects[index3].Power = power1;
              string[] strArray = power1.Effects[index3].BuildEffectString(false, "", false, false, false).Replace("[", "\r\n").Replace("\r\n", "^").Replace("  ", "").Replace("]", "").Split(chArray);
              int num2 = strArray.Length - 1;
              for (int index5 = 0; index5 <= num2; ++index5)
              {
                if (index5 == 0)
                  iPopup.Sections[index4].Add(strArray[index5], PopUp.Colors.Effect, 0.9f, FontStyle.Bold, 1);
                else
                  iPopup.Sections[index4].Add(strArray[index5], PopUp.Colors.Disabled, 0.9f, FontStyle.Italic, 2);
              }
            }
          }
        }
        this.PopInfo.SetPopup(iPopup);
        this.ChangedScrollFrameContents();
      }
    }

    private void OmegaButton_ButtonClicked()
    {
      ImageButton omegaButton = this.OmegaButton;
      this.SetPowerSet("Omega", ref omegaButton);
      this.OmegaButton = omegaButton;
    }

    private void PopInfo_MouseEnter(object sender, EventArgs e)
    {
      if (!this.ContainsFocus)
        return;
      this.VScrollBar1.Focus();
    }

    private void PopInfo_MouseWheel(object sender, MouseEventArgs e)
    {
      this.VScrollBar1.Value = Conversions.ToInteger(Operators.AddObject((object) this.VScrollBar1.Value, Interaction.IIf(e.Delta > 0, (object) -1, (object) 1)));
      if (this.VScrollBar1.Value > this.VScrollBar1.Maximum - 9)
        this.VScrollBar1.Value = this.VScrollBar1.Maximum - 9;
      this.VScrollBar1_Scroll(RuntimeHelpers.GetObjectValue(sender), new ScrollEventArgs(ScrollEventType.EndScroll, 0));
    }

    private void SetPowerSet(string Setname, ref ImageButton button)
    {
      foreach (ImageButton button1 in this.buttonArray)
        button1.Checked = false;
      button.Checked = true;
      this.myPowers = DatabaseAPI.GetPowersetByID(Setname, Enums.ePowerSetType.Incarnate).Powers;
      this.FillLists();
    }

    private void StanceButton_ButtonClicked()
    {
      ImageButton stanceButton = this.StanceButton;
      this.SetPowerSet("Stance", ref stanceButton);
      this.StanceButton = stanceButton;
    }

    protected void UpdateLLColours(ref ListLabelV2 iList)
    {
      iList.UpdateTextColors(ListLabelV2.LLItemState.Enabled, MidsContext.Config.RtFont.ColorPowerAvailable);
      iList.UpdateTextColors(ListLabelV2.LLItemState.Disabled, MidsContext.Config.RtFont.ColorPowerDisabled);
      iList.UpdateTextColors(ListLabelV2.LLItemState.Selected, MidsContext.Config.RtFont.ColorPowerTaken);
      iList.UpdateTextColors(ListLabelV2.LLItemState.SelectedDisabled, MidsContext.Config.RtFont.ColorPowerTakenDark);
      iList.UpdateTextColors(ListLabelV2.LLItemState.Invalid, Color.FromArgb((int) byte.MaxValue, 0, 0));
      iList.HoverColor = MidsContext.Config.RtFont.ColorPowerHighlight;
      iList.Font = new Font(iList.Font.FontFamily, MidsContext.Config.RtFont.PairedBase, FontStyle.Bold, GraphicsUnit.Point);
    }

    private void VitaeButton_ButtonClicked()
    {
      ImageButton vitaeButton = this.VitaeButton;
      this.SetPowerSet("Vitae", ref vitaeButton);
      this.VitaeButton = vitaeButton;
    }

    private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      if ((double) this.PopInfo.lHeight > (double) this.Panel1.Height & this.VScrollBar1.Maximum > this.VScrollBar1.LargeChange)
        this.PopInfo.ScrollY = (float) ((double) this.VScrollBar1.Value / (double) (this.VScrollBar1.Maximum - this.VScrollBar1.LargeChange) * ((double) this.PopInfo.lHeight - (double) this.Panel1.Height));
      else
        this.PopInfo.ScrollY = 0.0f;
    }

    public class CustomPanel : Panel
    {
      protected override Point ScrollToControl(Control activeControl)
      {
        return this.DisplayRectangle.Location;
      }
    }
  }
}