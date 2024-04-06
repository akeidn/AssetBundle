using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFromFileExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        AssetBundle ab = AssetBundle.LoadFromFile("AssetBundles/share.unity3d"); //加载依赖包  

        ab = AssetBundle.LoadFromFile("AssetBundles/cubewall.unity3d");//加载模型
        GameObject wallPrefab = ab.LoadAsset<GameObject>("CubeWall.prefab");
        Instantiate(wallPrefab);

        
        

    }

    private void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    AssetBundle.LoadFromFile("AssetBundles/share.unity3d"); //加载依赖包  
        //}
    }


}
