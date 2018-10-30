
//
//                            _ooOoo_
//                           o8888888o
//                           88" . "88
//                           (| -_- |)
//                           O\  =  /O
//                        ____/`---'\____
//                      .'  \\|     |//  `.
//                     /  \\|||  :  |||//  \
//                    /  _||||| -:- |||||-  \
//                    |   | \\\  -  /// |   |
//                    | \_|  ''\---/''  |   |
//                    \  .-\__  `-`  ___/-. /
//                  ___`. .'  /--.--\  `. . __
//               ."" '<  `.___\_<|>_/___.'  >'"".
//              | | :  `- \`.;`\ _ /`;.`/ - ` : | |
//              \  \ `-.   \_ __\ /__ _/   .-` /  /
//         ======`-.____`-.___\_____/___.-`____.-'======
//                            `=---='
//        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
//                 			 佛祖 保佑             

using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

public class TestEditor
{

    [MenuItem("Assets/Show Asset Ids")]
    static void MenuShowIds()
    {
        var stringBuilder = new StringBuilder();

        foreach (var obj in AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(Selection.activeObject)))
        {
            string guid;
            long file;

            
            
            /*if (AssetDatabase.TryGetGUIDAndLocalFileIdentifier(obj, out guid, out file))
            {
                stringBuilder.AppendFormat("Asset: " + obj.name +
                    "\n  Instance ID: " + obj.GetInstanceID() +
                    "\n  GUID: " + guid +
                    "\n  File ID: " + file);
            }*/
            
        }

        Debug.Log(stringBuilder.ToString());
    }
}
