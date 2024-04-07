using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadFromWebExample : MonoBehaviour {
    private void Awake()
    {
        //AssetBundle.UnloadAllAssetBundles(true);
        Screen.SetResolution(/*屏幕宽度*/500,/*屏幕高度*/ 500, /*是否全屏显示*/false);
    }

    IEnumerator Start()
    {
        //AssetBundle.UnloadAllAssetBundles(true);

        

        //string uri = @"file:///E:\Project\Unity\2024\0405siki_AssetBundle\myProject\webserver\AssetBundles\share.unity3d";
        string uri = @"https://test321abc.oss-cn-shenzhen.aliyuncs.com/AssetBundles/share.unity3d";
        UnityWebRequest request = UnityWebRequest.GetAssetBundle(uri);
        yield return request.Send();
        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);

        //uri = @"http://localhost/AssetBundles/cubewall.unity3d";
        //uri = @"http://127.0.0.1/AssetBundles/cubewall.unity3d";
        uri = @"https://test321abc.oss-cn-shenzhen.aliyuncs.com/AssetBundles/cubewall.unity3d";
        request = UnityWebRequest.GetAssetBundle(uri);
        yield return request.Send();
        bundle = DownloadHandlerAssetBundle.GetContent(request);
        GameObject cube = bundle.LoadAsset<GameObject>("CubeWall.prefab");
        Instantiate(cube);

    }
}
