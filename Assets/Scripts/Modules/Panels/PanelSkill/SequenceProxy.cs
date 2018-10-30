
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
using Summer;
using UnityEngine;

public class SequenceProxy
{

    public static SequenceProxy Instance = new SequenceProxy();
    private SequenceProxy()
    {
        Init();
    }
    public const string FILEPATH = "/StringBuild_Log.txt";
    public void Save(SequenceInfo info)
    {
        LogManager.Log(Application.dataPath);
        string path = Application.dataPath;
        int index = path.LastIndexOf('/');
        path = path.Substring(0, index);
        path = path + FILEPATH;

        LogManager.Log(path);
    }

    private void Init()
    {

    }
}
