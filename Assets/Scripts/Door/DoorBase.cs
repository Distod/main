﻿/*********************************************************/
//Doorのベースクラス
/*********************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DoorBase : MonoBehaviour {

    //閉じる
    [SerializeField]
    protected bool mIsOpenOnly;
    //移動スピード
    [SerializeField]
    protected float mSpeed=1.0f;
    //開いている最中かどうか
    [SerializeField]
    protected bool mIsOpen = false;
    //ゴール用のドアかどうか
    [SerializeField]
    protected bool isGoalDoor = false;

    //ドアを固定する
    [SerializeField]
    protected bool isLockDoor = false;

    //プレイヤー
    protected Transform mPlayer;
    //ドア
    protected Goal mGoal;

    /*********************************************************/
    //ドアを開けた際の処理
    /*********************************************************/
    public abstract void Action();

    /*********************************************************/
    //ドアを開いたり開けたりできなくする
    /*********************************************************/
    public bool IsLockDoor() { return isLockDoor; }

    /*********************************************************/
    //ドアを閉める
    /*********************************************************/
    public void CloseDoor() { mIsOpen = false; }
}
