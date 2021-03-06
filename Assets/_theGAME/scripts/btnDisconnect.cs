﻿using UnityEngine;
using UnityEngine.UI;

public class btnDisconnect : MonoBehaviour {

    NetworkManager networkManager;

	// Use this for initialization
	void Start () {
        networkManager = FindObjectOfType<NetworkManager>();
        GetComponent<Button>().onClick.AddListener(LeaveRoom);
	}

    void LeaveRoom() {
        Debug.Log("We are being clicked");
        networkManager.LeaveRoom();
    }
}
