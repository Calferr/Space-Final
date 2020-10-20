using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactivatingThePlayer : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject Player;
    public GameObject HUD;

    [Header("Planet Name Tags")]
    public Text MercuryName;
    public Text VenusName;
    public Text EarthName;
    public Text MarsName;
    public Text JupiterName;
    public Text SaturnName;
    public Text UranusName;
    public Text NeptuneName;
    public Text PlutoName;

    [Header("Cameras")]
    public GameObject MainCamera;
    public GameObject MercuryCamera;
    public GameObject VenusCamera;
    public GameObject EarthCamera;
    public GameObject MarsCamera;
    public GameObject JupiterCamera;
    public GameObject SaturnCamera;
    public GameObject UranusCamera;
    public GameObject NeptuneCamera;
    public GameObject PlutoCamera;


    // Update is called once per frame
    public void Reactivate()
    {
        Player.SetActive(true);
        HUD.SetActive(true);
        MainCamera.SetActive(true);
        MercuryCamera.SetActive(false);
        MercuryName.gameObject.SetActive(true);
        VenusCamera.SetActive(false);
        VenusName.gameObject.SetActive(true);
        EarthCamera.SetActive(false);
        EarthName.gameObject.SetActive(true);
        MarsCamera.SetActive(false);
        MarsName.gameObject.SetActive(true);
        JupiterCamera.SetActive(false);
        JupiterName.gameObject.SetActive(true);
        SaturnCamera.SetActive(false);
        SaturnName.gameObject.SetActive(true);
        UranusCamera.SetActive(false);
        UranusName.gameObject.SetActive(true);
        NeptuneCamera.SetActive(false);
        NeptuneName.gameObject.SetActive(true);
        PlutoCamera.SetActive(false);
        PlutoName.gameObject.SetActive(true);
    }
}
