
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
using UnityEngine;

public class PanelManager : MonoBehaviour
{

    #region 属性

    public static PanelManager Instance;

    public GameObject _main;
    public GameObject _seqNode;

    #endregion

    #region MONO Override

    void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start()
    {

    }


    #endregion

    #region Public

    public void OpenMain()
    {
        _main.SetActive(true);
        _seqNode.SetActive(false);
    }

    public void OpenSeq()
    {
        _main.SetActive(true);
        _seqNode.SetActive(true);

    }

    #endregion

    #region Private Methods



    #endregion
}
