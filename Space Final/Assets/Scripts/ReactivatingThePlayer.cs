using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactivatingThePlayer : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject Player;
    public GameObject HUD;

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
        VenusCamera.SetActive(false);
        EarthCamera.SetActive(false);
        MarsCamera.SetActive(false);
        JupiterCamera.SetActive(false);
        SaturnCamera.SetActive(false);
        UranusCamera.SetActive(false);
        NeptuneCamera.SetActive(false);
        PlutoCamera.SetActive(false);
    }
}
