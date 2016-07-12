﻿using UnityEngine;
using System.Collections;

public interface IAgoraPlugin {

    void InitSDK(string vendorKey);

    void JoinChannel(string channelId);

    void LeaveChannel();
}