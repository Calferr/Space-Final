using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CameraChanger : MonoBehaviour
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


    void Start()
    {
        MainCamera.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MercuryCam")
        {
            MainCamera.SetActive(false);
            MercuryCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if(other.tag == "VenusCam")
        {
            MainCamera.SetActive(false);
            VenusCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "EarthCam")
        {
            MainCamera.SetActive(false);
            EarthCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "MarsCam")
        {
            MainCamera.SetActive(false);
            MarsCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "JupiterCam")
        {
            MainCamera.SetActive(false);
            JupiterCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "SaturnCam")
        {
            MainCamera.SetActive(false);
            SaturnCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "UranusCam")
        {
            MainCamera.SetActive(false);
            UranusCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "NeptuneCam")
        {
            MainCamera.SetActive(false);
            NeptuneCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
        else if (other.tag == "PlutoCam")
        {
            MainCamera.SetActive(false);
            PlutoCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
        }
    }
}
