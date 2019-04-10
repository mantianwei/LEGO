# LEGODetection
基于ARKIT的乐高玩具增强现实益智类游戏探索——第一部分

## 项目说明
主要用到ARKIT2.0中的三维物体识别能力，首先需要用户提前观察记忆乐高六色块玩具的拼装步骤，在一定记忆时间后预制说明信息消失，用户开始手动拼装，Demo通过
对乐高模型的识别实时检测拼装状态，每完成一步就会有相应的提示与交互，直至拼装完成。
游戏最终会根据不同年龄段不同培养需求为用户提供不同类型不同难度的乐高六色块拼装方案，同时也可自定义模型，从而使得在儿童娱乐的同时能够达到锻炼记忆力与
智力的目的。


## 发布安装
环境
Mac OS10.14   
Unity 2018.2.15f1
Visual Studio 7.6.11
发布ios包，安装在Iphone X测试
Xcode 10.1

## 测试
针对不同的乐高玩具拼装状态，Demo会识别相对应步骤并提示。

## 说明

主要用到的ARKIT2.0接口与委托
[UnityARSessionNativeInterface.cs](./Assets/UnityARKitPlugin/Plugins/iOS/UnityARKit/NativeInterface/UnityARSessionNativeInterface.cs) 

public void RunWithConfigAndOptions( ARKitWorldTackingSessionConfiguration config, UnityARSessionRunOption runOptions )
public void RunWithConfig( ARKitWorldTackingSessionConfiguration config )

public delegate void ARFrameUpdate( UnityARCamera camera )

public delegate void ARObjectAnchorAdded(ARObjectAnchor anchorData);
public static event ARObjectAnchorAdded ARObjectAnchorAddedEvent;

public delegate void ARObjectAnchorUpdated(ARObjectAnchor anchorData);
public static event ARObjectAnchorUpdated ARObjectAnchorUpdatedEvent;

public delegate void ARObjectAnchorRemoved(ARObjectAnchor anchorData);
public static event ARObjectAnchorRemoved ARObjectAnchorRemovedEvent;

delegate void internal_ARObjectAnchorAdded(UnityARObjectAnchorData anchorData);
delegate void internal_ARObjectAnchorUpdated(UnityARObjectAnchorData anchorData);
delegate void internal_ARObjectAnchorRemoved(UnityARObjectAnchorData anchorData);
public static event ARSessionFailed ARSessionFailedEvent;
public static event ARSessionCallback ARSessionInterruptedEvent;
public static event ARSessionCallback ARSessioninterruptionEndedEvent;
public static event ARSessionTrackingChanged ARSessionTrackingChangedEvent;

监测识别乐高玩具状态
GenerateObjectAnchor.cs
GenerateLegoAnchor.cs
GenerateLego.cs

界面
InterfaceController.cs

乐高玩具扫描
ARKIT Scanner

## 参考博客
ARKit 2.0 Beta Update
How to use new features from Unity: [Whats New In ARKit 2.0](./docs/WhatsNewInARKit2_0.md)# LEGO
