using UnityEngine;
using UnityEditor.Experimental.AssetImporters;
using System.IO;

//监听的后缀名
[ScriptedImporter(1, "yusongmomo")]
public class Script_03_33 : ScriptedImporter
{
    //监听自定义资源导入
    public override void OnImportAsset(AssetImportContext ctx)
    {
        //创建立方体对象
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //将参数提取出来
        var position = JsonUtility.FromJson<Vector3>(File.ReadAllText(ctx.assetPath));

        cube.transform.position = position;
        cube.transform.localScale = Vector3.one;
        //将立方体绑定到对象身上
        ctx.AddObjectToAsset("obj", cube);
        ctx.SetMainObject(cube);

        //添加材质
        var material = new Material(Shader.Find("Standard"));
        material.color = Color.red;
        ctx.AddObjectToAsset("material", material);
        
        var tempMesh = new Mesh();
        DestroyImmediate(tempMesh);
    }
}