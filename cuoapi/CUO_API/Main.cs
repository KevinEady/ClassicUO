using System;

namespace CUO_API
{
  public delegate void OnCastSpell(int idx);
  public delegate void OnClientClose();
  public delegate void OnConnected();
  public delegate void OnDisconnected();
  public delegate void OnFocusGained();
  public delegate void OnFocusLost();
  public delegate short OnGetPacketLength(int id);
  public delegate bool OnGetPlayerPosition(out int x, out int y, out int z);
  public delegate void OnGetStaticImage(ushort g, ref ArtInfo art);
  public delegate string OnGetUOFilePath();
  public delegate bool OnHotkey(int key, int mod, bool pressed);
  public delegate void OnInitialize();
  public delegate void OnMouse(int button, int wheel);
  public delegate bool OnPacketSendRecv(ref byte[] data, ref int length);
  public delegate void OnSetTitle(string title);
  public delegate void OnTick();
  public delegate void OnUpdatePlayerPosition(int x, int y, int z);
  public delegate bool RequestMove(int dir, bool run);
  public delegate bool OnPacketSendRecv_new(byte[] data, ref int length);
  public delegate bool OnPacketSendRecv_new_intptr(IntPtr data, ref int length);

  public struct PluginHeader
  {
    public int ClientVersion;
    public IntPtr Tick;
    public IntPtr GetStaticImage;
    public IntPtr CastSpell;
    public IntPtr GetPlayerPosition;
    public IntPtr GetPacketLength;
    public IntPtr Send;
    public IntPtr Recv;
    public IntPtr Send_new;
    public IntPtr Recv_new;
    public IntPtr GetUOFilePath;
    public IntPtr OnFocusLost;
    public IntPtr RequestMove;
    public IntPtr OnFocusGained;
    public IntPtr OnConnected;
    public IntPtr OnInitialize;
    public IntPtr OnClientClosing;
    public IntPtr OnPlayerPositionChanged;
    public IntPtr OnMouse;
    public IntPtr OnHotkeyPressed;
    public IntPtr OnSend;
    public IntPtr OnRecv;
    public IntPtr OnSend_new;
    public IntPtr OnRecv_new;
    public IntPtr HWND;
    public IntPtr OnDisconnected;
    public IntPtr SetTitle;
  }
  public struct ArtInfo
  {
    public long Address;
    public long Size;
    public long CompressedSize;
  }
}

