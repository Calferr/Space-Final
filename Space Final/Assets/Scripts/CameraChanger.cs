using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CameraChanger : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject Player;
    public GameObject HUD;

    [Header("Planet Colliders")]
    public GameObject MercuryCollider;
    public GameObject VenusCollider;
    public GameObject EarthCollider;
    public GameObject MarsCollider;
    public GameObject JupiterCollider;
    public GameObject SaturnCollider;
    public GameObject UranusCollider;
    public GameObject NeptuneCollider;
    public GameObject PlutoCollider;

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
            Destroy(MercuryCollider);
            MercuryName.gameObject.SetActive(false);
        }
        else if(other.tag == "VenusCam")
        {
            MainCamera.SetActive(false);
            VenusCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(VenusCollider);
            VenusName.gameObject.SetActive(false);
        }
        else if (other.tag == "EarthCam")
        {
            MainCamera.SetActive(false);
            EarthCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(EarthCollider);
            EarthName.gameObject.SetActive(false);
        }
        else if (other.tag == "MarsCam")
        {
            MainCamera.SetActive(false);
            MarsCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(MarsCollider);
            MarsName.gameObject.SetActive(false);
        }
        else if (other.tag == "JupiterCam")
        {
            MainCamera.SetActive(false);
            JupiterCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(JupiterCollider);
            JupiterName.gameObject.SetActive(false);
        }
        else if (other.tag == "SaturnCam")
        {
            MainCamera.SetActive(false);
            SaturnCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(SaturnCollider);
            SaturnName.gameObject.SetActive(false);
        }
        else if (other.tag == "UranusCam")
        {
            MainCamera.SetActive(false);
            UranusCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(UranusCollider);
            UranusName.gameObject.SetActive(false);
        }
        else if (other.tag == "NeptuneCam")
        {
            MainCamera.SetActive(false);
            NeptuneCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(NeptuneCollider);
            NeptuneName.gameObject.SetActive(false);
        }
        else if (other.tag == "PlutoCam")
        {
            MainCamera.SetActive(false);
            PlutoCamera.SetActive(true);
            Player.SetActive(false);
            HUD.SetActive(false);
            Cursor.visible = true;
            Destroy(PlutoCollider);
            PlutoName.gameObject.SetActive(false);
        }
    }
}
