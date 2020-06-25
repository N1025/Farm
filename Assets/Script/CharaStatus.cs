using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public abstract class CharaStatus : ScriptableObject
{
    public enum Gender
    {
        男,
        女
    }
    public enum Personality
    {
        無垢,
        光の先導者,
        光,
        光を秘めし者,
        闇の先導者,
        闇,
        闇を秘めし者,
        猪突猛進,
        純粋無垢,
        狷介孤高
    }
    public enum Job
    {
        なし,
        ファーマー,
        ハンター,
        エクスプローラー
    }
    // キャラの名前
    [SerializeField]
    private string charaName = "";
    // 性別
    [SerializeField]
    public Gender gender = Gender.男;
    // 性格
    [SerializeField]
    public Personality personality = Personality.無垢;
    // 職業
    [SerializeField]
    public Job job = Job.なし;
    // 善悪値
    [SerializeField]
    private int hvp = 0;
    // 陰陽値
    [SerializeField]
    private int ssp = 0;
    // 魅力
    [SerializeField]
    private int cha = 0;
    // 筋力
    [SerializeField]
    private int str = 0;
    // 体力
    [SerializeField]
    private int con = 0;
    // 精神力
    [SerializeField]
    private int pow = 0;
    // 敏捷性
    [SerializeField]
    private int dex = 0;
    // 知力
    [SerializeField]
    private int Int=0;

    public void SetCharaName(string charaName)
    {
        this.charaName = charaName;
    }

    public string GetCharaName()
    {
        return charaName;
    }

    public Gender GetGender()
    {
        return gender;
    }

    public Personality GetPersonality()
    {
        return personality;
    }

    public Job GetJob()
    {
        return job;
    }

    public void Sethvp(int hvp)
    {
        this.hvp = hvp;
    }

    public int Gethvp()
    {
        return hvp;
    }

    public void Setssp(int ssp)
    {
        this.ssp = ssp;
    }

    public int Getssp()
    {
        return ssp;
    }

    public void Setcha(int cha)
    {
        this.cha = cha;
    }

    public int Getcha()
    {
        return cha;
    }

    public void Setstr(int str)
    {
        this.str = str;
    }

    public int Getstr()
    {
        return str;
    }

    public void Setcon(int con)
    {
        this.con = con;
    }

    public int Getcon()
    {
        return con;
    }

    public void Setpow(int pow)
    {
        this.ssp = pow;
    }

    public int Getpow()
    {
        return pow;
    }

    public void Setdex(int dex)
    {
        this.dex = dex;
    }

    public int Getdex()
    {
        return dex;
    }

    public void SetInt(int Int)
    {
        this.Int = Int;
    }

    public int GetInt()
    {
        return Int;
    }
}
